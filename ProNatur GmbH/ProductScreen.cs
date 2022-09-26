using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProNatur_GmbH
{
    public partial class ProductScreen : Form
    {
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nicol\OneDrive\Dokumente\ProNatur.mdf;Integrated Security=True;Connect Timeout=30");

        public ProductScreen()
        {
            InitializeComponent();

            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];

            databaseConnection.Close();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {

        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnFieldsClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
