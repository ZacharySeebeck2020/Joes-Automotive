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
    public partial class Customer : Form
    {
        int currentCustomerID;

        public Customer(int customerID)
        {
            InitializeComponent();
            currentCustomerID = customerID;
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            bindingNavigatorPositionItem.Focus();
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Customers);
            bindingNavigatorPositionItem.Text = currentCustomerID.ToString();
            customersBindingNavigator.Update();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);


        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }
    }
}
