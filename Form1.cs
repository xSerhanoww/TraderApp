using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace TraderBeta_02
{

    public partial class Form1 : Form
    {

        public static Form1 Instance;

        public static bool isLoggedIn { get; set; }

        public static int LoggedUserId { get; set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
            CallWatchlistForm();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void watchlist_btn_Click(object sender, EventArgs e)
        {
            CallWatchlistForm();

        }

        private void portfolio_btn_Click(object sender, EventArgs e)
        {
            if (isLoggedIn == true)
            {
                SidePanel.Height = portfolio_btn.Height;

                SidePanel.Top = portfolio_btn.Top;

                PortfolioForm portfolioForm = new PortfolioForm();

                portfolioForm.TopLevel = false;

                portfolioForm.Dock = DockStyle.Fill;

                panel3.Controls.Clear();

                panel3.Controls.Add(portfolioForm);

                portfolioForm.Show();
            }
            else
            {
                CallLoginForm();
            }

        }

        private void acc_btn_Click(object sender, EventArgs e)
        {
            if (isLoggedIn == true)
            {
                SidePanel.Height = acc_btn.Height;

                SidePanel.Top = acc_btn.Top;

                AccountForm accForm = new AccountForm();

                accForm.TopLevel = false;

                accForm.Dock = DockStyle.Fill;

                panel3.Controls.Clear();

                panel3.Controls.Add(accForm);

                accForm.Show();
            }
            else
            {
                CallLoginForm();
            }


        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            CallLoginForm();
        }
        private void CallWatchlistForm()
        {

            SidePanel.Height = watchlist_btn.Height;

            SidePanel.Top = watchlist_btn.Top;

            WatchlistForm watchlistForm = new WatchlistForm();

            watchlistForm.TopLevel = false;

            watchlistForm.Dock = DockStyle.Fill;

            panel3.Controls.Clear();

            panel3.Controls.Add(watchlistForm);

            watchlistForm.Show();


        }
        public void CallLoginForm()
        {
            LoginControl loginControl = new LoginControl();

            this.Controls.Add(loginControl);
            this.panel3.Enabled = false;
            this.panel1.Enabled = false;

            loginControl.Location = new Point(360, 50);
            loginControl.BringToFront();


        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to LogOut ?", "LogOut", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                isLoggedIn = false;
                LoginControl.CheckLogin();
                CallWatchlistForm();    
            }
            else if (dialogResult == DialogResult.No)
            {
                isLoggedIn = true;
            }
        }
    }
}
