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
    public partial class DatabaseViewer : Form
    {
        public DatabaseViewer()
        {
            InitializeComponent();
        }

        private int? row;
        private void DatabaseViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.InUseEquipment' table. You can move, or remove it, as needed.
            this.inUseEquipmentTableAdapter.Fill(this.dataSet1.InUseEquipment);
            // TODO: This line of code loads data into the 'dataSet1.InUseEquipment' table. You can move, or remove it, as needed.
            this.inUseEquipmentTableAdapter.Fill(this.dataSet1.InUseEquipment);
            // TODO: This line of code loads data into the 'dataSet1.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.dataSet1.Equipment);
            // TODO: This line of code loads data into the 'dataSet11.Machines' table. You can move, or remove it, as needed.
            this.machinesTableAdapter.Fill(this.dataSet1.Machines);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);

        }
        

        private void Refresh_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Equipment' table. You can move, or remove it, as needed.
            this.equipmentTableAdapter.Fill(this.dataSet1.Equipment);
            // TODO: This line of code loads data into the 'dataSet11.Machines' table. You can move, or remove it, as needed.
            this.machinesTableAdapter.Fill(this.dataSet1.Machines);
            // TODO: This line of code loads data into the 'dataSet11.InUseEquipment' table. You can move, or remove it, as needed.
            this.inUseEquipmentTableAdapter.Fill(this.dataSet1.InUseEquipment);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);
        }

        private void InUseGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateNote.Visible = true;
            row = e.RowIndex;
        }

        private void updateNote_Click(object sender, EventArgs e)
        {
            inUseEquipmentTableAdapter.Update(dataSet1.Tables["inUseEquipment"].Rows[row.Value]);
            row = null;
        }
    }
}
