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
    public partial class MainForm : Form
    {
        //string cnx = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\romaa\OneDrive\Documents\Ecoles\INSTA\Cours\C#\Projects\Insta_WF_Ecommerce\App_data\eCommerce.mdf;Integrated Security=True";
        ConnectionStringSettings cnx = ConfigurationManager.ConnectionStrings["EcomProject"];
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            string queryString = "select * from dbo.Product";

            var connection = new SqlConnection(cnx.ConnectionString);

            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    dGVProduct.Visible = true;
            //    DataTable dt = new DataTable();
            //    dt.Load(reader);

            //    dGVProduct.DataSource = dt;
            //}


        }

       

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct fP = new FormProduct();
            fP.MdiParent = this;
            fP.WindowState = FormWindowState.Maximized;
            fP.Show();

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsumerForm cF = new ConsumerForm();
            //Imbriquer dans le container parent
            cF.MdiParent = this;
            cF.WindowState = FormWindowState.Maximized;
            cF.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupplierForm sF = new SupplierForm();
            sF.MdiParent = this;
            sF.WindowState = FormWindowState.Maximized;
            sF.Show();

        }


        private void listingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListProdForm lP = new ListProdForm();
            lP.MdiParent = this;
            lP.WindowState = FormWindowState.Maximized;
            lP.Show();
        }

        private void listingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListConsForm lC = new ListConsForm();
            lC.MdiParent = this;
            lC.WindowState = FormWindowState.Maximized;
            lC.Show();
        }


        private void listingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListSupForm lS = new ListSupForm();
            lS.MdiParent = this;
            lS.WindowState = FormWindowState.Maximized;
            lS.Show();
        }
    }
}
