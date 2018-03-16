using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Panel
{
    public partial class Check_Out : Panel
    {
        public int card = 0;
        public int Barcode = 0;
        public Check_Out()
        {
            InitializeComponent();
            main();
        }

        public void main()
        {
             
            var Id = new RFID();
            card = Id.read();

            if (card != 0)
            {
                foreach (Employee e in Details.EmployeeList)
                {
                    if (e.idCard == card)
                    {
                        Details.Employee = e;
                        nameLabel.Text = e.Name;
                        teamLabel.Text = e.Team;
                    }
                }

                IDCardNum.Text = card.ToString();

                var barcode = new BarcodeScanner();
                Barcode = barcode.read();

                if (Barcode != 0)
                {
                    textBox1.Text = Barcode.ToString();
                    foreach (Equipment eq in Details.EquipmentList)
                    {
                        if (eq.Barcode == Barcode)
                        {
                            if (eq.Availability == "Available")
                            {
                                Details.Equipment = eq;
                                equipmentType.Text = eq.Type;
                                equipmentSerial.Text = eq.SerialNumber.ToString();
                            }
                            else if (eq.Availability == "In Use") 
                            {
                                MessageBox.Show($"The {eq.Type} with serial number {eq.SerialNumber} is already in use.");
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Barcode not read please try again.");
                }
            }

            if (card == 0)
            {
                MessageBox.Show("Card not read please try again.");
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("Barcode not read");
            }
            else if(Details.Equipment.Availability == "Available ")
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
                db.updateEquipmentStatus("In Use");
                Details.Equipment = null;
                Details.Load.Hide();
                this.Hide();
            }
            else if (Details.Equipment.Availability == null)
            {
                MessageBox.Show("Please scan an item not already assigned to a tester.");
            }
        }
        private void Return_Click(object sender, EventArgs e)
        {
            Details.Employee = null;
            Details.Equipment = null;
            this.Hide();
        }

        private void IDCardNum_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(IDCardNum.Text, out card))
            {
                card = int.Parse(IDCardNum.Text);
                if (card != 0)
                {
                    foreach (Employee em in Details.EmployeeList)
                    {
                        if (em.idCard == card)
                        {
                            Details.Employee = em;
                            nameLabel.Text = em.Name;
                            teamLabel.Text = em.Team;
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out Barcode))
            {
                if (Barcode != 0)
                {
                    textBox1.Text = Barcode.ToString();
                    foreach (Equipment eq in Details.EquipmentList)
                    {
                        if (eq.Barcode == Barcode)
                        {
                            equipmentType.Text = eq.Type;
                            equipmentSerial.Text = eq.SerialNumber.ToString();

                            if (eq.Availability == "Available ")
                            {
                                Details.Equipment = eq;
                            }
                            else if (eq.Availability == "In Use    ") 
                            {
                                MessageBox.Show($"The {eq.Type} with serial number {eq.SerialNumber} is already in use.");
                            }
                        }
                    }

                }
            }
        }
    }
}
