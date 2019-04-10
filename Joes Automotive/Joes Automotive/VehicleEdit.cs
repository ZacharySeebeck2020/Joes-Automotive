using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive
{
    public partial class VehicleEdit : Form
    {
        int vehicleID;
        public VehicleEdit(int VehicleID)
        {
            vehicleID = VehicleID;
            InitializeComponent();
        }

        private void VehicleEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Vehicles' table. You can move, or remove it, as needed.
            //this.vehiclesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Vehicles);
            this.vehiclesTableAdapter.FillByVehicleID(this.joesBigBoyDatabaseDataSet.Vehicles, vehicleID);

        }

        private void ToolStripBtnSaveExit_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);
            this.Close();
        }
    }
}
