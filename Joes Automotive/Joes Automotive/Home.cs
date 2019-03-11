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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form customers = new Customers();
            this.Hide();
            customers.ShowDialog();
            this.Show();
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This screen has not been implemented yet.");
        }   

        private void btnParts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This screen has not been implemented yet.");
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This screen has not been implemented yet.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
