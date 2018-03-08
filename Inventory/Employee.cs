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
        public string Name {get; set;}
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
            this.TextBox1 = new TextBox();
            this.label1 = new Label();

            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(TextBox1);
            this.Controls.Add(label1);
            this.Name = "Employees";
            this.Text = "Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee List:";

            //this.TextBox1.AutoSize = true;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(12, 30);
            this.TextBox1.Size = new System.Drawing.Size(400, 200);
            this.TextBox1.Name = "Employees";
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "Name                         | Team     | ID Card \r\n";
            this.TextBox1.ScrollBars = ScrollBars.Vertical;
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Multiline = true;

            foreach (Employee E in Details.EmployeeList)
            {
                this.TextBox1.Text += E.Name;
                for (int x = E.Name.Length; x < 23; x++)
                {
                    this.TextBox1.Text += "  ";
                }
                this.TextBox1.Text += ($"| {E.Team} ");
                for (int x = E.Team.Length; x < 10; x++)
                {
                    this.TextBox1.Text += " ";
                }
                this.TextBox1.Text += ($"| {E.idCard}");
                for (int x = E.idCard.ToString().Length; x < 8; x++)
                {
                    this.TextBox1.Text += " ";
                }
                this.TextBox1.Text += ($"\r\n");
            }
        }
        private TextBox TextBox1;
        private Label label1;
    }
}
