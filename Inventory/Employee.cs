using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Panel
{

    class Employee
    {
        public int ID { get; set; }
        public string Name {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public double idCard {get; set;}
        public string Team { get; set;}
    }

    class EmployeeSearch
    {
        public Employee employee (double CardID)
        {
            foreach (Employee e in Details.EmployeeList)
            {
                if(e.idCard == CardID)
                {
                    return (e);
                }
            }
            return(Details.EmployeeList[0]);
        }
    }

    class Employees : Panel
    {
        public void InitializeComponent()
        {
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            label1 = new Label();
            panel1 = new FlowLayoutPanel();


            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(panel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextBox1);
            panel1.Controls.Add(TextBox2);
            panel1.Controls.Add(TextBox3);
            this.Name = "Employees";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.panel1.AutoSize = true;
            this.panel1.Dock = DockStyle.Fill;

            this.label1.AutoSize = true;
            this.label1.Dock = DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List:";

            this.TextBox1.AutoSize = true;
            //this.TextBox1.Dock = DockStyle.Fill;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(12, 30);
            //this.TextBox1.Size = new System.Drawing.Size(400, 200);
            this.TextBox1.Name = "Employees";
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "Name\r\n";
            this.TextBox1.ScrollBars = ScrollBars.Vertical;
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Multiline = true;

            this.TextBox2.AutoSize = true;
            //this.TextBox2.Dock = DockStyle.Fill;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(12, 30);
            //this.TextBox2.Size = new System.Drawing.Size(400, 200);
            this.TextBox2.Name = "Employees";
            this.TextBox2.TabIndex = 1;
            this.TextBox2.Text = "Team\r\n";
            this.TextBox2.ScrollBars = ScrollBars.Vertical;
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Multiline = true;

            this.TextBox3.AutoSize = true;
            //this.TextBox3.Dock = DockStyle.Fill;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(12, 30);
            //this.TextBox3.Size = new System.Drawing.Size(400, 200);
            this.TextBox3.Name = "Employees";
            this.TextBox3.TabIndex = 1;
            this.TextBox3.Text = "ID Card \r\n";
            this.TextBox3.ScrollBars = ScrollBars.Vertical;
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Multiline = true;

            foreach (Employee E in Details.EmployeeList)
            {
                this.TextBox1.Text += E.Name;
                for (int x = E.Name.Length; x < 23; x++)
                {
                    this.TextBox1.Text += "  ";
                }
                this.TextBox2.Text += ($"{E.Team} ");
                for (int x = E.Team.Length; x < 10; x++)
                {
                    this.TextBox2.Text += " ";
                }
                this.TextBox3.Text += ($"{E.idCard}");
                for (int x = E.idCard.ToString().Length; x < 8; x++)
                {
                    this.TextBox3.Text += " ";
                }
                this.TextBox1.Text += ($"\r\n");
                this.TextBox2.Text += ($"\r\n");
                this.TextBox3.Text += ($"\r\n");
            }
        }
        private TextBox TextBox1;
        private TextBox TextBox2;
        private TextBox TextBox3;
        private Label label1;
        private FlowLayoutPanel panel1;
    }
}
