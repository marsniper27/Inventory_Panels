using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Panel
{
    public partial class CheckIn : Panel
    { 
        public CheckIn()
        {
            InitializeComponent();
            main();
        }

        public void main()
        {
            var barcode = new BarcodeScanner();
            var Barcode = barcode.read();
            barcodeBox.Text = Barcode.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (barcodeBox.Text == null)
            {
                MessageBox.Show("Barcode not read");
            }
            else
            {
                foreach (Control ctl in Details.Load.Controls)
                {
                    if (ctl.Name == "label1")
                    {
                        ctl.Text = "Please Wait searching for Equipment.";
                    }
                }
                Details.Load.Show();
                var xl = new Excel_book();
               // MessageBox.Show($"The barcode is: {barcodeBox.Text}");
                xl.CheckIn(Convert.ToInt32(barcodeBox.Text));
                Details.Load.Hide();
                this.Hide();
            }
        }
    }
}
