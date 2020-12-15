using QuanLyNhaChoThue.GUI.HouseManagement.Room;
using QuanLyNhaChoThue.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
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
                if (FormRoom.formRoom.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
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

        private void ShowFormLogin()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormLogin));
            thread.Start();
            this.Close();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHelp.Height;
            SidePanel.Top = btnHelp.Top;
            ProcessStartInfo sInfo = new ProcessStartInfo("http://google.com/");
            Process.Start(sInfo);
        }

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
