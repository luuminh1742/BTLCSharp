using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaChoThue.DTO;

namespace QuanLyNhaChoThue.GUI.AccountSetting
{
    public partial class FormUpdateAccount : Form
    {
        public FormUpdateAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsername.Text)||String.IsNullOrEmpty(txtName.Text)||String.IsNullOrEmpty(txtPhone.Text)||String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string username = txtUsername.Text;
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
                userDTO.UserName = username;
                userDTO.FullName = name;
                userDTO.Phone = phone;
                userDTO.Gender = gender;
                userDTO.Address = address;
            }
        }
    }
}
