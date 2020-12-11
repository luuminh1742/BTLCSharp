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

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room.Member
{
    public partial class FormMemberEdit : Form
    {
        public FormMemberEdit()
        {
            InitializeComponent();
        }

        private void FormMemberEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
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
                userDTO.FullName = name;
                userDTO.Phone = phone;
                userDTO.Address = address;
                userDTO.Gender = gender;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
