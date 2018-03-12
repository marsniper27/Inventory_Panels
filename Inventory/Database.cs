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

        public void ReadDataBase()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            try
            {

                DataSet InventorySystem = new DataSet();
                cnn.Open();
                SqlDataAdapter TeamAdapter = new SqlDataAdapter("SELECT * FROM Teams", cnn);
                SqlDataAdapter MachineAdapter = new SqlDataAdapter("SELECT * FROM Machines", cnn);
                SqlDataAdapter EmployeeAdapter = new SqlDataAdapter("SELECT * FROM Employees", cnn);
                TeamAdapter.Fill(InventorySystem, "Teams");
                MachineAdapter.Fill(InventorySystem, "Machines");
                //EmployeeAdapter.Fill(InventorySystem, "Employees");
                //foreach (DataRow R in InventorySystem.Tables["Teams"].Rows)
                //{
                //    Console.WriteLine(R["Name"]);
                //}

                //MessageBox.Show("Connection Open!");
                //SqlDataReader myReader = null;
                //SqlCommand myCommand = new SqlCommand("select * from Teams", cnn);
                //myReader = myCommand.ExecuteReader();
                //while (myReader.Read())
                //{
                //    Console.WriteLine(myReader["ID"].ToString());
                //    Console.WriteLine(myReader["Name"].ToString());
                //    Console.WriteLine(myReader["BMM Manager"].ToString());
                //    Console.WriteLine(myReader["IGT Manager"].ToString());
                //}
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void CreateDataset(SqlConnection cnn)
        {
            
        }
        public void AddMachine()
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open!");
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = cnn;
                myCommand.CommandText = "INSERT INTO Machines (Type,Status,Team)" + "Values ('EGM','Working','Four Kings')";
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Machine Added");
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
