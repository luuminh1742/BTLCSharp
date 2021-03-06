﻿using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Text.RegularExpressions;
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
                    Regex checkPasword = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!% *#?&])[A-Za-z\d@$!%*#?&]{8,}$");
                    if (!checkPasword.IsMatch(pass))
                    {
                        MessageBox.Show("Mật khẩu tối thiểu tám ký tự, ít nhất một chữ cái, một số và một ký tự đặc biệt.",
                            "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

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

        

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }
    }
}
