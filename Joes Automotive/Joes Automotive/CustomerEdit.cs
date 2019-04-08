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
    public partial class CustomerEdit : Form
    {
        int customerID;

        public CustomerEdit(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.FillCustomerByID(this.joesBigBoyDatabaseDataSet.Customers, customerID);

        }

        private void toolStripBtnSaveExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured. \n\n\n\n\n\n\n" + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void toolStripBtnViewVehicles_Click(object sender, EventArgs e)
        {
            // Open a form with customer vehicles and the ability to create a new vehicle.
            CustomerVehicles cv = new CustomerVehicles(customerID);
            cv.Show();
        }

        private void toolStripBtnViewInvoices_Click(object sender, EventArgs e)
        {
            // Open a form with customer invoces sorted into 2 tables. 1 for those invoices that have been completed, and one for those that have not.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open dialouge to upload an image. Then change it into the correct format to be stored in a database.
        }
    }
}
