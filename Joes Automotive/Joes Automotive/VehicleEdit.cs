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
        int customerID;
        public VehicleEdit(int CustomerID)
        {
            customerID = CustomerID;
            InitializeComponent();
        }

        private void VehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void VehicleEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Vehicles);
            

        }
    }
}
