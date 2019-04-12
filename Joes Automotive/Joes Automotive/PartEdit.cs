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
    public partial class PartEdit : Form
    {
        int partID;

        public PartEdit(int partID)
        {
            this.partID = partID;
            InitializeComponent();
        }

        private void PartEdit_Load(object sender, EventArgs e)
        {
            this.partsTableAdapter.FillByPartID(this.joesBigBoyDatabaseDataSet.Parts, partID);
        }

        private void ToolStripBtnSaveExit_Click(object sender, EventArgs e)
        {
            // Implement Part Saving here.
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.joesBigBoyDatabaseDataSet);
        }
    }
}
