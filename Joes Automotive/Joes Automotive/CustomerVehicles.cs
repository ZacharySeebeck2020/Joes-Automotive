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
    public partial class CustomerVehicles : Form
    {
        public int customerID;

        public CustomerVehicles(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void vehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void CustomerVehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.FillBy(this.joesBigBoyDatabaseDataSet.Vehicles, this.customerID);
        }

        private void toolStripBtnNewVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}
