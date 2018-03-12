using System;
using System.Windows.Forms;

namespace Inventory_Panel
{
    public partial class Check_Out : Panel
    {
        public Check_Out()
        {
            InitializeComponent();
            main();
        }

        public void main()
        {
            var Id = new RFID();
            var card = Id.read();

            if (card != 0)
            {
                foreach(Employee e in Details.EmployeeList)
                {
                    if(e.idCard == card)
                    {
                        Details.Employee = e;
                        label4.Text = e.Name;
                        label5.Text = e.Team.Name;
                    }
                }

                label2.Text = card.ToString();
                var barcode = new BarcodeScanner();
                var Barcode = barcode.read();

                if (Barcode != 0)
                {
                    textBox1.Text = Barcode.ToString();
                    var xl = new Excel_book();

                }
                else
                {
                    MessageBox.Show("Barcode not read please try again.");
                }
            }

            if(card == 0)
            {
                MessageBox.Show("Card not read please try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
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
                //MessageBox.Show($"The barcode is: {textBox1.Text}");
                xl.CheckOut(Convert.ToInt32(textBox1.Text));
                Details.Load.Hide();
                this.Hide();
            }
        }
    }
}
