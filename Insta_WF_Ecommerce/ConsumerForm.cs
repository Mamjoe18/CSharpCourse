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
    public partial class ConsumerForm : Form
    {
        public ConsumerForm()
        {
            InitializeComponent();
        }

        public String insertConsumer(String lastName, String firstName, String deliveryAdr, String billingAdr)
        {
            String values = $"insert into Consumer(Lastname, Firstname, DeliveryAddress, BillingAddress)" +
                    $"VALUES('{lastName}', '{firstName}', '{deliveryAdr}', '{billingAdr}')";
            return values;
        }

        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        private void button1_Click(object sender, EventArgs e)
        {
            //var cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\romaa\OneDrive\Documents\Ecoles\INSTA\Cours\C#\Projects\Insta_WF_Ecommerce\App_data\eCommerce.mdf;Integrated Security=True";
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                string queryString = insertConsumer(txtLastName.Text, txtFirstName.Text, txtDeliAddress.Text, txtBilling.Text);

                connection.Open();
                var dCmd = new SqlCommand(queryString, connection);
                dCmd.CommandType = CommandType.Text;
                dCmd.ExecuteNonQuery();
                this.Close();
                MessageBox.Show("Insert OK");
               // string ab = dCmd.ExecuteNonQuery().ToString();
                //MessageBox.Show(ab);
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Ce champ doit contenir des lettres");
            }

            /*
             if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))){
                e.Handled = true;
                MessageBox.Show("Ce champ doit contenir des chiffres");
            }
             */


        }
    }
}
