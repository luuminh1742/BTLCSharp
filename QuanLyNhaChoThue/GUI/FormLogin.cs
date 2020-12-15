using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI
{
    public partial class FormLogin : Form
    {
        public static string userName = "";
        public static Form formLogin;
        UserBLL userBll = new UserBLL();
        public FormLogin()
        {
            InitializeComponent();
            formLogin = this;
        }

        private void ShowFormMain()
        {
            var formMain = new FormMain();
            formMain.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text) ||
                   String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                userName = txtUserName.Text;
                string pass = txtPassword.Text;
                UserDTO userDTO = new UserDTO();
                userDTO.UserName = userName;
                userDTO.Password = pass;
                UserDTO result = userBll.FindOne(userName, pass);
                if(result == null)
                {
                    MessageBox.Show("Đăng nhập thất bại ! ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if(result.UserName.Equals(userName) && result.Password.Equals(pass))
                {
                    Thread thread = new Thread(new ThreadStart(ShowFormMain)); //Tạo luồng mới
                    thread.Start(); //Khởi chạy luồng
                    this.Close(); //đóng Form hiện tại. 
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại ! ", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }
    }
}
