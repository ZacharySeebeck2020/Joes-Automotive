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

        public void Testing()
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from Customers where Id =@id", conn);
            command.Parameters.AddWithValue("@id", customerID);
        }

        /* Pulled from: https://stackoverflow.com/questions/25739788/select-query-to-get-data-from-sql-server
         * 
         * SqlConnection conn = new SqlConnection("Data Source=;Initial Catalog=;Persist Security Info=True;User ID=;Password=");
         *  conn.Open();
         *
         * SqlCommand command = new SqlCommand("Select id from [table1] where name=@zip", conn);
         *  command.Parameters.AddWithValue("@zip","india");
         *  // int result = command.ExecuteNonQuery();
         *  using (SqlDataReader reader = command.ExecuteReader())
         *  {
         *    if (reader.Read())
         *  {
         *       Console.WriteLine(String.Format("{0}",reader["id"]));
         *     }
         *  }
         *
         *  conn.Close();
         * 
         */


    }
}
