using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI
{
    public partial class FormLogin : Form
    {
        UserBLL userBll = new UserBLL();
        public FormLogin()
        {
            InitializeComponent();
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
                string userName = txtUserName.Text;
                string pass = txtPassword.Text;
                UserDTO userDTO = new UserDTO();
                userDTO.UserName = userName;
                userDTO.Password = pass;
                if (userBll.Login(userDTO))
                {
                    this.Hide();
                    //this.Close();
                    var formMain = new FormMain();
                    formMain.Show();
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
    }
}
