using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joes_Automotive
{
    public partial class Customer : Form
    {

        private int customerID;

        public Customer(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
            MessageBox.Show("Viewing Customer ID: " + customerID);
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
        
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
