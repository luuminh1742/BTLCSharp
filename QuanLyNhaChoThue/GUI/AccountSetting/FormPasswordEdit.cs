using QuanLyNhaChoThue.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.AccountSetting
{
    public partial class FormPasswordEdit : Form
    {
        public FormPasswordEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtPass.Text) ||
                String.IsNullOrEmpty(txtConfirmPass.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string pass = txtPass.Text;
                string confirmPass = txtConfirmPass.Text;
                if (pass.Equals(confirmPass))
                {
                    UserDTO userDTO = new UserDTO();
                    userDTO.Password = pass;
                    MessageBox.Show("Pass :" + userDTO.Password);
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp! ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
