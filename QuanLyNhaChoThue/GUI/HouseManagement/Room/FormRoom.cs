using QuanLyNhaChoThue.Utils;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormRoom : Form
    {
        public int houseId = 0;
        public static Form formRoom;
        //public static int houseId = UC_HouseManagement.houseId;
        public FormRoom()
        {
            InitializeComponent();
            formRoom = this;
        }
        public FormRoom(int houseId)
        {
            InitializeComponent();
            this.houseId = houseId;
            uC_RoomManager1.houseId = houseId;
            formRoom = this;
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnHouseManagement.Height;
            SidePanel.Top = btnHouseManagement.Top;
            uC_RoomManager1.BringToFront();
            if (FormMain.formMain.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            uC_Home1.BringToFront();
        }

        private void ShowFormMain()
        {
            var formMain = new FormMain("ListHouse");
            formMain.ShowDialog();
        }

        private void btnHouseManagement_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHouseManagement.Height;
            SidePanel.Top = btnHouseManagement.Top;
            Thread thread = new Thread(new ThreadStart(ShowFormMain)); //Tạo luồng mới
            thread.Start(); //Khởi chạy luồng
            this.Close(); //đóng Form hiện tại. (Form1)
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAccountSetting.Height;
            SidePanel.Top = btnAccountSetting.Top;
            uC_ManageAccount1.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHelp.Height;
            SidePanel.Top = btnHelp.Top;
            ProcessStartInfo sInfo = new ProcessStartInfo("http://google.com/");
            Process.Start(sInfo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
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

        private void btnMinSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
