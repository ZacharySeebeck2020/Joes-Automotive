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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void PartsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Parts);
            // TODO: This line of code loads data into the 'joesBigBoyDatabaseDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Parts);

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.partsTableAdapter.FillBy(this.joesBigBoyDatabaseDataSet.Parts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void PartsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);

        }

        private void ToolStripBtnNewPart_Click(object sender, EventArgs e)
        {
            try
            {
                PartCreate partCreate = new PartCreate();
                this.Hide();
                partCreate.ShowDialog();
                this.Show();
                this.partsTableAdapter.FillBy(this.joesBigBoyDatabaseDataSet.Parts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem has occured: \n\n\n\n\n\n\n\n" + ex.Message);
            }
        }

        private void ToolStripBtnEditPart_Click(object sender, EventArgs e)
        {
            try
            {
                int partID = int.Parse(partsDataGridView.CurrentRow.Cells[0].Value.ToString());

                PartEdit partEdit = new PartEdit(partID);
                this.Hide();
                partEdit.ShowDialog();
                this.Show();
                partsTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Parts);


            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem has occured: \n\n\n\n\n\n\n\n" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            partsTableAdapter.FillSearchedPart(this.joesBigBoyDatabaseDataSet.Parts, txtSearchQuery.Text);
        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchQuery.Text == "")
            {
                partsTableAdapter.Fill(this.joesBigBoyDatabaseDataSet.Parts);
            } else
            {
                partsTableAdapter.FillSearchedPart(this.joesBigBoyDatabaseDataSet.Parts, txtSearchQuery.Text);
            }
        }
    }
}
