using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.AccountSetting
{
    public partial class FormPasswordEdit : Form
    {
        private int id = 0;
        UserBLL userBll = new UserBLL();
        public FormPasswordEdit()
        {
            InitializeComponent();
        }
        public FormPasswordEdit(int id)
        {
            InitializeComponent();
            this.id = id;
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
                    if (userBll.UpdatePassword(id, pass))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại! ", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp! ", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormPasswordEdit_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            txtConfirmPass.PasswordChar = '*';
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }
    }
}
