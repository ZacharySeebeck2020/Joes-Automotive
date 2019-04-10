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
    public partial class VehicleCreate : Form
    {
        int ownerID;
        public VehicleCreate(int OwnerID)
        {
            ownerID = OwnerID;
            InitializeComponent();
        }

        private void ToolStripBtnSaveExit_Click(object sender, EventArgs e)
        {
            // customersTableAdapter.InsertNewCustomer(nameTextBox.Text, addressTextBox.Text, phone_numberTextBox.Text, email_addressTextBox.Text, notesTextBox.Text);

            vehiclesTableAdapter.InsertNewVehicle(makeTextBox.Text, modelTextBox.Text, int.Parse(yearTextBox.Text), int.Parse(mileageTextBox.Text), date_receivedDateTimePicker.Text, date_returnedDateTimePicker.Text, ownerID, notesTextBox.Text);
            this.Close();
        }
    }
}
