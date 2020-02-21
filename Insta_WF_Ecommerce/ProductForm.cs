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
    public partial class FormProduct : Form
    {
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        public FormProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\romaa\OneDrive\Documents\Ecoles\INSTA\Cours\C#\Projects\Insta_WF_Ecommerce\App_data\eCommerce.mdf;Integrated Security=True";
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {

                int idSupplier = int.Parse(cBSupplier.SelectedValue.ToString());

                string queryString = $"insert into Product(SupplierName, Brand, Reference, DrawingType, Season, UAPrice, UvPrice, Quantity, idSupplier)" +
                    $"VALUES('{cBSupplier.Text}', '{cBBrand.Text}', '{txTReference.Text}', '{cBDrawingType.Text}','{cBSeason.Text}', '{txTUAPrice.Text}', '{txTUVPrice.Text}','{txTQuantity.Text}', {idSupplier})";

                connection.Open();
                var dCmd = new SqlCommand(queryString, connection);
                dCmd.CommandType = CommandType.Text;
                dCmd.ExecuteNonQuery();
                // string ab = dCmd.ExecuteNonQuery().ToString();
                //MessageBox.Show(ab);
                connection.Close();
            }

        }

        private void cBSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                string queryString = "SELECT IdSupplier, FirstName FROM Supplier";

                var dCmd = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = dCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cBSupplier.DataSource = dt;
                    cBSupplier.ValueMember = "IdSupplier";
                    cBSupplier.DisplayMember = "FirstName";


                }

            }
        }

        private void cBBrand_MouseClick(object sender, MouseEventArgs e)
        {
            using (var connection = new SqlConnection(cnx.ConnectionString))
            {
                string queryString = "SELECT IdBrand, Name FROM Brand";

                var dCmd = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = dCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cBSupplier.DataSource = dt;
                    cBSupplier.ValueMember = "IdBrand";
                    cBSupplier.DisplayMember = "Name";


                }

            }
        }
    }
}
