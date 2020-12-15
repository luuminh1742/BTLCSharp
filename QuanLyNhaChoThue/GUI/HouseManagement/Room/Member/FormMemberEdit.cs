using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room.Member
{
    public partial class FormMemberEdit : Form
    {
        UserBLL userBll = new UserBLL();
        private string type = "";
        UserDTO user = new UserDTO();
        public FormMemberEdit()
        {
            InitializeComponent();
        }
        public FormMemberEdit(string type, int id, string fullName, string gender,
            string address, string phone)
        {
            InitializeComponent();
            this.type = type;
            user.Id = id;
            user.FullName = fullName;
            user.Gender = gender;
            user.Address = address;
            user.Phone = phone;
        }
        public FormMemberEdit(string type,int roomId)
        {
            InitializeComponent();
            this.type = type;
            user.RoomId = roomId;
        }

        private void FormMemberEdit_Load(object sender, EventArgs e)
        {
            btnDeleteMember.Visible = false;
            if (type.Equals("EDIT"))
            {
                lbTitle.Text = "Cập nhật thành viên";
                txtName.Text = user.FullName;
                txtAddress.Text = user.Address;
                txtPhone.Text = user.Phone;
                if (user.Gender.Trim().Equals("Nam"))
                {
                    rdbMale.Checked = true;
                }else
                {
                    rdbFemale.Checked = true;
                }
                btnDeleteMember.Visible = true;
            }
            else
            {
                lbTitle.Text = "Thêm thành viên";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            }
        }

        private void Insert()
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = "";
            if (rdbMale.Checked)
                gender = rdbMale.Text.Trim();
            else if (rdbFemale.Checked)
                gender = rdbFemale.Text.Trim();
            UserDTO userDTO = new UserDTO();
            userDTO.RoomId = user.RoomId;
            userDTO.FullName = name;
            userDTO.Phone = phone;
            userDTO.Address = address;
            userDTO.Gender = gender;
            if (userBll.Insert(userDTO))
            {
                MessageBox.Show("Lưu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
        private void Update()
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = "";
            if (rdbMale.Checked)
                gender = rdbMale.Text.Trim();
            else if (rdbFemale.Checked)
                gender = rdbFemale.Text.Trim();
            UserDTO userDTO = new UserDTO();
            userDTO.Id = user.Id;
            userDTO.FullName = name;
            userDTO.Phone = phone;
            userDTO.Address = address;
            userDTO.Gender = gender;
            if (userBll.Update(userDTO))
            {
                MessageBox.Show("Lưu thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận xóa","Cảnh báo",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (userBll.Delete(user.Id))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
