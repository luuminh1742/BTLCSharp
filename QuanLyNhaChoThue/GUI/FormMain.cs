using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void setCheckedMenu(Button btnChecked)
        {
            string pathImgHome = @"C:\Source\CSharp\QuanLyNhaChoThue\QuanLyNhaChoThue\Image\icon_trang_chu_32px.png";
            string pathImgHomeChecked = @"C:\Source\CSharp\QuanLyNhaChoThue\QuanLyNhaChoThue\Image\icon_trang-chu_checked_32px.png";
            string pathImgHouseManagement = @"C:\Source\CSharp\QuanLyNhaChoThue\QuanLyNhaChoThue\Image\house_32px.png";
            string pathImgHouseManagementChecked = @"C:\Source\CSharp\QuanLyNhaChoThue\QuanLyNhaChoThue\Image\house_checked_32px.png";
            string pathImgAccountSetting = @"C:\Source\CSharp\QuanLyNhaChoThue\QuanLyNhaChoThue\Image\user_settings_32px.png";
            string pathImgAccountSettingChecked = @"C:\Source\CSharp\QuanLyNhaChoThue\QuanLyNhaChoThue\Image\user_settings_checked_32px.png";
            
           
            if (btnChecked == btnHome)
            {
                btnHome.BackColor = Color.AliceBlue;
                btnHome.ForeColor = Color.Blue;
                btnHome.Image = Image.FromFile(pathImgHomeChecked);
                
                /**/
                btnHouseManagement.BackColor = Color.White;
                btnHouseManagement.ForeColor = Color.Black;
                btnHouseManagement.Image = Image.FromFile(pathImgHouseManagement);
                
                /**/
                btnAccountSetting.BackColor = Color.White;
                btnAccountSetting.ForeColor = Color.Black;
                btnAccountSetting.Image = Image.FromFile(pathImgAccountSetting);
                
                return;
            }
            if (btnChecked == btnHouseManagement)
            {
                btnHome.BackColor = Color.White;
                btnHome.ForeColor = Color.Black;
                btnHome.Image = Image.FromFile(pathImgHome);
                /**/
                btnHouseManagement.BackColor = Color.AliceBlue;
                btnHouseManagement.ForeColor = Color.Blue;
                btnHouseManagement.Image = Image.FromFile(pathImgHouseManagementChecked);
                /**/
                btnAccountSetting.BackColor = Color.White;
                btnAccountSetting.ForeColor = Color.Black;
                btnAccountSetting.Image = Image.FromFile(pathImgAccountSetting);
                return;
            }
            if (btnChecked == btnAccountSetting)
            {
                btnHome.BackColor = Color.White;
                btnHome.ForeColor = Color.Black;
                btnHome.Image = Image.FromFile(pathImgHome);
                /**/
                btnHouseManagement.BackColor = Color.White;
                btnHouseManagement.ForeColor = Color.Black;
                btnHouseManagement.Image = Image.FromFile(pathImgHouseManagement);
                /**/
                btnAccountSetting.BackColor = Color.AliceBlue;
                btnAccountSetting.ForeColor = Color.Blue;
                btnAccountSetting.Image = Image.FromFile(pathImgAccountSettingChecked);
                return;
            }
        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            setCheckedMenu(btnHome);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            setCheckedMenu(btnHome);
            uC_Home1.BringToFront();
        }

        private void btnHouseManagement_Click(object sender, EventArgs e)
        {
            setCheckedMenu(btnHouseManagement);
            uC_HouseManagement1.BringToFront();
        }

        private void btnAccountSetting_Click(object sender, EventArgs e)
        {
            setCheckedMenu(btnAccountSetting);
            uC_ManageAccount1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            var formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}
