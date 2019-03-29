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
    public partial class CustomerCreate : Form
    {
        public CustomerCreate()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);
        }

        private void CustomerCreate_Load(object sender, EventArgs e)
        {

        }

        private void toolStripBtnCreateExit_Click(object sender, EventArgs e)
        {
            customersTableAdapter.InsertNewCustomer(nameTextBox.Text, addressTextBox.Text, phone_numberTextBox.Text, email_addressTextBox.Text, notesTextBox.Text);
            this.Close();
        }
    }
}
