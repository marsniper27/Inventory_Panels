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
        public string connectionString = "Data Source=156.34.219.39,1433;Network Library=DBMSSOCN;Initial Catalog=InventorySystem;User ID=sa;Password=Jac0bI2aac1!";

        DataSet1 InventorySystem = new DataSet1();
        public void ReadDataBase()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlDataAdapter TeamAdapter = new SqlDataAdapter("SELECT * FROM Teams", cnn);
                SqlDataAdapter MachineAdapter = new SqlDataAdapter("SELECT * FROM Machines", cnn);
                SqlDataAdapter EmployeeAdapter = new SqlDataAdapter("SELECT * FROM Employees", cnn);
                SqlDataAdapter EquipmentAdapter = new SqlDataAdapter("SELECT * FROM Equipment", cnn);
                SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment", cnn);
                TeamAdapter.Fill(InventorySystem, "Teams");
                MachineAdapter.Fill(InventorySystem, "Machines");
                EmployeeAdapter.Fill(InventorySystem, "Employees");
                EquipmentAdapter.Fill(InventorySystem, "Equipment");
                InUseEquipmentAdapter.Fill(InventorySystem, "InUseEquipment");

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
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand equipmentStatus = new SqlCommand();
                equipmentStatus.Connection = cnn;
                equipmentStatus.CommandText = "Update Equipment Set Availability = @availability Where Barcode = "+ Details.Equipment.Barcode;
                equipmentStatus.Parameters.AddWithValue("@availability", updateState);
                equipmentStatus.ExecuteNonQuery();


                SqlCommand updateInUse = new SqlCommand();
                updateInUse.Connection = cnn;

                if (updateState == "In Use")
                {
                    updateInUse.CommandText = $"INSERT INTO InUseEquipment (Employee,[Employee Name],Equipment,[Equipment Type],[Date Out],[Status Out]) Values("+Details.Employee.ID+",@name,@Equipment,@type,@date,@status)";
                    updateInUse.Parameters.AddWithValue("@name", Details.Employee.Name);
                    updateInUse.Parameters.AddWithValue("@type", Details.Equipment.Type);
                    updateInUse.Parameters.AddWithValue("@date", DateTime.Now);
                    updateInUse.Parameters.AddWithValue("@status", Details.Equipment.Status);
                    updateInUse.Parameters.AddWithValue("@Equipment", Details.Equipment.ID);
                    updateInUse.ExecuteNonQuery();
                    MessageBox.Show($"Equipment: {Details.Equipment.Type}\n" +
                                    $"Barcode: {Details.Equipment.Barcode}\n" +
                                    $"Has been asigned to: {Details.Employee.Name}");
                }
                if (updateState == "Available")
                {
                    updateInUse.CommandText = "Update InUseEquipment Set [Date In] = @date,[Status In] = @status Where Equipment = @ID AND [Date In] IS NULL ";
                    updateInUse.Parameters.AddWithValue("@date", DateTime.Now);
                    updateInUse.Parameters.AddWithValue("@status", Details.Equipment.Status);
                    updateInUse.Parameters.AddWithValue("@ID", Details.Equipment.ID);
                    updateInUse.ExecuteNonQuery();
                    MessageBox.Show($"Equipment: {Details.Equipment.Type}\n" +
                                    $"Barcode: {Details.Equipment.Barcode}\n" +
                                    $"Has been returned by: {Details.Employee.Name}");
                }


                SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment", cnn);
                InUseEquipmentAdapter.Fill(InventorySystem, "InUseEquipment");

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
        public string CheckInUSe(int ID)
        {

            string name = "";

            InUseEquipment IUE = new InUseEquipment();
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter InUseEquipmentAdapter = new SqlDataAdapter("SELECT * FROM InUseEquipment Where Equipment = @ID AND [Date In] IS NULL ", cnn);
            InUseEquipmentAdapter.SelectCommand.Parameters.AddWithValue("@ID", ID);
            InUseEquipmentAdapter.Fill(InventorySystem, "InUseEquipment");


            foreach (DataRow r in InventorySystem.Tables["InUseEquipment"].Rows)
            {
                if(int.Parse(r["Equipment"].ToString()) == ID)
                {
                    name = r["Employee Name"].ToString();

                    return name;
                }
            }
            return name;
        }
    }
}
