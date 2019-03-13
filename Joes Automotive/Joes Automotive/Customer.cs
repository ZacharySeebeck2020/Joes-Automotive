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
            Testing();
        }

        public void Testing()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"JoesBigBoyDatabase.mdf\";Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from Customers where Id =@id", conn);
            command.Parameters.AddWithValue("@id", customerID);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show(String.Format("{0}", reader["id"]));
                }
            }
            
            conn.Close();
        }
    }
}
