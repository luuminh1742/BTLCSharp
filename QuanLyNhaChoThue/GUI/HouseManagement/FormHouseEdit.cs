using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement
{
    public partial class FormHouseEdit : Form
    {
        HouseBLL houseBll = new HouseBLL();
        string type = "";
       
        private int houseId = -1;
        private string houseName = "";
        private string address = "";
        private string description = "";
        public FormHouseEdit()
        {
            InitializeComponent();
        }

        public FormHouseEdit(string type, int houseId, string houseName, string address, string description)
        {
            InitializeComponent();
            this.type = type;
            this.houseId = houseId;
            this.houseName = houseName;
            this.address = address;
            this.description = description;
        }

        private void FormHouseEdit_Load(object sender, EventArgs e)
        {
            if (type.Equals("EDIT"))
            {
                lbTitle.Text = "Cập nhật nhà";
                btnModify.Text = "Cập nhật";
                txtHouseName.Text = houseName;
                txtAddress.Text = address;
                txtDescription.Text = description;
            }
            else
            {
                lbTitle.Text = "Thêm nhà";
                btnModify.Text = "Thêm nhà";
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text) ||
                String.IsNullOrEmpty(txtHouseName.Text) ||
                String.IsNullOrEmpty(txtDescription.Text))

            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin ! ", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (type.Equals("ADD"))
                {
                    Insert();
                }
                else
                {
                    Update();
                }
                this.Close();

            }
        }
        private void Insert()
        {
            string houseName = txtHouseName.Text;
            string address = txtAddress.Text;
            string description = txtDescription.Text;
            HouseDTO houseDTO = new HouseDTO();
            houseDTO.Name = houseName;
            houseDTO.Address = address;
            houseDTO.Description = description;

            if (houseBll.Insert(houseDTO))
            {
                MessageBox.Show("Lưu nhà thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu nhà thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Update()
        {
            string houseName = txtHouseName.Text;
            string address = txtAddress.Text;
            string description = txtDescription.Text;
            HouseDTO houseDTO = new HouseDTO();
            houseDTO.Id = houseId;
            houseDTO.Name = houseName;
            houseDTO.Address = address;
            houseDTO.Description = description;

            if (houseBll.Update(houseDTO))
            {
                MessageBox.Show("Lưu nhà thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu nhà thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }

        private void lbTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }
    }
}
