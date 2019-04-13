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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Invoices);

        }

        private void toolStripBtnNewInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }

        private void toolStripBtnEditInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }

        private void toolStripBtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented.");
        }
    }
}
