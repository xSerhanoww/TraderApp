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
using static TraderBeta_02.Data.StocksDbContext;
using static TraderBeta_02.StocksBar;

namespace TraderBeta_02
{
    public partial class WatchlistForm : Form
    {

        public WatchlistForm()
        {

            InitializeComponent();
            LoadStockData();

        }
        private void LoadStockData()
        {
            using (var db = new StocksDbContext())
            {
                var stocks = db.Stocks.ToList();
                foreach (var stock in stocks)
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    //stocksBar.stockID = stock.stock_id;
                    panel3.Controls.Add(stocksBar);
                }

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
