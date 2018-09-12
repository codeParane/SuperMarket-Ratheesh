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
    public partial class PayOption : Form
    {
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
                        disCash = Math.Round(decimal.Parse(poTotalBill.Text) * decimal.Parse(disValue.Remove(disValue.Length - 1)) / 100, 2);
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
                        disPer = Math.Round(decimal.Parse(disValue) / decimal.Parse(poTotalBill.Text) * 100, 2);
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
    }
}
