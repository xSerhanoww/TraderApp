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
using static TraderBeta_02.StocksBar;
using static TraderBeta_02.TransactionsControl;
using static TraderBeta_02.Form1;
using System.Drawing.Design;

namespace TraderBeta_02
{
    public partial class PortfolioForm : Form
    {
        public static PortfolioForm Instance;
        public static double InvestedAmount { get; set; }
        public static double UnitsAmount { get; set; }

        public PortfolioForm()
        {
            Instance = this;
            InitializeComponent();
            LoadPortfolioData();
        }
        public static void AddSelectedStocksToPortfolio()
        {
            
            using (var db = new StocksDbContext())
            {
                foreach (var stock in ownedStocks)
                {
                    Guid newGuid = Guid.NewGuid();
                 
                    var portfolio = new PortfolioData
                    {
                        order_num = newGuid.ToString(),
                        StockName = stock.stockName_lbl.Text,
                        StockOwner = stock.stockFN_lbl.Text,
                        Investment = InvestedAmount,
                        Units = UnitsAmount,
                        Profit = 0,
                        Price = Convert.ToDouble(stock.stockPrice_lbl.Text),
                        Type = stock.stockType_lbl.Text,
                        owner_id = LoggedUserId

                    };                  
                    db.Portfolios.Add(portfolio);
                    
                }
                
                db.SaveChanges();
            }

        }
        public static void SellStocks()
        {
           using(var db = new StocksDbContext())
           {
                foreach (var item in db.Portfolios)
                {
                    if (item.order_num == tempStockBar.ordernum_lbl.Text)
                    {
                        db.Portfolios.Remove(item);
                    }
                }
                db.SaveChanges();

           }


        }
        private void LoadPortfolioData()
        {
            using (var db = new StocksDbContext())
            {
                var portfolio = db.Portfolios.Where(x => x.owner_id == LoggedUserId).ToList();
                foreach (var stock in portfolio)
                {
                    StocksBar stocksBar = new StocksBar(System.Drawing.Image.FromFile(SetImage(stock.StockName)), stock.StockName, stock.StockOwner, stock.Investment, stock.Profit, stock.Units, stock.Price, stock.Type);
                    stocksBar.buy_btn.Visible = false;
                    stocksBar.sell_btn.Visible = true;
                    stocksBar.investmentAmount_lbl.Visible = true;
                    stocksBar.profit_lbl.Visible = true;
                    stocksBar.units_lbl.Visible = true;
                    stocksBar.ordernum_lbl.Text = stock.order_num;
                    panel3.Controls.Add(stocksBar);
                   
                }

            }
        }

    }
   
}
