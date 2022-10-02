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
        // Laptop
        //private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nicol\OneDrive\Dokumente\ProNatur.mdf;Integrated Security=True;Connect Timeout=30");
        // Home Büro
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\nicol\Documents\ProNatur.mdf;Integrated Security = True; Connect Timeout = 30");

        public ProductScreen()
        {
            InitializeComponent();

            ShowProducts();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            // save product in database
            if (tbName.Text == ""
                || tbBrand.Text == ""
                || cbCategory.Text == ""
                || tbPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte aus!");
                return;
            }

            string productName = tbName.Text;
            string productBarnd = tbBrand.Text;
            string productCategory = cbCategory.Text;
            string productPrice = tbPrice.Text;

            databaseConnection.Open();
            string query = string.Format(
                "insert into Products values('{0}', '{1}', '{2}', '{3}')",
                productName, productBarnd, productCategory, productPrice);
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();

            CleaAllFields();
            ShowProducts();
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            
            
            ShowProducts();
        }

        private void btnFieldsClear_Click(object sender, EventArgs e)
        {
            CleaAllFields();
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {


            ShowProducts();
        }

        private void ShowProducts()
        {
            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];
            productsDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }

        private void CleaAllFields()
        {
            tbName.Text = "";
            tbBrand.Text = "";
            // cbCategory.Text = "";
            cbCategory.SelectedItem = null;
            tbPrice.Text = "";
        }
    }
}
