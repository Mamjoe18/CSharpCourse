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
    public partial class ListProdForm : Form
    {
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        public ListProdForm()
        {
            InitializeComponent();
        }

        private void ListProdForm_Load(object sender, EventArgs e)
        {

            string queryString = "select * from dbo.Product";

            var connection = new SqlConnection(cnx.ConnectionString);

            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                dGVProducts.Visible = true;
                DataTable dt = new DataTable();
                dt.Load(reader);

                dGVProducts.DataSource = dt;
            }



        }

        private void dGVProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
