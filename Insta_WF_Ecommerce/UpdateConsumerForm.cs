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
    public partial class UpdateConsumerForm : Form
    {
        int id;
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        public UpdateConsumerForm()
        {
        }

        public UpdateConsumerForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public String getConsumerInfo(int id)
        {
            String values = $"SELECT Lastname, Firstname, DeliveryAddress, BillingAddress " +
                $"FROM Consumer Where idConsumer={id}";
            return values;
        }

        private void UpdateConsumerForm_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(this.id);
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                string queryString = getConsumerInfo(this.id);

                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader(); 

                if (reader.Read())
                {
                    uLastname.Text = reader["Lastname"].ToString();
                    uFirstname.Text = reader["Firstname"].ToString();
                    uDelivery.Text = reader["DeliveryAddress"].ToString();
                    uBillingAddress.Text = reader["BillingAddress"].ToString();
                    
                }
            }
        }

        public String updateInfoConsumer(int id)
        {
            String values = $"UPDATE Consumer SET Lastname='{uLastname.Text}', Firstname='{uFirstname.Text}'," +
                $"DeliveryAddress='{uDelivery.Text}', BillingAddress='{uBillingAddress.Text}' WHERE idConsumer={id}"; 
            return values;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                String queryString = updateInfoConsumer(this.id);
                connection.Open();
                var dCmd = new SqlCommand(queryString, connection);
                dCmd.CommandType = CommandType.Text;
                dCmd.ExecuteNonQuery();
                connection.Close();
                this.Close();
                
            }
        }
    }
}
