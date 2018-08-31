using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class SalesRegister : Form
    {
        DbConn dbconn = new DbConn();
        public SalesRegister()
        {
            InitializeComponent();
            
        }

        private void SalesRegister_Load(object sender, EventArgs e)
        {
            pboItemImage.Image = Image.FromFile(@"D:\Resources\ItemImage\default.png");
            //
            string qCurrentBill = "select * from currentbill;";
            MySqlDataAdapter aCurrentBill = new MySqlDataAdapter(qCurrentBill, dbconn.connection);
            DataSet ds = new DataSet();
            aCurrentBill.Fill(ds, "CurrentBill");
            dgvCurrentBill.DataSource = ds.Tables["CurrentBill"];
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
    
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            string barCode = "";
            string id = "";
            string name = "";
            decimal cmpPrice = 0;
            decimal selPrice = 0;
            decimal discountPercentage = 0;
            txtItemName.Clear(); txtSelling.Clear(); txtDisPercentage.Clear();
            txtDisPercentage.Clear(); txtDisAmount.Clear(); txtNetAmount.Clear();
            pboItemImage.Image = Image.FromFile(@"D:\Resources\ItemImage\default.png");

            if (txtItemCode.Text != "")
            {
                barCode = txtItemCode.Text;
            }
            else
            {
                txtItemCode.Clear();
                txtItemCode.Focus();
            }

            if (barCode != "")
            {
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qr_getProduct = "SELECT i.id AS id, i.name AS name, s.companyprice AS cmpprice,s.sellingprice as selprice, s.discount AS discount, s.qty FROM" +
                    " stocks AS s JOIN items AS i ON s.itemid = i.id WHERE s.barcode = " + barCode + ";";
                MySqlCommand cm_getProduct = new MySqlCommand(qr_getProduct, dbconn.connection);
                    MySqlDataReader dr_getProduct = cm_getProduct.ExecuteReader();

                if (dr_getProduct.HasRows == true)
                {
                    while (dr_getProduct.Read())
                    {
                        id = dr_getProduct["id"].ToString();
                        name = dr_getProduct["name"].ToString();
                        cmpPrice = decimal.Parse(dr_getProduct["cmpprice"].ToString());
                        selPrice = decimal.Parse(dr_getProduct["selprice"].ToString());
                        discountPercentage = decimal.Parse(dr_getProduct["discount"].ToString());
                    }
                    dbconn.CloseConnection();
                    txtItemName.Text = name;
                    txtSelling.Text = selPrice.ToString();
                    txtDisPercentage.Text = discountPercentage.ToString();
                    if (discountPercentage > 0)
                    {
                        discountPercentage = discountPercentage / 100;
                        decimal disAmount = Math.Round(decimal.Multiply(selPrice, discountPercentage), 2);
                        txtDisAmount.Text = disAmount.ToString();
                        txtNetAmount.Text = (selPrice - disAmount).ToString();
                    }
                    else
                    {
                        txtDisAmount.Text = "0";
                        txtNetAmount.Text = selPrice.ToString();
                    }
                    pboItemImage.Image = Image.FromFile(@"D:\Resources\ItemImage\" + id + ".jpg");
                }
            }
        }

     

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode  == Keys.Enter)
            {
                txtQty_Leave(sender, e);
            }

        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }

        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if(txtItemName.Text != "")
            {
                txtQty.Focus();
            }
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            if(txtQty.Text == null)
            {
                txtQty.Text = "0";
            }

            if (txtItemName.Text != "" && decimal.Parse(txtQty.Text) > 0 && txtItemCode.Text != "")
            {
                MessageBox.Show("as");
                string itemcode = txtItemCode.Text;
                string itemName = txtItemName.Text;
                decimal qty = Math.Round(decimal.Parse(txtQty.Text), 3);
                decimal rate = Math.Round(decimal.Parse(txtSelling.Text), 2);
                string discount = txtDisPercentage.Text; 
                decimal disAmount = decimal.Parse(txtDisAmount.Text);
                decimal netAmount = Math.Round(decimal.Parse(txtNetAmount.Text), 2);
                decimal netTotal = Math.Round((qty * netAmount),2);

                string qAddToBill = "INSERT INTO currentbill values('" + itemcode + "','" + itemName + "'," + qty +
                    "," + rate + "," + discount + ", " + disAmount + ", "  + netTotal + ");";
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
                int queryAffected = cAddToBill.ExecuteNonQuery();
            }
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qCurrentBill = "select * from currentbill;";
            MySqlDataAdapter aCurrentBill = new MySqlDataAdapter(qCurrentBill, dbconn.connection);
            DataSet ds = new DataSet();
            aCurrentBill.Fill(ds, "CurrentBill");
            dgvCurrentBill.DataSource = ds.Tables["CurrentBill"];
            txtItemCode.Clear();
            txtQty.Clear();
            txtItemCode.Focus();



        }

        private void SalesRegister_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("sss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fm = this;
            fm.Hide();
            MainForm mf = new MainForm();
            mf.Show();
            fm.Close();
        }
    }
}
