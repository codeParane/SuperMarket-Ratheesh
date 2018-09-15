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
            if (poBillDiscount.Text != "")
            {
                decimal disCash = 0;
                decimal disPer = 0;
                decimal gross = 0;
                decimal itemSaving = 0;
                decimal gross_itemSaving = 0;
                decimal totalBillAmount = 0;
                
                string disValue = poBillDiscount.Text;
                if (disValue.Substring(disValue.Length - 1) == "%" && disValue != "0")
                {
                    if (decimal.Parse(disValue.Remove(disValue.Length - 1)) >= 100 || decimal.Parse(disValue.Remove(disValue.Length - 1)) < 0)
                    {
                        MessageBox.Show("Wrong Discount Percentage!!!");
                        poBillDiscount.Text = "0"; poBillDisPer.Text = "0"; poBillDisCash.Text = "0";
                    }
                    else
                    {
                        disCash = Math.Round(gross_itemSaving * decimal.Parse(disValue.Remove(disValue.Length - 1)) / 100, 2);
                        poBillDisCash.Text = disCash.ToString();
                        poBillDisPer.Text = poBillDiscount.Text;
                    }
                }
                else if (disValue.Substring(disValue.Length - 1) != "%" && disValue != "0")
                {
                    if (decimal.Parse(disValue) < 0)
                    {
                        MessageBox.Show("Wrong Discount Amount!!!");
                        poBillDiscount.Text = "0";poBillDisPer.Text = "0"; poBillDisCash.Text = "0";
                    }
                    else
                    {
                        disPer = Math.Round((decimal.Parse(disValue) / gross_itemSaving) * 100, 2);
                        poBillDisCash.Text = poBillDiscount.Text;
                        poBillDisPer.Text = disPer.ToString();
                    }
                }
            }
            else
            {
                poBillDisPer.Text = "0%";
                poBillDisCash.Text = "0";
            }
        }
        decimal revenue = 0;

        private void PayOption_Load(object sender, EventArgs e)
        {
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qGetStocks = "select itemcode, itemname, qty, rate, disa, net, cmprice from currentbill; ";
            MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
            DataSet ds = new DataSet();
            aGetStocks.Fill(ds, "Stocks");
            dgvFinalStocks.DataSource = ds.Tables["sto"];

            revenue = 0;
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProduct = "SELECT sum(disa) AS dis, sum(net)  AS net, sum(cmprice) AS rev FROM sm.currentbill;";
            MySqlCommand cm_getProduct = new MySqlCommand(qr_getProduct, dbconn.connection);
            MySqlDataReader dr_getProduct = cm_getProduct.ExecuteReader();

            if (dr_getProduct.HasRows == true)
            {
                while (dr_getProduct.Read())
                {
                    if(dr_getProduct["dis"] != null)
                    {
                        poGross.Text = (decimal.Parse(dr_getProduct["dis"].ToString()) + decimal.Parse(dr_getProduct["net"].ToString())).ToString();
                        poItemSavings.Text = dr_getProduct["dis"].ToString();
                        poTotalBill.Text = dr_getProduct["net"].ToString();
                        revenue = Math.Round(decimal.Parse(dr_getProduct["rev"].ToString()), 2);

                    }

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
            PrintDocument p = new PrintDocument();

   


            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProducta = "select itemcode, itemname, qty, rate, disa, net, cmprice from currentbill;";
            MySqlCommand cm_getProducta = new MySqlCommand(qr_getProducta, dbconn.connection);
            MySqlDataReader dr_getProducta = cm_getProducta.ExecuteReader();

            if (dr_getProducta.HasRows == true)
            {
                while (dr_getProducta.Read())
                {
                    string barCode = dr_getProducta["itemcode"].ToString();
                    string itemName = dr_getProducta["itemname"].ToString();
                    decimal qty = Math.Round(decimal.Parse(dr_getProducta["qty"].ToString()), 3);
                    decimal rate = Math.Round(decimal.Parse(dr_getProducta["rate"].ToString()), 2);
                    decimal dis = Math.Round(decimal.Parse(dr_getProducta["qty"].ToString()), 3);
                    decimal net = Math.Round(decimal.Parse(dr_getProducta["qty"].ToString()), 3);
               }
            }


            foreach (DataGridViewRow row in dgvFinalStocks.Rows)
            {
                    string barCode = row.Cells["itemcode"].Value.ToString();
                string qty = row.Cells["qty"].Value.ToString();
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qAddToBill = "update stocks set qty=qty-" + qty + " where barcode='" + barCode + "';";
                MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
                int queryAffected = cAddToBill.ExecuteNonQuery();
                if (queryAffected > 0)
                {

                }

            }

            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qAddToBill1 = "INSERT INTO sales(billDate, amount, revenue)  VALUES ('"+ DateTime.Now.ToString("yyyy/MM/dd hh:mm") 
                +"',"+ poTotalBill.Text +","+ revenue +");delete from currentbill;";
            MySqlCommand cAddToBill1 = new MySqlCommand(qAddToBill1, dbconn.connection);
            int queryAffected1 = cAddToBill1.ExecuteNonQuery();
            if (queryAffected1 > 0)
            {

            }

            
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(printString, new Font("Seqoe ui", 10), new SolidBrush(Color.Black),
                    new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width,
                    p.DefaultPageSettings.PrintableArea.Height));
            };
            p.Print();

            this.Close();

        }
    }
}
