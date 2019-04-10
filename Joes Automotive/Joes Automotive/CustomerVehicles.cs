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

        private void CustomerVehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.FillByCustomerID(this.joesBigBoyDatabaseDataSet.Vehicles, this.customerID);
        }

        private void toolStripBtnNewVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                VehicleCreate vehicleCreate = new VehicleCreate(customerID);
                vehicleCreate.ShowDialog();

                vehiclesTableAdapter.FillByCustomerID(this.joesBigBoyDatabaseDataSet.Vehicles, customerID);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem creating the vehicle. Please try again later.\n \n \n \n \n \n " +
                    "Error message: \n" +
                    ex.Message);
            }
        }

        private void ToolStripBtnEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleID = int.Parse(vehiclesDataGridView.CurrentRow.Cells[0].Value.ToString());

                VehicleEdit vehicleEdit = new VehicleEdit(vehicleID);
                vehicleEdit.ShowDialog();

                vehiclesTableAdapter.FillByCustomerID(this.joesBigBoyDatabaseDataSet.Vehicles, customerID);

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem editing the vehicle. Please try again later.\n \n \n \n \n \n " +
                    "Error message: \n" +
                    ex.Message);
            }
        }
    }
}
