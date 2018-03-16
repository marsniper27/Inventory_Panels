using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Panel
{
    class Database
    {
        public string connetionString = "Data Source=156.34.219.39,1433;Network Library=DBMSSOCN;Initial Catalog=InventorySystem;User ID=sa;Password=Jac0bI2aac1!";

        DataSet1 InventorySystem = new DataSet1();
        public void ReadDataBase()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            try
            {

                cnn.Open();
                SqlDataAdapter TeamAdapter = new SqlDataAdapter("SELECT * FROM Teams", cnn);
                SqlDataAdapter MachineAdapter = new SqlDataAdapter("SELECT * FROM Machines", cnn);
                SqlDataAdapter EmployeeAdapter = new SqlDataAdapter("SELECT * FROM Employees", cnn);
                SqlDataAdapter EquipmentAdapter = new SqlDataAdapter("SELECT * FROM Equipment", cnn);
                TeamAdapter.Fill(InventorySystem, "Teams");
                MachineAdapter.Fill(InventorySystem, "Machines");
                EmployeeAdapter.Fill(InventorySystem, "Employees");
                EquipmentAdapter.Fill(InventorySystem, "Equipment");

                foreach (DataRow R in InventorySystem.Tables["Teams"].Rows)
                {
                    Team t = new Team();
                    t.Name = R["Name"].ToString();
                    Details.Teams.Add(t);
                }

                foreach (DataRow r in InventorySystem.Tables["Employees"].Rows)
                {
                    Employee e = new Employee();
                    e.ID = int.Parse(r["ID"].ToString());
                    e.FirstName = r["FirstName"].ToString();
                    e.LastName = r["LastName"].ToString();
                    e.Team = r["Team"].ToString();
                    e.Role = r["Role"].ToString();
                    e.idCard = int.Parse(r["ID Card"].ToString());
                    e.Name = r["FirstName"].ToString() + " " + r["LastName"].ToString();

                    Details.EmployeeList.Add(e);
                }

                foreach (DataRow r in InventorySystem.Tables["Equipment"].Rows)
                {
                    Equipment eq = new Equipment();
                    eq.ID = int.Parse(r["ID"].ToString());
                    eq.Type = r["Type"].ToString();
                    eq.SerialNumber = int.Parse(r["Serial Number"].ToString());
                    eq.Barcode = int.Parse(r["Barcode"].ToString());
                    eq.ITSNumber = int.Parse(r["ITS Number"].ToString());
                    eq.Status = r["Status"].ToString();
                    eq.Availability = r["Availability"].ToString();

                    Details.EquipmentList.Add(eq);
                }
                cnn.Close();

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void updateEquipmentStatus(string updateState)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                SqlCommand equipmentStatus = new SqlCommand();
                equipmentStatus.Connection = cnn;
                equipmentStatus.CommandText = "Update Equipment Set Availability = @availability Where Barcode = "+Details.Equipment.Barcode;
                equipmentStatus.Parameters.AddWithValue("@availability", updateState);
                equipmentStatus.ExecuteNonQuery();


                SqlCommand updateInUse = new SqlCommand();
                updateInUse.Connection = cnn;

                if (updateState == "In Use")
                {
                    updateInUse.CommandText = $"INSERT INTO InUseEquipment(Employee,EmployeeName,Equipment,[Date Out],[Status Out]) Values("+ Details.Employee.ID +","+ Details.Employee.Name + "," + Details.Equipment.Type + "," + DateTime.Now + "," + Details.Equipment.Status + ")";
                    updateInUse.ExecuteNonQuery();
                    MessageBox.Show($"Equipment: {Details.Equipment.Type}\n" +
                                    $"Barcode: {Details.Equipment.Barcode}\n" +
                                    $"Has been asigned to: {Details.Employee.Name}");
                }
                if (updateState == "Available ")
                {
                    updateInUse.CommandText = "Update InUseEquipment Set [Date In] = " + DateTime.Now + ",[Status Out] = " + Details.Equipment.Status + "Where Equipment = " + Details.Equipment.ID;
                    updateInUse.ExecuteNonQuery();
                    MessageBox.Show($"Equipment: {Details.Equipment.Type}\n" +
                                    $"Barcode: {Details.Equipment.Barcode}\n" +
                                    $"Has been returned by: {Details.Employee.Name}");
                }

                Details.EquipmentList.Clear();
                SqlDataAdapter EquipmentAdapter = new SqlDataAdapter("SELECT * FROM Equipment", cnn);
                EquipmentAdapter.Fill(InventorySystem, "Equipment");
                foreach (DataRow r in InventorySystem.Tables["Equipment"].Rows)
                {
                    Equipment eq = new Equipment();
                    eq.ID = int.Parse(r["ID"].ToString());
                    eq.Type = r["Type"].ToString();
                    eq.SerialNumber = int.Parse(r["Serial Number"].ToString());
                    eq.Barcode = int.Parse(r["Barcode"].ToString());
                    eq.ITSNumber = int.Parse(r["ITS Number"].ToString());
                    eq.Status = r["Status"].ToString();
                    eq.Availability = r["Availability"].ToString();

                    Details.EquipmentList.Add(eq);
                }
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        //public void CreateDataset(SqlConnection cnn)
        //{

        //    //}
        //    //public void AddMachine()
        //    //{
        //    //    SqlConnection cnn = new SqlConnection(connetionString);
        //    //    try
        //    //    {
        //    //        cnn.Open();
        //    //        MessageBox.Show("Connection Open!");
        //    //        SqlCommand myCommand = new SqlCommand();
        //    //        myCommand.Connection = cnn;
        //    //        myCommand.CommandText = "INSERT INTO Machines (Type,Status,Team)" + "Values ('EGM','Working','Four Kings')";
        //    //        myCommand.ExecuteNonQuery();
        //    //        MessageBox.Show("Machine Added");
        //    //        cnn.Close();
        //    //    }
        //    //    catch (Exception e)
        //    //    {
        //    //        Console.WriteLine(e.ToString());
        //    //    }
        //    //}
        //}
    }
}
