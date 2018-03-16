namespace Inventory_Panel
{
    partial class Check_Out
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IDCardNum = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.equipmentType = new System.Windows.Forms.Label();
            this.equipmentSerial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please scan ID Tag";
            // 
            // IDCardNum
            // 
            this.IDCardNum.Location = new System.Drawing.Point(12, 34);
            this.IDCardNum.Name = "IDCardNum";
            this.IDCardNum.Size = new System.Drawing.Size(35, 20);
            this.IDCardNum.TabIndex = 1;
            this.IDCardNum.Text = "Id Card";
            this.IDCardNum.TextChanged += new System.EventHandler(this.IDCardNum_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(40, 213);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(120, 213);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 2;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please Scan Barcode.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 57);
            this.nameLabel.Name = "nameTextBox";
            this.nameLabel.Size = new System.Drawing.Size(84, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Employee Name";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(12, 84);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(83, 13);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "Employee Team";
            // 
            // equipmentType
            // 
            this.equipmentType.AutoSize = true;
            this.equipmentType.Location = new System.Drawing.Point(12, 155);
            this.equipmentType.Name = "equipmentType";
            this.equipmentType.Size = new System.Drawing.Size(83, 13);
            this.equipmentType.TabIndex = 6;
            this.equipmentType.Text = "equipmentType";
            // 
            // equipmentSerial
            // 
            this.equipmentSerial.AutoSize = true;
            this.equipmentSerial.Location = new System.Drawing.Point(12, 180);
            this.equipmentSerial.Name = "equipmentSerial";
            this.equipmentSerial.Size = new System.Drawing.Size(83, 13);
            this.equipmentSerial.TabIndex = 6;
            this.equipmentSerial.Text = "Equipment Serial Number";
            // 
            // Check_Out
            // 
            this.AutoSize = true;
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.IDCardNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipmentSerial);
            this.Controls.Add(this.equipmentType);
            this.Size = new System.Drawing.Size(284, 300);
            this.Text = "Check_Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDCardNum;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label equipmentType;
        private System.Windows.Forms.Label equipmentSerial;
    }
}