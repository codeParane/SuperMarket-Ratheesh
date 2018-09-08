using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SuperMarketMS
{
    public partial class StockManagement : Form
    {
        DbConn dbconn = new DbConn();

        public StockManagement()
        {
            InitializeComponent();
        }


        //stocks tap
        private void tpcStock_Enter(object sender, EventArgs e)
        {
            cmbStoksItemCat.Items.Clear();
            cmbStoksItemCat.Items.Add("ALL");
            cmbStoksItemCat.SelectedItem = "ALL";

            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qCmbCatFill = "SELECT DISTINCT category FROM items;";
            MySqlDataAdapter aCmbCatFill = new MySqlDataAdapter(qCmbCatFill, dbconn.connection);
            DataTable dt = new DataTable();
            aCmbCatFill.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbStoksItemCat.Items.Add(row[0].ToString());
            }
            
        }
        private void cmbItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStoksItemCat.Text == "ALL")
            {
                cmbStocksItem.Enabled = false;
                string qGetStocks = "SELECT "+
                    "s.barcode AS 'Bar Code', i.name AS 'Item Name', i.category AS "+
                    "'Item Category', s.qty AS 'Quantity ' "+
                    "FROM items AS i JOIN stocks AS s ON i.id = s.itemid; ";
                MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
                DataSet ds = new DataSet();
                aGetStocks.Fill(ds, "Stocks");
                dgvStocks.DataSource = ds.Tables["Stocks"];
            }
            else
            {
                cmbStocksItem.Enabled = true;
                cmbStocksItem.Items.Clear();
                cmbStocksItem.Items.Add("ALL");
                cmbStocksItem.SelectedItem = "ALL";
                string selectedCategory = cmbStoksItemCat.Text;
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qCmbItemFill = "SELECT name FROM items WHERE category = '" + selectedCategory + "';";
                MySqlDataAdapter aCmbItemFill = new MySqlDataAdapter(qCmbItemFill, dbconn.connection);
                DataTable dt = new DataTable();
                aCmbItemFill.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    cmbStocksItem.Items.Add(row[0].ToString());
                }

                string qGetStocks = "SELECT s.barcode, i.name, i.category, s.qty FROM items AS i JOIN stocks " +
               "AS s ON i.id = s.itemid WHERE i.category = '" + cmbStoksItemCat.Text + "'; ";
                MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
                DataSet ds = new DataSet();
                aGetStocks.Fill(ds, "Stocks2");
                dgvStocks.DataSource = ds.Tables["Stocks2"];

            }

        }
        private void cmbStocksItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(msCmbMgStocksItem.Text == "ALL")
            {
                MessageBox.Show("ok");
              //  string qGetStocks = "SELECT s.barcode, i.name, i.category, s.qty FROM items AS i JOIN stocks " +
              //"AS s ON i.id = s.itemid WHERE i.category = '" + cmbStoksItemCat.Text + "'; ";
              //  MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
              //  DataSet ds = new DataSet();
              //  aGetStocks.Fill(ds, "Stocks3");
              //  dgvStocks.DataSource = ds.Tables["Stocks3"];
            }
            else
            {
                string qGetStocks = "SELECT s.barcode, i.name, i.category, s.qty FROM items AS i JOIN stocks " +
                "AS s ON i.id = s.itemid WHERE i.category = '" + cmbStoksItemCat.Text + "' && i.name = '" +
                cmbStocksItem.Text + "'; ";
                MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
                DataSet ds = new DataSet();
                aGetStocks.Fill(ds, "Stocks");
                dgvStocks.DataSource = ds.Tables["Stocks"];
            }
            
        }





























        private void tpcStocks_Click(object sender, EventArgs e)
        {

        }

        private void tpcManageStock_Enter(object sender, EventArgs e)
        {
            msBarCode.Focus();


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

            if (msBarCode.Text != "" || msCmbMgStocksItemCat.Text != "" || msCmbMgStocksItem.Text != ""
                || msCompanyPrice.Text != "" || msSellingPrice.Text != "")
            {
                barcode = msBarCode.Text;
                itemCategory = msCmbMgStocksItemCat.Text;
                item = msCmbMgStocksItem.Text;
                companyPrice = Math.Round(decimal.Parse(msCompanyPrice.Text),2);
                sellingPrice = Math.Round(decimal.Parse(msSellingPrice.Text),2);
                discountP = int.Parse(msDiscount.Text);
                quantity = decimal.Parse(msQuantity.Text);
                expiryDate = msExpiryDate.Text;

                //MessageBox.Show("Not Completed Details!!!!");
            
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
                    MessageBox.Show("Stock Added!!!");
                    msClear_Click("",e);
                }
            }
        }

        private void msCompanyPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void msSellingPrice_TextChanged(object sender, EventArgs e)
        {
          
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
                MessageBox.Show("Items Added!!!");
                button2_Click("",e);
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

        private void tpcManageStock_Enter_1(object sender, EventArgs e)
        {
            //MessageBox.Show("ok");

            msCmbMgStocksItemCat.Items.Clear();
            msCmbMgStocksItemCat.Items.Add("-SELECT-");
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qcmbcatfill = "select distinct category from items;";
            MySqlDataAdapter acmbcatfill = new MySqlDataAdapter(qcmbcatfill, dbconn.connection);
            DataTable dt = new DataTable();
            acmbcatfill.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                msCmbMgStocksItemCat.Items.Add(row[0].ToString());
            }
            msCmbMgStocksItemCat.SelectedIndex = 0;
            
            
        }

        private void cmbMgStocksItemCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (msCmbMgStocksItemCat.Text == "-SELECT-")
            {
                msCmbMgStocksItem.Enabled = false;
            }
            else
            {
                msCmbMgStocksItem.Enabled = true;
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                msCmbMgStocksItem.Items.Clear();
                msCmbMgStocksItem.Items.Add("-SELECT-");
                msCmbMgStocksItem.SelectedIndex = 0;
                string selectedCat = msCmbMgStocksItemCat.Text;
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qCmbItemFill = "SELECT name FROM items WHERE category = '" + selectedCat + "';";
                MySqlDataAdapter aCmbItemFill = new MySqlDataAdapter(qCmbItemFill, dbconn.connection);
                DataTable dt = new DataTable();
                aCmbItemFill.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    msCmbMgStocksItem.Items.Add(row[0].ToString());
                }
            }
        }

        private void msClear_Click(object sender, EventArgs e)
        {
            msBarCode.Clear();
            msCmbMgStocksItem.Items.Add("-SELECT-");
            msCmbMgStocksItemCat.Items.Add("-SELECT-");
            msCmbMgStocksItem.SelectedIndex = 0;
            msCmbMgStocksItemCat.SelectedIndex = 0;
            msCompanyPrice.Text = "0.00";
            msSellingPrice.Text = "0.00";
            msDiscount.Text = "0";
            msQuantity.Value = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            iItemName.Items.Clear();
            iItemCategory.SelectedIndex = 0;
            iIsWeight.SelectedIndex = 1;
        }

        private void tpcManageStock_Click(object sender, EventArgs e)
        {

        }

        private void msBarCode_TextChanged(object sender, EventArgs e)
        {
            string itemCat = "";
            string item = "";
            string compPrice = "";
            string selPrice = "";
            string discount = "";
            string qty = "";
            string expDate = "";

            MySqlCommand cmd = new MySqlCommand("select i.name, i.category, s.companyPrice, s.sellingPrice, s.discount, s.qty," + 
                "s.expiry from items as i join stocks as s on i.id = s.itemid WHERE s.barcode = '"+ msBarCode.Text +"';", dbconn.connection);
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                   
                        item = reader.GetString(0);
                        itemCat = reader.GetString(1);
                        compPrice = reader.GetString(2);
                        selPrice = reader.GetString(3);
                        discount = reader.GetString(4);
                        qty = reader.GetString(5);
                        expDate = reader.GetString(6);
                    
                }
            }     
            reader.Close();
            if(item != "")
            {
                //msCmbMgStocksItemCat.Items.Add("-SELECT-");
                //msCmbMgStocksItem.Items.Add("-SELECT-");
                //msCmbMgStocksItemCat.SelectedIndex = 0;
                //msCmbMgStocksItem.SelectedIndex = 0;
                msCmbMgStocksItem.SelectedItem = item;
                msCmbMgStocksItemCat.SelectedItem = itemCat;
                msCompanyPrice.Text = compPrice;
                msSellingPrice.Text = selPrice;
                msDiscount.Text = discount;
                msQuantity.Value = int.Parse(qty);
                //int yr = int.Parse(expDate.Substring(0, 4)), mo = int.Parse(expDate.Substring(5, 2)), da = int.Parse(expDate.Substring(8, 2));
                //msExpiryDate.Value = new DateTime(yr, mo, da);
            }
        }

        private void msCompanyPrice_Enter(object sender, EventArgs e)
        {
            msCompanyPrice.Clear();
        }

        private void msSellingPrice_Enter(object sender, EventArgs e)
        {
            msSellingPrice.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qAddToBill = "delete from stocks where barcode = '"+ msBarCode.Text +"'";
            MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
            int queryAffected = cAddToBill.ExecuteNonQuery();
            if (queryAffected > 0)
            {
                MessageBox.Show("Items Deleted!!!");
                msClear_Click("", e);

            }
        }
    }
}
