using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TraderBeta_02.PortfolioForm;
using static TraderBeta_02.StocksBar;


namespace TraderBeta_02
{
    public partial class TransactionsControl : UserControl
    {

        public static TransactionsControl? Instance;
        public TransactionsControl()
        {
            InitializeComponent();
            Instance = this;
        }

        private void exit_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Instance = null;
            Form1.Instance.panel3.Enabled = true;
            Form1.Instance.panel1.Enabled = true;



        }


        private void confirm_btn_Click(object sender, EventArgs e)
        {

            if (double.TryParse(amountInvested_txtbox.Text, out double number))
            {
                if (AccountForm.Balance >= Convert.ToDouble(amountInvested_txtbox.Text))
                {
                    InvestedAmount = Convert.ToDouble(this.amountInvested_txtbox.Text);
                    UnitsAmount = Convert.ToDouble(this.unitsAmt_lbl.Text);
                    AccountForm.Balance -= Convert.ToDouble(amountInvested_txtbox.Text);
                    AddSelectedStocksToPortfolio();
                    ownedStocks.Clear();
                    exit_Click(sender, e);
                }
                else insfFunds.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void amountInvested_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (amountInvested_txtbox.Text == "")
            {
                unitsAmt_lbl.Text = "";
            }
            else if (double.TryParse(amountInvested_txtbox.Text, out double number))
            {
                double result = Convert.ToDouble(amountInvested_txtbox.Text) / Form1.CurrentPrice;
                unitsAmt_lbl.Text = result.ToString(format: "f2");
            }
        }

        public void price_lbl_TextChanged(object sender, EventArgs e)
        {
           if (amountInvested_txtbox.Text == "")
           {
                unitsAmt_lbl.Text = "";
           }
           else if (double.TryParse(amountInvested_txtbox.Text, out double number))
           {
                double result = Convert.ToDouble(amountInvested_txtbox.Text) / Form1.CurrentPrice;
                unitsAmt_lbl.Text = result.ToString(format: "f2");
           }
        }
    }
}
