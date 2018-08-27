using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
    
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {
            string barCode = "";
            string id = "";
            string name = "";
            decimal gross = 0;
            decimal discountPercentage = 0;
            bool addToBill = false;
            txtItemName.Clear(); txtGross.Clear(); txtDisPercentage.Clear();
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
                dbconn.OpenConnection();
                string qr_getProduct = "SELECT i.id AS id, i.name AS name, s.gross AS gross, s.discount AS discount, s.qty FROM" +
                    " stocks AS s JOIN items AS i ON s.itemid = i.id WHERE s.barcode = " + barCode + ";";
                MySqlCommand cm_getProduct = new MySqlCommand(qr_getProduct, dbconn.connection);
                MySqlDataReader dr_getProduct = cm_getProduct.ExecuteReader();

                if (dr_getProduct.HasRows == true)
                {
                    while (dr_getProduct.Read())
                    {
                        id = dr_getProduct["id"].ToString();
                        name = dr_getProduct["name"].ToString();
                        gross = decimal.Parse(dr_getProduct["gross"].ToString());
                        discountPercentage = decimal.Parse(dr_getProduct["discount"].ToString());
                    }
                    dbconn.CloseConnection();
                    addToBill = true;
                    txtItemName.Text = name;
                    txtGross.Text = gross.ToString();
                    txtDisPercentage.Text = discountPercentage.ToString();
                    if (discountPercentage > 0)
                    {
                        discountPercentage = discountPercentage / 100;
                        decimal disAmount = Math.Round(decimal.Multiply(gross, discountPercentage), 2);
                        txtDisAmount.Text = disAmount.ToString();
                        txtNetAmount.Text = (gross - disAmount).ToString();
                    }
                    else
                    {
                        txtDisAmount.Text = "0";
                        txtNetAmount.Text = gross.ToString();
                    }
                    pboItemImage.Image = Image.FromFile(@"D:\Resources\ItemImage\" + id + ".jpg");
                }

                if (addToBill == true)
                {

                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
