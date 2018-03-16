﻿namespace Inventory_Panel
{
    partial class CheckIn
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
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.equipmentType = new System.Windows.Forms.Label();
            this.equipmentSerial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please scan barcode";
            // 
            // barcodeBox
            // 
            this.barcodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeBox.Location = new System.Drawing.Point(13, 33);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(100, 26);
            this.barcodeBox.TabIndex = 1;
            this.barcodeBox.Text = "Barcode Number";
            this.barcodeBox.TextChanged += new System.EventHandler(this.barcodeBox_TextChanged);
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
            // CheckIn
            // 
            AutoSize = true;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.barcodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipmentSerial);
            this.Controls.Add(this.equipmentType);
            this.Size = new System.Drawing.Size(284, 300);
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label equipmentType;
        private System.Windows.Forms.Label equipmentSerial;
    }
}