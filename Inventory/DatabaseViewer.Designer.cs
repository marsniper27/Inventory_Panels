namespace Inventory_Panel
{
    partial class DatabaseViewer
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EmployeeTab = new System.Windows.Forms.TabControl();
            this.EquipmentTab = new System.Windows.Forms.TabPage();
            this.EquipmentGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new Inventory_Panel.DataSet1();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentTableAdapter = new Inventory_Panel.DataSet1TableAdapters.EquipmentTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTSNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcaodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new Inventory_Panel.DataSet1TableAdapters.EmployeesTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InUseEquipmentTab = new System.Windows.Forms.TabPage();
            this.MachineTab = new System.Windows.Forms.TabPage();
            this.InUseGridView = new System.Windows.Forms.DataGridView();
            this.dataSet11 = new Inventory_Panel.DataSet1();
            this.inUseEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inUseEquipmentTableAdapter = new Inventory_Panel.DataSet1TableAdapters.InUseEquipmentTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTSNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machinesTableAdapter = new Inventory_Panel.DataSet1TableAdapters.MachinesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            this.EquipmentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.InUseEquipmentTab.SuspendLayout();
            this.MachineTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InUseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inUseEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.EmployeeTab, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // EmployeeTab
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.EmployeeTab, 2);
            this.EmployeeTab.Controls.Add(this.EquipmentTab);
            this.EmployeeTab.Controls.Add(this.tabPage2);
            this.EmployeeTab.Controls.Add(this.InUseEquipmentTab);
            this.EmployeeTab.Controls.Add(this.MachineTab);
            this.EmployeeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeTab.Location = new System.Drawing.Point(3, 3);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.SelectedIndex = 0;
            this.EmployeeTab.Size = new System.Drawing.Size(278, 228);
            this.EmployeeTab.TabIndex = 0;
            // 
            // EquipmentTab
            // 
            this.EquipmentTab.Controls.Add(this.EquipmentGridView1);
            this.EquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.EquipmentTab.Name = "EquipmentTab";
            this.EquipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.EquipmentTab.Size = new System.Drawing.Size(270, 202);
            this.EquipmentTab.TabIndex = 0;
            this.EquipmentTab.Text = "Equipment";
            this.EquipmentTab.UseVisualStyleBackColor = true;
            // 
            // EquipmentGridView1
            // 
            this.EquipmentGridView1.AutoGenerateColumns = false;
            this.EquipmentGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipmentGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.iTSNumberDataGridViewTextBoxColumn,
            this.barcaodeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.EquipmentGridView1.DataSource = this.equipmentBindingSource;
            this.EquipmentGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipmentGridView1.Location = new System.Drawing.Point(3, 3);
            this.EquipmentGridView1.Name = "EquipmentGridView1";
            this.EquipmentGridView1.Size = new System.Drawing.Size(264, 196);
            this.EquipmentGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(270, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.iDCardDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.dataSet1;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "Serial Number";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "Serial Number";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            // 
            // iTSNumberDataGridViewTextBoxColumn
            // 
            this.iTSNumberDataGridViewTextBoxColumn.DataPropertyName = "ITS Number";
            this.iTSNumberDataGridViewTextBoxColumn.HeaderText = "ITS Number";
            this.iTSNumberDataGridViewTextBoxColumn.Name = "iTSNumberDataGridViewTextBoxColumn";
            // 
            // barcaodeDataGridViewTextBoxColumn
            // 
            this.barcaodeDataGridViewTextBoxColumn.DataPropertyName = "Barcaode";
            this.barcaodeDataGridViewTextBoxColumn.HeaderText = "Barcaode";
            this.barcaodeDataGridViewTextBoxColumn.Name = "barcaodeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dataSet1;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "Team";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // iDCardDataGridViewTextBoxColumn
            // 
            this.iDCardDataGridViewTextBoxColumn.DataPropertyName = "ID Card";
            this.iDCardDataGridViewTextBoxColumn.HeaderText = "ID Card";
            this.iDCardDataGridViewTextBoxColumn.Name = "iDCardDataGridViewTextBoxColumn";
            // 
            // InUseEquipmentTab
            // 
            this.InUseEquipmentTab.Controls.Add(this.InUseGridView);
            this.InUseEquipmentTab.Location = new System.Drawing.Point(4, 22);
            this.InUseEquipmentTab.Name = "InUseEquipmentTab";
            this.InUseEquipmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.InUseEquipmentTab.Size = new System.Drawing.Size(270, 202);
            this.InUseEquipmentTab.TabIndex = 2;
            this.InUseEquipmentTab.Text = "In Use Equipment";
            this.InUseEquipmentTab.UseVisualStyleBackColor = true;
            // 
            // MachineTab
            // 
            this.MachineTab.Controls.Add(this.MachineGridView);
            this.MachineTab.Location = new System.Drawing.Point(4, 22);
            this.MachineTab.Name = "MachineTab";
            this.MachineTab.Padding = new System.Windows.Forms.Padding(3);
            this.MachineTab.Size = new System.Drawing.Size(270, 202);
            this.MachineTab.TabIndex = 3;
            this.MachineTab.Text = "Machines";
            this.MachineTab.UseVisualStyleBackColor = true;
            // 
            // InUseGridView
            // 
            this.InUseGridView.AutoGenerateColumns = false;
            this.InUseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InUseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.employeeDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn1});
            this.InUseGridView.DataSource = this.inUseEquipmentBindingSource;
            this.InUseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InUseGridView.Location = new System.Drawing.Point(3, 3);
            this.InUseGridView.Name = "InUseGridView";
            this.InUseGridView.Size = new System.Drawing.Size(264, 196);
            this.InUseGridView.TabIndex = 0;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inUseEquipmentBindingSource
            // 
            this.inUseEquipmentBindingSource.DataMember = "InUseEquipment";
            this.inUseEquipmentBindingSource.DataSource = this.dataSet11;
            // 
            // inUseEquipmentTableAdapter
            // 
            this.inUseEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            // 
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "Date Out";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "Date Out";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "Date In";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "Date In";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // MachineGridView
            // 
            this.MachineGridView.AutoGenerateColumns = false;
            this.MachineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MachineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.typeDataGridViewTextBoxColumn1,
            this.serialNumberDataGridViewTextBoxColumn1,
            this.iTSNumberDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn2});
            this.MachineGridView.DataSource = this.machinesBindingSource;
            this.MachineGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineGridView.Location = new System.Drawing.Point(3, 3);
            this.MachineGridView.Name = "MachineGridView";
            this.MachineGridView.Size = new System.Drawing.Size(264, 196);
            this.MachineGridView.TabIndex = 0;
            this.MachineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EquipmentGridView_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // serialNumberDataGridViewTextBoxColumn1
            // 
            this.serialNumberDataGridViewTextBoxColumn1.DataPropertyName = "Serial Number";
            this.serialNumberDataGridViewTextBoxColumn1.HeaderText = "Serial Number";
            this.serialNumberDataGridViewTextBoxColumn1.Name = "serialNumberDataGridViewTextBoxColumn1";
            // 
            // iTSNumberDataGridViewTextBoxColumn1
            // 
            this.iTSNumberDataGridViewTextBoxColumn1.DataPropertyName = "ITS Number";
            this.iTSNumberDataGridViewTextBoxColumn1.HeaderText = "ITS Number";
            this.iTSNumberDataGridViewTextBoxColumn1.Name = "iTSNumberDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.dataSet11;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // DatabaseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DatabaseViewer";
            this.Text = "Database Viewer";
            this.Load += new System.EventHandler(this.DatabaseViewer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.EquipmentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.InUseEquipmentTab.ResumeLayout(false);
            this.MachineTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InUseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inUseEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MachineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl EmployeeTab;
        private System.Windows.Forms.TabPage EquipmentTab;
        private System.Windows.Forms.DataGridView EquipmentGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private DataSet1TableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTSNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcaodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage InUseEquipmentTab;
        private System.Windows.Forms.DataGridView InUseGridView;
        private System.Windows.Forms.TabPage MachineTab;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource inUseEquipmentBindingSource;
        private DataSet1TableAdapters.InUseEquipmentTableAdapter inUseEquipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView MachineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTSNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private DataSet1TableAdapters.MachinesTableAdapter machinesTableAdapter;
    }
}