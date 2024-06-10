using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraderBeta_02.Data;

namespace TraderBeta_02
{
    public partial class AccountForm : Form
    {
        public static double Balance {  get; set; }

        public static double StaticBalance { get; set; }
        public AccountForm()
        {
            InitializeComponent();
            SetValues();
        }

        private void SetValues()
        {
            
            balance_lbl.Text = "$" + Balance.ToString();
            using (var db = new StocksDbContext())
            {
                double investedAmount = 0;
                var currentPortfolio = db.Portfolios.Where(x => x.owner_id == Form1.LoggedUserId).ToList();
                foreach (var item in currentPortfolio)
                {
                    investedAmount += item.Investment;
                }
                investedPerc_lbl.Text = ((investedAmount/StaticBalance) * 100).ToString(format:"f2") + "%";


            }


        }
    }
}
