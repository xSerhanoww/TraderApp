using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TraderBeta_02.PortfolioForm;

namespace TraderBeta_02
{
    public partial class SellControl : UserControl
    {
        public SellControl()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1.Instance.panel3.Enabled = true;
            Form1.Instance.panel1.Enabled = true;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            SellStocks();
        }
    }
}
