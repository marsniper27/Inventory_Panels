using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Panel
{
    public partial class Main : Form
    {
        bool logged = false;

        public Main()
        {
            InitializeComponent();
            var date = DateTime.Now;
            var monthDays = DateTime.DaysInMonth(date.Year, date.Month);
            if (date.Day == monthDays && !logged)
            {
                var xl = new Excel_book();
                logged = xl.MonthlyLog();
            }
            if (date.Day == 2 && logged)
            {
                logged = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var DB = new Database();
            DataSet1 ds = new DataSet1();
            DB.ReadDataBase();
            Details.data = ds;

            var load = new Loading();
            Details.Load = load;
            this.Controls.Add(load);
            panel1.Hide();

            load.Show();
            this.Show();

            Details.File = @"C:\Users\kyle.marshall\Documents\Projects\Inventory Panel\Inventory_Panels\InventoryTracking.xls";
            // Details.File = @"C:\Users\Kyle\Source\Repos\Inventory_Panels\InventoryTracking.xls";
            //Details.File = Application.StartupPath + @"InventoryTracking.xls";
        
            load.Hide();
            panel1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkOut = new Check_Out();
            checkOut.VisibleChanged += ReturnToMain_VisibleChanged;
            this.Controls.Add(checkOut);
            panel1.Hide();
            checkOut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var checkIn = new CheckIn();
            checkIn.VisibleChanged += ReturnToMain_VisibleChanged;
            this.Controls.Add(checkIn);
            panel1.Hide();
            checkIn.Show();
        }

        private void ReturnToMain_VisibleChanged(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            if(panel.Visible == true)
            {
                return;
            }
            else if(panel.Visible == false && Details.Load.Visible == false)
            {
                panel1.Show();
            }
        }

        private void Database_Click(object sender, EventArgs e)
        {
            var dataViewer = new DatabaseViewer();
            dataViewer.Show();
            //System.Diagnostics.Process.Start(Details.File);
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            var E = new Employees();
            E.InitializeComponent();
            E.Dock = DockStyle.Fill;
            this.Controls.Add(E);
            panel1.Hide();
            E.Show();
        }
    }
}
