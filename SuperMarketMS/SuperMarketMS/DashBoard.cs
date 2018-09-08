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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            if (LoginForm.loggedUser != null)
            {
                dbLoggedUser.Text = "Cashier : " + LoginForm.loggedUser.ToUpper();

            }

            dbTimer.Enabled = true;
            dbTimer.Interval = 1000;
            dbTimer.Tick += new EventHandler(this.tmrDateTime_Tick);
        }
        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            string dtTime = DateTime.Now.ToString("hh:mm:ss");
            string dtDate = DateTime.Now.ToString("yyyy/mm/dd");
            dbTimeNDate.Text = dtDate + " - " + dtTime;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //while
            viewDashboard l = new viewDashboard();
            l.TopLevel = false;
            dbFrmContainer.Controls.Add(l);
            l.Show();
            //dbFrmContainer.md

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
