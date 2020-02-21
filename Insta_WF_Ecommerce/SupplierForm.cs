using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta_WF_Ecommerce
{
    public partial class SupplierForm : Form
    {
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        public SupplierForm()
        {
            InitializeComponent();
        }

        public String insertSupplierData(String firstname, String address, String phone, String email, String SocialR, String SiretNumber, String RcsNumber)
        {
            String values = $"insert into Supplier(FirstName, Address, PhoneNumber, Email, SocialR, SiretNumber, RcsNumber)" +
                    $"VALUES('{firstname}', '{address}', '{phone}', '{email}', '{SocialR}','{SiretNumber}', '{RcsNumber}')"; 
            return values;
        }

        private void AddSupplier(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                string queryString = insertSupplierData(tName.Text, tAddress.Text, tNumber.Text, tEmail.Text, tSocialR.Text, tSiretN.Text, tRcsNumber.Text);

                var command = new SqlCommand(queryString, connection);
                connection.Open();
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Data Inserted !");
                connection.Close();
            }
        }
    }
}
