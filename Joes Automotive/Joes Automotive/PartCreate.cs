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
    public partial class PartCreate : Form
    {
        public PartCreate()
        {
            InitializeComponent();
        }

        private void ToolStripBtnCreate_Click(object sender, EventArgs e)
        {
            partsTableAdapter.InsertNewPart(int.Parse(idTextBox.Text), nameTextBox.Text, Decimal.Parse(costTextBox.Text), number_in_stockTextBox.Text, number_on_orderTextBox.Text, part_forTextBox.Text);
            this.Close();
        }
    }
}
