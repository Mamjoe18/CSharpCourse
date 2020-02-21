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
    public partial class ListSupForm : Form
    {
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];

        public ListSupForm()
        {
            InitializeComponent();
        }

        public String getSupplierData()
        {
            String values = $"SELECT * FROM Supplier";
            return values;
        }


        private void ListSupForm_Load(object sender, EventArgs e)
        {
            string queryString = getSupplierData();

            var connection = new SqlConnection(cnx.ConnectionString);

            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                dGVSupplier.Visible = true;
                DataTable dt = new DataTable();
                dt.Load(reader);

                dGVSupplier.DataSource = dt;
            }

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String idSupplier = dGVSupplier.CurrentRow.Cells[0].Value.ToString();
            int id = int.Parse(idSupplier);
            UpdateSupplierForm uSF = new UpdateSupplierForm(id);
            uSF.Show();
        }

        public String deleteSupplier(int id)
        {
            String values = $"DELETE FROM Supplier WHERE IdSupplier = {id}";
            return values;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String idSupplier = dGVSupplier.CurrentRow.Cells[0].Value.ToString();
            int id = int.Parse(idSupplier);
            using (SqlConnection connection = new SqlConnection(cnx.ConnectionString))
            {
                String queryString = deleteSupplier(id);
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Supplier Deleted !");
                ListSupForm_Load(sender, e);
                dGVSupplier.Update();
                dGVSupplier.Refresh();
                connection.Close();
            }
        }
    }
}
