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
           
        }

        private void txtItemCode_Leave(object sender, EventArgs e)
        {
            string barCode="";
            string id = "";
            string name = "";
            double gross = 0;
            int discount = 0;
            bool addToBill = false;

            if (txtItemCode.Text != "")
            {
                barCode = txtItemCode.Text;
            }
            else
            {
                txtItemCode.Clear();
                txtItemCode.Focus();
            }
            
            if(barCode != "")
            {
                dbconn.OpenConnection();
                string qr_getProduct = "SELECT i.id AS id, i.name AS name, s.gross AS gross, s.discount AS discount, s.qty FROM" + 
                    " stocks AS s JOIN items AS i ON s.itemid = i.id WHERE s.barcode = " + barCode + ";";
                MySqlCommand cm_getProduct = new MySqlCommand(qr_getProduct, dbconn.connection);
                MySqlDataReader dr_getProduct = cm_getProduct.ExecuteReader();

                if (dr_getProduct.HasRows == true){
                    while (dr_getProduct.Read())
                    {
                        id = dr_getProduct["id"].ToString();
                        name = dr_getProduct["name"].ToString();
                        gross = double.Parse(dr_getProduct["gross"].ToString());
                        discount = int.Parse(dr_getProduct["discount"].ToString());
                    }
                    dbconn.CloseConnection();
                    addToBill = true;
                    txtItemName.Text = name;
                    txtGross.Text = gross.ToString();
                    txtDisPercentage.Text = discount.ToString();
                    if (discount > 0)
                    {
                        double disAmount = gross * (discount / 100);
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

                if(addToBill == true)
                {

                }
            }
        }



    }
}
