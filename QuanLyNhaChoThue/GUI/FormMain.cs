using QuanLyNhaChoThue.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI
{
    public partial class FormMain : Form
    {
        public static Form formMain;
        private string at = "";
        public FormMain()
        {
            InitializeComponent();
            formMain = this;
        }
        public FormMain(string at)
        {
            InitializeComponent();
            formMain = this;
            this.at = at;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (at.Equals("ListHouse"))
            {
                SidePanel.Height = btnHouseManagement.Height;
                SidePanel.Top = btnHouseManagement.Top;
                uC_HouseManagement1.BringToFront();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            uC_Home1.BringToFront();
        }

        private void btnHouseManagement_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHouseManagement.Height;
            SidePanel.Top = btnHouseManagement.Top;
            uC_HouseManagement1.BringToFront();
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAccountSetting.Height;
            SidePanel.Top = btnAccountSetting.Top;
            uC_ManageAccount1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var formLogin = new FormLogin();
            formLogin.Show();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormLogin.formLogin.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        private void btnMaxSize_MouseHover(object sender, EventArgs e)
        {
            btnMaxSize.BackColor = Color.LightGray;
        }

        private void btnMaxSize_MouseLeave(object sender, EventArgs e)
        {
            btnMaxSize.BackColor = Color.White;
        }

        private void btnMinSize_MouseHover(object sender, EventArgs e)
        {
            btnMinSize.BackColor = Color.LightGray;
        }

        private void btnMinSize_MouseLeave(object sender, EventArgs e)
        {
            btnMinSize.BackColor = Color.White;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }

        private void btnMaxSize_Click(object sender, EventArgs e)
        {
            if(this.MaximizeBox)
            {
                this.MinimumSize = new Size(1200, 980); ;
            }
            else
            {
                this.MinimumSize = new Size(1004, 511); 
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHelp.Height;
            SidePanel.Top = btnHelp.Top;
        }
    }
}
