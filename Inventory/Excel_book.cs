using System;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

using System.Windows.Forms;
using System.IO;

namespace Inventory_Panel
{
    class Excel_book
    {
        string file = Details.File;

        public void createWorkbook()
        {
            if (File.Exists(file) == true)
            {
                return;
            }
            if (File.Exists(file) == false)
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not properly installed!!");
                    return;
                }

                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = "Employee";

                xlWorkSheet.Cells[1, 1] = "ID";
                xlWorkSheet.Cells[1, 2] = "Name";
                xlWorkSheet.Cells[1, 3] = "Team";


                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                xlWorkSheet.Name = "Equipment";

                xlWorkSheet.Cells[1, 1] = "Item";
                xlWorkSheet.Cells[1, 2] = "ITS #";
                xlWorkSheet.Cells[1, 3] = "BareCode";
                xlWorkSheet.Cells[1, 4] = "Status";

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
                xlWorkSheet.Name = "Equipment in use";

                xlWorkSheet.Cells[1, 1] = "Tester";
                xlWorkSheet.Cells[1, 2] = "Team";
                xlWorkSheet.Cells[1, 3] = "Item";
                xlWorkSheet.Cells[1, 4] = "ITS #";
                xlWorkSheet.Cells[1, 5] = "BareCode";
                xlWorkSheet.Cells[1, 6] = "Time Out";

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add(After: xlWorkBook.Worksheets[3]);
                xlWorkSheet.Name = "Log";

                xlWorkSheet.Cells[1, 1] = "Tester";
                xlWorkSheet.Cells[1, 2] = "Team";
                xlWorkSheet.Cells[1, 3] = "Item";
                xlWorkSheet.Cells[1, 4] = "ITS #";
                xlWorkSheet.Cells[1, 5] = "BareCode";
                xlWorkSheet.Cells[1, 6] = "Time Out";
                xlWorkSheet.Cells[1, 7] = "Time In";



                xlWorkBook.SaveAs(file, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                foreach(var sheet in xlWorkBook.Sheets)
                {

                    Marshal.ReleaseComObject(sheet);
                }
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);

