using QuanLyNhaChoThue.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
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
                    MessageBox.Show("UserName: " + userDTO.UserName+"\n"+"Password: "+userDTO.Password);
                    
                }    
            }
        }
    }
}
