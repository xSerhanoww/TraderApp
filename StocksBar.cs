﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TraderBeta_02.Data;
using static TraderBeta_02.Data.StocksDbContext;
using static TraderBeta_02.PortfolioForm;

namespace TraderBeta_02
{
    public partial class StocksBar : UserControl
    {
        public static List<StocksBar> ownedStocks = new List<StocksBar>();
        public static List<StocksBar> stocksForSale = new List<StocksBar>();
        public static List<string> CurrentGuid = new List<string>();

        public static StocksBar tempStockBar { get; set; }

        public StocksBar(Image image, string stockName, string stockFullName, double? investmentAmt, double? profit, double? units, double price, string type)
        {

            InitializeComponent();
            this.pictureBox1.Image = image;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.stockName_lbl.Text = stockName;
            this.stockFN_lbl.Text = stockFullName;
            this.investmentAmount_lbl.Text = investmentAmt.ToString();
            this.profit_lbl.Text = profit.ToString();
            this.units_lbl.Text = units.ToString();
            this.stockPrice_lbl.Text = price.ToString();
            this.stockType_lbl.Text = type;
            this.Dock = DockStyle.Top;
        }
        public static string SetImage(string StockNamePNG)
        {

            return $@"..\..\..\Images\{StockNamePNG}.png";


        }

        private void buy_btn_Click(object sender, EventArgs e)
        {
            if (Form1.isLoggedIn == true)
            {
                TransactionsControl newTransaction = new TransactionsControl();

                Form1.Instance.Controls.Add(newTransaction);
                Form1.Instance.panel3.Enabled = false;
                Form1.Instance.panel1.Enabled = false;

                newTransaction.Location = new Point(360, 50);
                tempStockBar = this;
                newTransaction.stockname_lbl.Text = tempStockBar.stockName_lbl.Text;
                newTransaction.balance_lbl.Text = "$" + AccountForm.Balance.ToString();
                newTransaction.fullname_lbl.Text = tempStockBar.stockFN_lbl.Text;
                newTransaction.pictureBox1.Image = tempStockBar.pictureBox1.Image;
                newTransaction.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                newTransaction.price_lbl.Text = tempStockBar.stockPrice_lbl.Text;
                newTransaction.BringToFront();


                if (ownedStocks.Contains(tempStockBar) == false)
                {
                    ownedStocks.Add(tempStockBar);
                }
            }
            else
            {
                Form1.Instance.CallLoginForm();
            }
        }

        private void sell_btn_Click(object sender, EventArgs e)
        {
            SellControl newSell = new SellControl();

            Form1.Instance.Controls.Add(newSell);
            Form1.Instance.panel3.Enabled = false;
            Form1.Instance.panel1.Enabled = false;

            newSell.Location = new Point(360, 200);
            tempStockBar = this;
            newSell.stockname_lbl.Text = tempStockBar.stockName_lbl.Text;
            newSell.fullname_lbl.Text = tempStockBar.stockFN_lbl.Text;
            newSell.pictureBox1.Image = tempStockBar.pictureBox1.Image;
            newSell.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            newSell.price_lbl.Text = tempStockBar.stockPrice_lbl.Text;
            newSell.PL_lbl.Text = tempStockBar.profit_lbl.Text;
            newSell.BringToFront();

            if (stocksForSale.Contains(tempStockBar) == false)
            {
               stocksForSale.Add(tempStockBar);
            }

        }
    }
}
    

    

