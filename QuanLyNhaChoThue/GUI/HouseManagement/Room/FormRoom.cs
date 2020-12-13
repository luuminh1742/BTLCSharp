using QuanLyNhaChoThue.Utils;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormRoom : Form
    {
        //public static int houseId = 0;
        public static int houseId = UC_HouseManagement.houseId;
        private int temp = 0;
        public FormRoom()
        {
            InitializeComponent();
        }
        public FormRoom(int houseId)
        {
            InitializeComponent();
            this.temp = houseId;
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btnHouseManagement.Height;
            SidePanel.Top = btnHouseManagement.Top;
            uC_RoomManager1.BringToFront();
            //houseId = temp;
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
            /*FormMain.formMain.Show();
            this.Close();*/

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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //FormLogin.formLogin.Close();
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
    }
}
