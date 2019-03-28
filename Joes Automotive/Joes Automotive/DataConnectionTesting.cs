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
    public partial class DataConnectionTesting : Form
    {
        int currentCustomerID;

        public DataConnectionTesting(int customerID)
        {
            InitializeComponent();
            currentCustomerID = customerID;
        }


        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True"))
            {
                connection.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Customers WHERE ID=@ID", connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = txtLookupId.Text;
                    SqlDataReader re = cmd.ExecuteReader();

                    if (re.Read())
                    {
                        txtOutputID.Text = re["id"].ToString();
                        txtOutputName.Text = re["name"].ToString();
                        txtOutputAddress.Text = re["address"].ToString();
                        txtOutputPhoneNum.Text = re["phone_number"].ToString();
                        txtOutputEmail.Text = re["email_address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid customer id");
                    }
                }
            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=JoesBigBoyDatabase.mdf;Integrated Security=True"))
            {
                connection.Open();
                // command.CommandText = "UPDATE Student SET Address = @add, City = @cit Where FirstName = @fn and LastName = @add";
                using (SqlCommand command = new SqlCommand("UPDATE dbo.Customers SET name = @name, address = @address, phone_number = @phone_number, email_address = @email_address WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@Id", txtOutputID.Text);
                    command.Parameters.AddWithValue("@name", txtOutputName.Text);
                    command.Parameters.AddWithValue("@address", txtOutputAddress.Text);
                    command.Parameters.AddWithValue("@phone_number", txtOutputPhoneNum.Text);
                    command.Parameters.AddWithValue("@email_address", txtOutputEmail.Text);

                    MessageBox.Show(command.ExecuteNonQuery().ToString());
                }
            }

            this.Close();
        }
    }
}
