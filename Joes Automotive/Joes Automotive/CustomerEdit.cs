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

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void email_addressLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
