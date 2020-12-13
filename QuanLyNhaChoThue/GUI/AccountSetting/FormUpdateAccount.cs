using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.AccountSetting
{
    public partial class FormUpdateAccount : Form
    {
        UserBLL userBll = new UserBLL();
        UserDTO user = new UserDTO();
        public static string username = "";
        public FormUpdateAccount()
        {
            InitializeComponent();
        }
        public FormUpdateAccount(int id,string username, string fullName, string gender,
            string address, string phone)
        {
            InitializeComponent();
            user.Id = id;
            user.UserName = username;
            user.FullName = fullName;
            user.Gender = gender;
            user.Address = address;
            user.Phone = phone;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                username = txtUsername.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string address = txtAddress.Text;
                string gender = "";
                if (rbtMale.Checked)
                    gender = rbtMale.Text;
                else if (rbtFemale.Checked)
                    gender = rbtFemale.Text;
                else if (rbtOther.Checked)
                    gender = rbtOther.Text;
                UserDTO userDTO = new UserDTO();
                userDTO.Id = user.Id;
                userDTO.UserName = username;
                userDTO.FullName = name;
                userDTO.Phone = phone;
                userDTO.Gender = gender;
                userDTO.Address = address;
                if (userBll.UpdateAdmin(userDTO))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }

        private void FormUpdateAccount_Load(object sender, EventArgs e)
        {
            txtUsername.Text = user.UserName;
            txtName.Text = user.FullName;
            txtAddress.Text = user.Address;
            txtPhone.Text = user.Phone;
            if (user.Gender.Equals("Nam"))
            {
                rbtMale.Checked = true;
            }
            else if (user.Gender.Equals("Nữ"))
            {
                rbtFemale.Checked = true;
            }
            else
            {
                rbtOther.Checked = true;
            }
            
        }
    }
}