                MessageBox.Show($"Excel file created , you can find the file at: {file}");
            }

        }

        public void readWorkBook()
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            if (File.Exists(file) == false)
            {
                MessageBox.Show("Database can not be found");
            }
            if (File.Exists(file) == true)
            {
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                Excel.Range xlRange;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(file);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                xlRange = xlWorkSheet.Cells[xlWorkSheet.Rows.Count, 1];
                long lastRow = xlRange.get_End(Excel.XlDirection.xlUp).Row;

                for (long x = 2; x <= lastRow ;x++)
                {
                    Employee e = new Employee();
                    e.idCard = xlWorkSheet.Cells[x, 1].Value;
                    e.Name = xlWorkSheet.Cells[x, 2].Value;
                    e.Team = xlWorkSheet.Cells[x, 3].Value;
                    Details.EmployeeList.Add(e);
                }


                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

        public void CheckIn(int Barcode)
        {
            if (File.Exists(file) == false)
            {
                MessageBox.Show("Database can not be found");
            }
            if (File.Exists(file) == true)
            {

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet EquipmentSheet;
                Excel.Worksheet EquipmentInUseSheet;
                Excel.Worksheet LogWorksheet;
                object misValue = System.Reflection.Missing.Value;
                Excel.Range xlRange;
                Excel.Range currentFind = null;
                Excel.Range currentFind2 = null;
                Excel.Range barcodeRange = null;
                Excel.Range barcodeRange2 = null;

                xlWorkBook = xlApp.Workbooks.Open(file);

                EquipmentSheet = xlWorkBook.Worksheets.get_Item(2);
                EquipmentInUseSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);
                LogWorksheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);

                barcodeRange = EquipmentInUseSheet.get_Range("E:E");
                

                currentFind = barcodeRange.Find(Barcode, misValue,
                Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
                Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                misValue, misValue);

                if (currentFind != null)
                {

                    var add = currentFind.Address[true, true, Excel.XlReferenceStyle.xlA1, false, null];

                    MessageBox.Show($"Barcode found at: {add}");

                    xlRange = (Excel.Range)LogWorksheet.Cells[EquipmentInUseSheet.Rows.Count, 1];
                    long lastRow = xlRange.get_End(Excel.XlDirection.xlUp).Row;
                    long newRow = lastRow + 1;

                    MessageBox.Show($"New Row: {newRow}");

                    Excel.Range row = EquipmentInUseSheet.get_Range(add, misValue).EntireRow;
                    Excel.Range nextRow = LogWorksheet.get_Range($"A{newRow}", misValue).EntireRow;

                    nextRow.Value = row.Value;

                    LogWorksheet.Cells[newRow, 7] = DateTime.Now;

                    row.EntireRow.Delete(Excel.XlDirection.xlUp);


                    barcodeRange2 = EquipmentSheet.get_Range("C:C");

                    currentFind2 = barcodeRange2.Find(Barcode, misValue,
                    Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
                    Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                    misValue, misValue);

                    if (currentFind2 != null)
                    {
                        EquipmentSheet.Cells[currentFind2.Row, 4].Value = "Available";
                    }
                    if (currentFind == null)
                    {
                        MessageBox.Show($"The barcode can not be found in Equipment List.\r\nThe barcode is {0}", Barcode.ToString());
                    }

                }
                if(currentFind == null)
                {
                    MessageBox.Show($"The barcode can not be found in In use list.\r\nThe barcode is {0}", Barcode.ToString());
                }

                xlWorkBook.Close(true);
                xlApp.Quit();

                Marshal.ReleaseComObject(EquipmentSheet);
                Marshal.ReleaseComObject(EquipmentInUseSheet);
                Marshal.ReleaseComObject(LogWorksheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

        public void CheckOut(int Barcode)
        {
            if (File.Exists(file) == false)
            {
                MessageBox.Show("Database can not be found");
            }
            if (File.Exists(file) == true)
            {

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkBook;
                Excel.Worksheet EquipmentSheet;
                Excel.Worksheet EquipmentInUseSheet;
                object misValue = System.Reflection.Missing.Value;
                Excel.Range xlRange;
                Excel.Range currentFind = null;

                xlWorkBook = xlApp.Workbooks.Open(file);

                EquipmentSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);
                EquipmentInUseSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);

                Excel.Range barcodeRange = EquipmentSheet.get_Range("C:C");


                currentFind = barcodeRange.Find(Barcode, misValue,
                Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
                Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                misValue, misValue);

                if (currentFind != null)
                {

                    var add = currentFind.Address[true, true, Excel.XlReferenceStyle.xlA1, false, null];
                    int x = currentFind.Row;

                    if (EquipmentSheet.Cells[x, 4].value == "Available")
                    {
                        MessageBox.Show($"Barcode found at: {add}");

                        xlRange = (Excel.Range)EquipmentInUseSheet.Cells[EquipmentSheet.Rows.Count, 1];
                        long lastRow = (long)xlRange.get_End(Excel.XlDirection.xlUp).Row;
                        long newRow = lastRow + 1;

                        MessageBox.Show($"New Row: {newRow}");

                        
                        EquipmentSheet.get_Range($"A{x}", add).Copy(EquipmentInUseSheet.get_Range($"C{newRow}", $"E{newRow}"));
                        EquipmentSheet.Cells[x, 4].Value = "In Use";
                        

                        EquipmentInUseSheet.Cells[newRow, 1] = Details.Employee.Name;
                        EquipmentInUseSheet.Cells[newRow, 2] = Details.Employee.Team;
                        EquipmentInUseSheet.Cells[newRow, 6] = DateTime.Now;
                    }
                    else if(EquipmentSheet.Cells[x, 4].value == "In Use")
                    {
                        MessageBox.Show($"The {EquipmentSheet.Cells[x, 1].value} with serial number {EquipmentSheet.Cells[x, 3].value} is already in use.");
                    }
                }
                if (currentFind == null)
                {
                    MessageBox.Show($"The barcode can not be found.\r\nThe barcode is {0}", Barcode.ToString());
                }
                xlWorkBook.Close(true);
                xlApp.Quit();

                Marshal.ReleaseComObject(EquipmentSheet);
                Marshal.ReleaseComObject(EquipmentInUseSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
            }
        }

        public bool MonthlyLog()
        {
            if (!File.Exists(file))
            {
                MessageBox.Show("Database can not be found");
                return false;
            }
            if (File.Exists(file))
            {
                Excel.Application xlApp = new Excel.Application();
                var date = DateTime.Now;
                var datex = $"{date.Day}_{date.Month}_{ date.Year}_{date.Minute}_{date.Hour}";
                var newbook = $@"C:\Users\kyle.marshall\Documents\Projects\Inventory\Monthly_Log_{datex}.xlsx";

                Excel.Workbooks xlWorkBooks = xlApp.Workbooks;
                Excel.Workbook xlWorkBook = xlWorkBooks.Open(file); 
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(4);
                object misValue = System.Reflection.Missing.Value;
                
                xlWorkSheet.Copy(misValue, misValue);
                var x = Task.Run(async delegate
                {
                    await Task.Delay(5000);
                });
                x.Wait();

                xlApp.Workbooks[1].SaveAs(Filename: newbook);

                var t = Task.Run(async delegate
                {
                    await Task.Delay(5000);
                });
                t.Wait();
                foreach (Excel.Workbook book in xlWorkBooks)
                {
                    foreach (Excel.Worksheet sheet in book.Sheets)
                    {
                        Marshal.ReleaseComObject(sheet);
                    }
                    book.Close(false);
                    Marshal.ReleaseComObject(book);
                }
                xlWorkBooks.Close();
                Marshal.ReleaseComObject(xlWorkBooks);
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                GC.Collect();
                return true;
            }
            return false;
        }
    }
}
