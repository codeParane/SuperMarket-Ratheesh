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
            if (poBillDiscount.Text != "" && poBillDiscount.Text != null)
            {
                decimal gross = Math.Round(decimal.Parse(poGross.Text), 2);
                decimal itemSaving = Math.Round(decimal.Parse(poItemSavings.Text), 2);
                decimal gross_itemSaving = gross - itemSaving;
                if (poBillDiscount.Text != "")
                {
                    decimal disCash = 0;
                    decimal disPer = 0;



                    string disValue = poBillDiscount.Text;
                    decimal disValueDecimal = 0;

                    if (disValue.Substring(disValue.Length - 1) == "%" && disValue != "0")
                    {
                        disValueDecimal = decimal.Parse(disValue.Remove(disValue.Length - 1));
                        if (decimal.Parse(disValue.Remove(disValue.Length - 1)) >= 100 || decimal.Parse(disValue.Remove(disValue.Length - 1)) < 0)
                        {
                            MessageBox.Show("Wrong Discount Percentage!!!");
                            poBillDiscount.Text = "0"; poBillDisPer.Text = "0"; poBillDisCash.Text = "0";
                        }
                        else
                        {
                            disCash = Math.Round(gross_itemSaving * (disValueDecimal / 100), 2);
                            poBillDisCash.Text = disCash.ToString();
                            poBillDisPer.Text = poBillDiscount.Text;
                            poTotalBill.Text = Math.Round(gross_itemSaving - decimal.Parse(poBillDisCash.Text), 2).ToString();
                        }
                    }
                    else if (disValue.Substring(disValue.Length - 1) != "%" && disValue != "0")
                    {
                        disValueDecimal = decimal.Parse(disValue);
                        if (disValueDecimal < 0)
                        {
                            MessageBox.Show("Wrong Discount Amount!!!");
                            poBillDiscount.Text = "0"; poBillDisPer.Text = "0"; poBillDisCash.Text = "0";
                        }
                        else if (disValueDecimal > 0)
                        {
                            decimal div = 0;
                            div = disValueDecimal / gross_itemSaving;
                            disPer = Math.Round(div * 100, 2);
                            poBillDisCash.Text = poBillDiscount.Text;
                            poBillDisPer.Text = disPer.ToString();
                            poTotalBill.Text = Math.Round(gross_itemSaving - decimal.Parse(poBillDisCash.Text), 2).ToString();
                        }
                    }
                }
                else
                {
                    poBillDisPer.Text = "0%";
                    poBillDisCash.Text = "0";
                    poTotalBill.Text = gross_itemSaving.ToString();
                }
            }
        }
        decimal comp = 0;

        private void PayOption_Load(object sender, EventArgs e)
        {
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qGetStocks = "select itemcode, itemname, qty, rate, disa, net, cmprice from currentbill; ";
            MySqlDataAdapter aGetStocks = new MySqlDataAdapter(qGetStocks, dbconn.connection);
            DataSet ds = new DataSet();
            aGetStocks.Fill(ds, "Stocks");
            dgvFinalStocks.DataSource = ds.Tables["sto"];

            comp = 0;
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProduct = "SELECT sum(disa) AS dis, sum(net)  AS net, sum(cmprice) AS cmp FROM sm.currentbill;";
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
                        comp = Math.Round(decimal.Parse(dr_getProduct["cmp"].ToString()), 2);
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            finalSale("cash");
        }

       

        private void poCash_TextChanged(object sender, EventArgs e)
        {
            if(poCash.Text != "0" && poCash.Text != "" && poCash.Text  != null)
            {
                poBalance.Text = Math.Round(decimal.Parse(poCash.Text) - decimal.Parse(poTotalBill.Text), 2).ToString();

            }
            else
            {
                poBalance.Text = "0";
            }
        }

        private void poCash_Enter(object sender, EventArgs e)
        {
            poCash.Clear();
        }

        private void poBillDiscount_Enter(object sender, EventArgs e)
        {
            poBillDiscount.Clear();
        }

        private void poBillDiscount_Leave(object sender, EventArgs e)
        {
            if(poBillDiscount.Text == "")
            {
                poBillDiscount.Text = "0";
            }
        }



        public void finalSale(string payType)
        {

            string printString = "";
            PrintDocument p = new PrintDocument();


            //headerPrint
            string header = 
                "\t    --SHATTHVEES SUPERMART--" +
                "\n\t  Main Street, Kommathurai." +
                "\n\t       TP-0652050369" +
                "\n-------------------------------------------" +
                "\n#    Item\t Qty\t Grs\t Dis\t Net\n";
            //"\n-------------------------------------------\n";
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(header, new Font("Segoe ui", 10), new SolidBrush(Color.Black),
                    new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width,
                    p.DefaultPageSettings.PrintableArea.Height));
            };
            //----------------------------------

            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProducta = "select itemcode, itemname, qty, rate, disa, net, cmprice from currentbill;";
            MySqlCommand cm_getProducta = new MySqlCommand(qr_getProducta, dbconn.connection);
            MySqlDataReader dr_getProducta = cm_getProducta.ExecuteReader();

            //ItemList
            string itemList = "";
            if (dr_getProducta.HasRows == true)
            {
                int num = 1;
                while (dr_getProducta.Read())
                {
                    string barCode = dr_getProducta["itemcode"].ToString();
                    string itemName = dr_getProducta["itemname"].ToString();
                    decimal qty = Math.Round(decimal.Parse(dr_getProducta["qty"].ToString()), 3);
                    decimal rate = Math.Round(decimal.Parse(dr_getProducta["rate"].ToString()), 2);
                    decimal dis = Math.Round(decimal.Parse(dr_getProducta["qty"].ToString()), 3);
                    decimal net = Math.Round(decimal.Parse(dr_getProducta["qty"].ToString()), 3);

                    itemList += "\n   " + num +" - "+ itemName;
                    itemList += " \n\t" + qty + "\t" + rate + "\t" + dis + "\t" + net;
                    num++;
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
            string payTypeBill = "";
            if(payType == "cash")
            {
                decimal revenue = Math.Round(decimal.Parse(poTotalBill.Text) - comp, 2);
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qAddToBill1 = "INSERT INTO sales(billDate, amount, revenue, payType)  VALUES ('" + DateTime.Now.ToString("yyyy/MM/dd hh:mm")
                    + "'," + poTotalBill.Text + "," + revenue + ", 'cash');delete from currentbill;";
                MySqlCommand cAddToBill1 = new MySqlCommand(qAddToBill1, dbconn.connection);
                int queryAffected1 = cAddToBill1.ExecuteNonQuery();

                payTypeBill =
                    "\n Paid By Cash   Cash       : " + poCash.Text +
                    "\n                Balance    : " + poBalance.Text;
            }
            else if (payType == "card")
            {
                decimal revenue = Math.Round(decimal.Parse(poTotalBill.Text) - comp, 2);
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qAddToBill1 = "INSERT INTO sales(billDate, amount, revenue, payType)  VALUES ('" + DateTime.Now.ToString("yyyy/MM/dd hh:mm")
                    + "'," + poTotalBill.Text + "," + revenue + ", 'card');delete from currentbill;";
                MySqlCommand cAddToBill1 = new MySqlCommand(qAddToBill1, dbconn.connection);
                int queryAffected1 = cAddToBill1.ExecuteNonQuery();

                payTypeBill =
                    "\n Paid By Card   Bank       : " + cmbCardType.Text +
                    "\n                Deducted   : " + poTotalBill.Text;

            }
            else if (payType == "loan")
            {
                decimal revenue = Math.Round(decimal.Parse(poTotalBill.Text) - comp, 2);
                dbconn.CloseConnection();
                dbconn.OpenConnection();
                string qAddToBill1 = "INSERT INTO sales(billDate, amount, revenue, payType)  VALUES ('" + DateTime.Now.ToString("yyyy/MM/dd hh:mm")
                    + "'," + poTotalBill.Text + "," + revenue + ", 'loan');delete from currentbill;";
                MySqlCommand cAddToBill1 = new MySqlCommand(qAddToBill1, dbconn.connection);
                int queryAffected1 = cAddToBill1.ExecuteNonQuery();

                payTypeBill =
                    "\n Paid By Loan   Account    : " + cmbLoanAccount.Text +
                    "\n                Person     : " + cmbLoanName.Text +
                    "\n                Credit     : " + poTotalBill.Text;

            }

            //SELECT fields FROM table ORDER BY id DESC LIMIT 1;
            int lastBillid = 0;
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qr_getProducta2 = "select id from currentbill order by desa limit 1;";
            MySqlCommand cm_getProducta2 = new MySqlCommand(qr_getProducta2, dbconn.connection);
            MySqlDataReader dr_getProducta2 = cm_getProducta2.ExecuteReader();
 
            if (dr_getProducta2.HasRows == true)
            {
                while (dr_getProducta2.Read())
                {
                    lastBillid = int.Parse(dr_getProducta2["id"].ToString());
                }
            }




            string totalBill =
                "\n\t\tGross \t: " + poGross.Text +
                "\n\t\tDiscount : " + (decimal.Parse(poBillDiscount.Text) + decimal.Parse(poItemSavings.Text)) +
                "\n\t\t\tTotal \t: " + poTotalBill.Text;

            string footer =
                "\n   Bill # : "+ lastBillid +"   Casier : "+ LoginForm.loggedUser.ToUpper() +
                "\n   Date   : "+ DateTime.Now.ToString("yyyy/MM/dd") +" | Time : "+ DateTime.Now.ToString("hh:mm:ss") +"." +
                "\n\t\t <<<<  Thank You, Come Again.. >>>>";


            printString += payTypeBill;
            printString += itemList;
            printString += totalBill;
            printString += footer;

            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(printString, new Font("Seqoe ui", 10), new SolidBrush(Color.Black),
                    new RectangleF(0, 70, p.DefaultPageSettings.PrintableArea.Width,
                    p.DefaultPageSettings.PrintableArea.Height));
            };
            p.Print();
            this.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            finalSale("card");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            finalSale("loan");
            dbconn.CloseConnection();
            dbconn.OpenConnection();
            string qAddToBill = "UPDATE customers SET loan= loan + " + poTotalBill.Text +
                "WHERE nic = '"+ cmbLoanAccount.Text +"';insert into loan(nic, method, amount, dateNtime) values('"+
                cmbLoanAccount.Text +"', 'Credited', "+  poTotalBill.Text +", '"+ DateTime.Now +"');";
            MySqlCommand cAddToBill = new MySqlCommand(qAddToBill, dbconn.connection);
            int queryAffected = cAddToBill.ExecuteNonQuery();
            if (queryAffected > 0)
            {
                MessageBox.Show("Loan Updated!!!");
            }
        }

        private void cmbLoanName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoanAccount.SelectedItem = "";
        }

        private void cmbLoanAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbLoanName.Text = "";
        }
    }
}
