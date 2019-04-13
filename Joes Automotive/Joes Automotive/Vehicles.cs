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
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
        }

        private void vehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehiclesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Vehicles' table. You can move, or remove it, as needed.
            this.vehiclesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Vehicles);

        }

        private void toolStripBtnEditVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleID = int.Parse(vehiclesDataGridView.CurrentRow.Cells[0].Value.ToString());

                VehicleEdit vehicleEdit = new VehicleEdit(vehicleID);
                vehicleEdit.ShowDialog();
                vehiclesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Vehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem editing the vehicle. Please try again later.\n \n \n \n \n \n " +
                    "Error message: \n" +
                    ex.Message);
            }
        }

        private void toolStripBtnDeleteVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                int vehicleID = int.Parse(vehiclesDataGridView.CurrentRow.Cells[0].Value.ToString());

                if (MessageBox.Show("Warning. This is a destructive action that can not be undone. Are you sure you want to continue?", "Delete Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    vehiclesTableAdapter.DeleteVehicleByID(vehicleID);
                    vehiclesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Vehicles);
                }
                else
                {
                    vehiclesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Vehicles);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem has occured: \n\n\n\n\n\n\n\n" + ex.Message);
            }
        }

        private void selectMake_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectMake.Text != "")
            {
                txtModel.Enabled = true;
                btnSearch.Enabled = true;
            } else
            {
                txtModel.Enabled = false;
                btnSearch.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtModel.Text != "")
            {
                if (txtYear.Text != "")
                {
                    int year;
                    if (int.TryParse(txtYear.Text, out year)) {
                        vehiclesTableAdapter.FillSearchedMakeModelYear(this.joesBigBoyDatabaseDataSet.Vehicles, selectMake.Text, txtModel.Text, year.ToString());
                    } else
                    {
                        MessageBox.Show("Please make sure that the year is a solid, positive integer.");
                    }



                } else
                {
                    vehiclesTableAdapter.FillSearchedMakeModel(this.joesBigBoyDatabaseDataSet.Vehicles, selectMake.Text, txtModel.Text);
                }
            } else
            {
                vehiclesTableAdapter.FillSearchedMake(this.joesBigBoyDatabaseDataSet.Vehicles, selectMake.Text);
            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            if (txtModel.Text != "")
            {
                txtYear.Enabled = true;
            }
            else
            {
                txtYear.Enabled = false;
            }
        }
    }
}
