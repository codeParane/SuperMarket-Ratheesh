using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketMS
{
    public partial class PayOption : Form
    {
        DbConn dbconn = new DbConn();
        public PayOption()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (poTotalDiscount.Text != "")
            {
                Decimal disCash = 0;
                decimal disPer = 0;
                string disValue = poTotalDiscount.Text;
                if (disValue.Substring(disValue.Length - 1) == "%" && disValue != "0")
                {
                    if (decimal.Parse(disValue.Remove(disValue.Length - 1)) >= 100 || decimal.Parse(disValue.Remove(disValue.Length - 1)) < 0)
                    {
                        MessageBox.Show("Wrong Discount Percentage!!!");
                        poTotalDiscount.Text = "0"; poTotalDisPer.Text = "0"; poTotalDisCash.Text = "0";
                    }
                    else
                    {
                        disCash = Math.Round(decimal.Parse(txtFinal.Text) * decimal.Parse(disValue.Remove(disValue.Length - 1)) / 100, 2);
                        poTotalDisCash.Text = disCash.ToString();
                        poTotalDisPer.Text = poTotalDiscount.Text;
                    }
                }
                else if (disValue.Substring(disValue.Length - 1) != "%" && disValue != "0")
                {
                    if (decimal.Parse(disValue) < 0)
                    {
                        MessageBox.Show("Wrong Discount Amount!!!");
                        poTotalDiscount.Text = "0";poTotalDisPer.Text = "0"; poTotalDisCash.Text = "0";
                    }
                    else
                    {
                        disPer = Math.Round(decimal.Parse(disValue) / decimal.Parse(txtFinal.Text) * 100, 2);
                        poTotalDisCash.Text = poTotalDiscount.Text;
                        poTotalDisPer.Text = disPer.ToString();
                    }
                }
            }
            else
            {
                poTotalDisPer.Text = "0%";
                poTotalDisCash.Text = "0";
            }
        }

        private void PayOption_Load(object sender, EventArgs e)
        {
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProduct = "SELECT sum(disa) AS dis, sum(net) AS net FROM sm.currentbill;";
            MySqlCommand cm_getProduct = new MySqlCommand(qr_getProduct, dbconn.connection);
            MySqlDataReader dr_getProduct = cm_getProduct.ExecuteReader();

            if (dr_getProduct.HasRows == true)
            {
                while (dr_getProduct.Read())
                {
                    txtGross.Text = (decimal.Parse(dr_getProduct["dis"].ToString()) + decimal.Parse(dr_getProduct["net"].ToString())).ToString();
                    txtDis.Text = dr_getProduct["dis"].ToString();
                    txtFinal.Text = dr_getProduct["net"].ToString();

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalSale();
        }

        public void finalSale()
        {

            string printString = "";
            //reduce Stock
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProduct = "select * from currentbill;";
            MySqlCommand cm_getProduct = new MySqlCommand(qr_getProduct, dbconn.connection);
            MySqlDataReader dr_getProduct = cm_getProduct.ExecuteReader();

            if (dr_getProduct.HasRows == true)
            {
                while (dr_getProduct.Read())
                {
                    string barCode = dr_getProduct["itemcode"].ToString();
                    string itemName = dr_getProduct["itemname"].ToString();
                    decimal qty = Math.Round(decimal.Parse(dr_getProduct["qty"].ToString()), 3);

                    printString = printString + barCode + "\t" + itemName + "\t" + qty;
                    dbconn.CloseConnection();
                    dbconn.OpenConnection();
                    string qAddToBill = "update stocks set qty=qty-" + qty + " where barcode='" + barCode + "';";
                    MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
                    int queryAffected = cAddToBill.ExecuteNonQuery();
                    if (queryAffected > 0)
                    {

                    }
                }
            }

            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qAddToBill1 = "INSERT INTO sales(billDate, amount, revenue)  VALUES ('"+ DateTime.Now +"',"+ txtFinal.Text +",0);";
            MySqlCommand cAddToBill1 = new MySqlCommand(qAddToBill1, dbconn.connection);
            int queryAffected1 = cAddToBill1.ExecuteNonQuery();
            if (queryAffected1 > 0)
            {

            }

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(printString, new Font("Seqoe ui", 10), new SolidBrush(Color.Black),
                    new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width,
                    p.DefaultPageSettings.PrintableArea.Height));
            };
            p.Print();
            //add To sales
            

        }
    }
}
