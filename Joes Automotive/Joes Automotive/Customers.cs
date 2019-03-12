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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(customersDataGridView.CurrentRow.Cells[0].Value.ToString());

                Customer customerForm = new Customer(customerID);
                customerForm.ShowDialog();
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
    }
}
