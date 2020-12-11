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

namespace QuanLyNhaChoThue.GUI.HouseManagement
{
    public partial class FormHouseEdit : Form
    {
        public FormHouseEdit()
        {
            InitializeComponent();
        }

        private void FormHouseEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text) ||
                String.IsNullOrEmpty(txtHouseName.Text) ||
                String.IsNullOrEmpty(rtbDescription.Text))

            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string houseName = txtHouseName.Text;
                string address = txtAddress.Text;
                string description = rtbDescription.Text;
                HouseDTO houseDTO = new HouseDTO();
                houseDTO.Name = houseName;
                houseDTO.Address = address;
                houseDTO.Description = description;
                MessageBox.Show("Tên nhà: " + houseDTO.Name + "\n" +
                    "Địa chỉ: " + houseDTO.Address + "\n"
                    + "Mô tả: " + houseDTO.Description);
            
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
