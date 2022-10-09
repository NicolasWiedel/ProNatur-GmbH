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
        private int lastSelectedProductKey;
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
            string productBrand = tbBrand.Text;
            string productCategory = cbCategory.Text;
            string productPrice = tbPrice.Text;

            
            string query = string.Format(
                "insert into Products values('{0}', '{1}', '{2}', '{3}')",
                productName, productBrand, productCategory, productPrice);
            ExecuteQuery(query);

            CleaAllFields();
            ShowProducts();
        }

        public void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle ein Produkt aus!");
                return;
            }

            string productName = tbName.Text;
            string productBrand = tbBrand.Text;
            string productCategory = cbCategory.Text;
            string productPrice = tbPrice.Text;
            string query = string.Format(
                "update Products set Name='{0}', Brand='{1}', Category='{2}', Price='{3}' where Id={4}",
                productName, productBrand, productCategory, productPrice, lastSelectedProductKey);
            ExecuteQuery(query);

            CleaAllFields();
            ShowProducts();
        }

        private void btnFieldsClear_Click(object sender, EventArgs e)
        {
            CleaAllFields();
        }

        private void btnProdDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle ein Produkt aus!");
                return;
            }

            string query = string.Format(
                "delete from Products where Id={0};", lastSelectedProductKey);
            ExecuteQuery(query);

            CleaAllFields();
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

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            tbBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            cbCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            tbPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
            
            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
