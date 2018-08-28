using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SuperMarketMS
{
    public partial class StockManagement : Form
    {
        private object query131;
        DbConn dbconn = new DbConn();

        public StockManagement()
        {
            InitializeComponent();
        }

        private void tpcStocks_Click(object sender, EventArgs e)
        {

        }

        private void tpcManageStock_Enter(object sender, EventArgs e)
        {
            msBarCode.Focus();


        }

        private void tpcStock_Enter(object sender, EventArgs e)
        {
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qCmbItemCategoryFill = "SELECT DISTINCT category FROM items;";
            MySqlDataAdapter aCmbItemCategoryFill = new MySqlDataAdapter(qCmbItemCategoryFill, dbconn.connection);
            DataSet ds1 = new DataSet();
            aCmbItemCategoryFill.Fill(ds1, "cmbCategories");

            msItemCategory.DataSource = ds1.Tables["cmbCategories"].DefaultView;
            msItemCategory.DisplayMember = "category";
            msItemCategory.BindingContext = this.BindingContext;

            cmbItemCategory.DataSource = ds1.Tables["cmbCategories"].DefaultView;
            cmbItemCategory.DisplayMember = "category";
            cmbItemCategory.BindingContext = this.BindingContext;


            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qCmbItemFill = "SELECT DISTINCT name FROM items;";
            MySqlDataAdapter aCmbItemFill = new MySqlDataAdapter(qCmbItemFill, dbconn.connection);
            DataSet dsCmbItemFill = new DataSet();
            aCmbItemFill.Fill(dsCmbItemFill, "CmbItem");

            msItem.DataSource = dsCmbItemFill.Tables["CmbItem"].DefaultView;
            msItem.DisplayMember = "name";
            msItem.BindingContext = this.BindingContext;


            cmbItem.DataSource = ds1.Tables["cmbCategories"].DefaultView;
            cmbItem.DisplayMember = "category";
            cmbItem.BindingContext = this.BindingContext;






            dbconn.CloseConnection();
            dbconn.OpenConnection();
            try
            {
                string qGetStocks = "select * from users;";
                MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
                //MySqlDataReader rGetStocks = new MySqlDataReader();
                DataSet ds = new DataSet();
                aGetStocks.Fill(ds, "Stocks");
                dgvStocks.DataSource = ds.Tables["Stocks"];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void tpcStock_Click(object sender, EventArgs e)
        {

        }

        private void txtStocks_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (msDiscount.Text == "")
            {
                msDiscount.Text = "0";
            }
            if (int.Parse(msDiscount.Text) >= 100 || int.Parse(msDiscount.Text) < 0)
            {
                MessageBox.Show("Wrong Discount Percentage!!!");
                msDiscount.Text = "0";
            }
        }

        private void tpcProducts_Click(object sender, EventArgs e)
        {

        }

        private void msAddToStock_Click(object sender, EventArgs e)
        {
            string barcode = "", itemCategory = "", item = "", expiryDate="";
            decimal companyPrice = 0, sellingPrice = 0, quantity = 0;
            int discountP = 0;

            if (msBarCode.Text != "" || msItemCategory.Text != "" || msItem.Text != ""
                || msCompanyPrice.Text != "" || msSellingPrice.Text != "")
            {
                barcode = msBarCode.Text;
                itemCategory = msItemCategory.Text;
                item = msItem.Text;
                companyPrice = Math.Round(decimal.Parse(msCompanyPrice.Text),2);
                sellingPrice = Math.Round(decimal.Parse(msSellingPrice.Text),2);
                discountP = int.Parse(msDiscount.Text);
                quantity = decimal.Parse(msQuantity.Text);
                expiryDate = msExpiryDate.Text;

                MessageBox.Show("Not Completed Details!!!!");
            
                string itemId="";
                MySqlCommand cmd = new MySqlCommand("SELECT id FROM items WHERE name='"+ item +"'", dbconn.connection);
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    itemId = reader.GetString(0);
                }
                reader.Close();
                string qAddToBill = "INSERT INTO stocks VALUES (" + barcode + "," + itemId +
               ", " + companyPrice + ", " + sellingPrice + ", " + discountP + ", " + quantity + ", '" + 
               expiryDate + "');";
                MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
                int queryAffected = cAddToBill.ExecuteNonQuery();
                if (queryAffected > 0)
                {
                    MessageBox.Show("ok");
                }
            }
        }

        private void msCompanyPrice_TextChanged(object sender, EventArgs e)
        {
            if(msCompanyPrice.Text == "")
            {
                msCompanyPrice.Text = "0.00";
            }
        }

        private void msSellingPrice_TextChanged(object sender, EventArgs e)
        {
            if(msSellingPrice.Text == "")
            {
                msSellingPrice.Text = "0.00";
            }
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            msBarCode.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = iItemName.Text;
            string itemCat = iItemCategory.Text;
            string isWeight = iIsWeight.Text;

            string qAddToBill = "INSERT INTO items(name, category, weight) VALUES ('" + itemName + "','" + itemCat + 
                "', " + isWeight + ");";
            MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
            int queryAffected = cAddToBill.ExecuteNonQuery();
            if(queryAffected > 0 )
            {
                MessageBox.Show("ok");
            }
        }

        private void tpcProducts_Enter(object sender, EventArgs e)
        {
            //Add Items form load event
            iIsWeight.SelectedIndex = 1;
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qCmbItemCategoryFill = "SELECT DISTINCT category FROM items;";
            MySqlDataAdapter aCmbItemCategoryFill = new MySqlDataAdapter(qCmbItemCategoryFill, dbconn.connection);
            DataSet ds1 = new DataSet();
            aCmbItemCategoryFill.Fill(ds1, "cmbCategories");

            iItemCategory.DataSource = ds1.Tables["cmbCategories"].DefaultView;
            iItemCategory.DisplayMember = "category";
            iItemCategory.BindingContext = this.BindingContext;
           
        }
    }
}
