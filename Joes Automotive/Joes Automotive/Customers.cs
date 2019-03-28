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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Customers);
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Customers);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(customersDataGridView.CurrentRow.Cells[0].Value.ToString());

                MessageBox.Show("Open editing window with information of ID: " + customerID.ToString());

                // Ignore these. They are just for testing purposes and are left here for quick use.
                // DataConnectionTesting customerForm = new DataConnectionTesting(customerID);
                // customerForm.ShowDialog();

                customersTableAdapter.Update(this.joesBigBoyDatabaseDataSet.Customers);
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem editing the customer. Please try again later.\n \n \n \n \n \n " +
                    "Error message: \n" +
                    ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {

        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customersTableAdapter.FillSearchedCustomers(this.joesBigBoyDatabaseDataSet.Customers, txtSearchQuery.Text);
        }

        private void txtSearchQuery_Key(object sender, KeyEventArgs e)
        {
            if (txtSearchQuery.Text == "")
            {
                customersTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Customers);
            }
            else
            {
                customersTableAdapter.FillSearchedCustomers(this.joesBigBoyDatabaseDataSet.Customers, txtSearchQuery.Text);
            }
        }
    }
}
