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

        public int Barcode = 0;
        public CheckIn()
        {
            InitializeComponent();
            main();
        }

        public void main()
        {
            var barcode = new BarcodeScanner();
            Barcode = barcode.read();
            barcodeBox.Text = Barcode.ToString();

            if (Barcode != 0)
            {
                barcodeBox.Text = Barcode.ToString();
                foreach (Equipment eq in Details.EquipmentList)
                {
                    if (eq.Barcode == Barcode)
                    {
                        if (eq.Availability == "In Use    ")
                        {
                            Details.Equipment = eq;
                            equipmentType.Text = eq.Type;
                            equipmentSerial.Text = eq.SerialNumber.ToString();
                        }
                        else if (eq.Availability == "Available ")
                        {
                            MessageBox.Show($"The {eq.Type} with serial number {eq.SerialNumber} is not assigned to a tester.");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Barcode not read please try again.");
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (barcodeBox.Text == null)
            {
                MessageBox.Show("Barcode not read");
            }
            else if (Details.Equipment.Availability == "In Use    ")
            {
                foreach (Control ctl in Details.Load.Controls)
                {
                    if (ctl.Name == "label1")
                    {
                        ctl.Text = "Please Wait searching for Equipment.";
                    }
                }
                Details.Load.Show();
                Database db = new Database();
                db.updateEquipmentStatus("Available");
                Details.Load.Hide();
                this.Hide();
            }
            else if (Details.Equipment.Availability == "Avaialble")
            {
                MessageBox.Show("Please scan an item assigned to a tester.");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void barcodeBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(barcodeBox.Text, out Barcode))
            {
                if (Barcode != 0)
                {
                    barcodeBox.Text = Barcode.ToString();
                    foreach (Equipment eq in Details.EquipmentList)
                    {
                        if (eq.Barcode == Barcode)
                        {

                            equipmentType.Text = eq.Type;
                            equipmentSerial.Text = eq.SerialNumber.ToString();
                            if (eq.Availability == "In Use    ")
                            {
                                Details.Equipment = eq;
                            }
                            else if (eq.Availability == "Available ")
                            {
                                MessageBox.Show($"The {eq.Type} with serial number {eq.SerialNumber} is not checked out.");
                            }
                        }
                    }

                }
            }
        }
    }
}
