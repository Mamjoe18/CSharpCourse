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
    public partial class UpdateSupplierForm : Form
    {
        int id;
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        public UpdateSupplierForm()
        {
        }

        public UpdateSupplierForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public String getSupplier()
        {
            String values = "SELECT FirstName, Address, PhoneNumber, Email, SocialR, SiretNumber, RcsNumber FROM Supplier";
            return values;
        }

        private void UpdateSupplierForm_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                string queryString = getSupplier();

                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tName.Text = reader["FirstName"].ToString();
                    tAddress.Text = reader["Address"].ToString();
                    tNumber.Text = reader["PhoneNumber"].ToString();
                    tEmail.Text = reader["Email"].ToString();
                    tSocialR.Text = reader["SocialR"].ToString();
                    tSiretN.Text = reader["SiretNumber"].ToString();
                    tRcsNumber.Text = reader["RcsNumber"].ToString();
                }
            }
        }
        
        public String updateSupplier(int id)
        {
            String values = $"UPDATE Supplier SET FirstName='{tName.Text}', Address='{tAddress.Text}'," +
               $"PhoneNumber='{tNumber.Text}', Email='{tEmail.Text}', SocialR='{tSocialR.Text}', " +
               $"SiretNumber='{tSiretN.Text}', RcsNumber='{tRcsNumber.Text}' WHERE IdSupplier={id}";
            return values;
        }

        private void Update_Data(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                String queryString = updateSupplier(this.id);
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
