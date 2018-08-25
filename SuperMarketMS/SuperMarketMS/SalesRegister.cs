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
        public SalesRegister()
        {
            InitializeComponent();
        }

        private void SalesRegister_Load(object sender, EventArgs e)
        {
            pboItemImage.Image = Image.FromFile(@"D:\Resources\ItemImage\1.jpg");
        }
    }
}
