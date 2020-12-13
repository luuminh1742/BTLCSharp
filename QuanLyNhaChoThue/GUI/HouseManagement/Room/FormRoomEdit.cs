using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormRoomEdit : Form
    {
        private int roomId = -1;
        private int houseId = -1;
        private string type = "";
        RoomBLL roomBll = new RoomBLL();
        public FormRoomEdit()
        {
            InitializeComponent();
        }

        public FormRoomEdit(int roomId,int houseId,string type)
        {
            InitializeComponent();
            this.type = type;
            this.houseId = houseId;
            this.roomId = roomId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtRoomName.Text) || String.IsNullOrEmpty(txtRoomMoney.Text) ||
                String.IsNullOrEmpty(txtElectricMoney.Text) || String.IsNullOrEmpty(txtLastElectricNumber.Text) ||
                String.IsNullOrEmpty(txtWaterMoney.Text) || String.IsNullOrEmpty(txtLastWaterNumber.Text) ||
                String.IsNullOrEmpty(cbbNetworkMoneyType.Text) || String.IsNullOrEmpty(cbbNetworkMoneyType.Text) ||
                String.IsNullOrEmpty(txtNetworkMoney.Text) || String.IsNullOrEmpty(txtOtherMoney.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầu đủ thông tin!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (type.Equals("ADD"))
                    Insert();
                else Update();
            }

            
        }

        private void Insert()
        {
            try
            {
                RoomDTO roomDTO = new RoomDTO();
                roomDTO.RoomName = txtRoomName.Text.Trim();
                roomDTO.RoomMoney = int.Parse(txtRoomMoney.Text);
                roomDTO.ElectricMoney = int.Parse(txtElectricMoney.Text);
                roomDTO.LastElectricNumber = int.Parse(txtLastElectricNumber.Text);
                roomDTO.WaterMoney = int.Parse(txtWaterMoney.Text);
                roomDTO.LastWaterNumber = 0;
                roomDTO.LastWaterNumber = int.Parse(txtLastWaterNumber.Text);
                roomDTO.NetworkMoney = int.Parse(txtNetworkMoney.Text);
                roomDTO.OtherMoney = int.Parse(txtOtherMoney.Text);
                roomDTO.Description = txtDescription.Text.Trim();
                roomDTO.HouseId = houseId;
                roomDTO.WaterMoneyType = cbbWaterMoneyType.Text;
                roomDTO.NetworkMoneyType = cbbNetworkMoneyType.Text;
                if (roomBll.Insert(roomDTO))
                {
                    MessageBox.Show("Thêm phòng thành công", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi nhập số", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update()
        {
            try
            {
                RoomDTO roomDTO = new RoomDTO();
                roomDTO.Id = roomId;
                roomDTO.HouseId = houseId;
                roomDTO.RoomName = txtRoomName.Text.Trim();
                roomDTO.RoomMoney = int.Parse(txtRoomMoney.Text);
                roomDTO.ElectricMoney = int.Parse(txtElectricMoney.Text);
                roomDTO.LastElectricNumber = int.Parse(txtLastElectricNumber.Text);
                roomDTO.WaterMoney = int.Parse(txtWaterMoney.Text);
                roomDTO.LastWaterNumber = 0;
                roomDTO.LastWaterNumber = int.Parse(txtLastWaterNumber.Text);
                roomDTO.NetworkMoney = int.Parse(txtNetworkMoney.Text);
                roomDTO.OtherMoney = int.Parse(txtOtherMoney.Text);
                roomDTO.Description = txtDescription.Text.Trim();
                roomDTO.WaterMoneyType = cbbWaterMoneyType.Text;
                roomDTO.NetworkMoneyType = cbbNetworkMoneyType.Text;
                if (roomBll.Update(roomDTO))
                {
                    MessageBox.Show("Cập nhật phòng thành công", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Cập nhật phòng thất bại", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi nhập số", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChangeTypeWaterMoney()
        {
            /*
                0 - Theo đầu người
                1 - Theo phòng
                2 - Theo số công tơ
                3 - Miễn phí
             */
            if (cbbWaterMoneyType.Text.Equals("Theo số công tơ"))
            {
                txtLastWaterNumber.Text = "0";
                txtLastWaterNumber.Enabled = true;
            }
            else
            {
                txtLastWaterNumber.Text = "0";
                txtLastWaterNumber.Enabled = false;

            }
        }
        private void ChangeTypeNetworkMoney()
        {
            /*
                * 0 - Theo đầu người
                1 - Theo phòng
                2 - Miễn phí
            */
            if(cbbNetworkMoneyType.Text.Equals("Miễn phí"))
            {
                txtNetworkMoney.Text = "0";
                txtNetworkMoney.Enabled = false;
            }
            else
            {
                txtNetworkMoney.Text = "0";
                txtNetworkMoney.Enabled = true;
            }
        }

        private void FormRoomEdit_Load(object sender, EventArgs e)
        {
            if (type.Equals("EDIT"))
            {
                lbTitle.Text = "Cập nhật phòng";
                btnUpdate.Text = "Cập nhật";
                RoomDTO roomDTO = roomBll.findOne(roomId);
                txtRoomName.Text = roomDTO.RoomName;
                txtRoomMoney.Text = roomDTO.RoomMoney.ToString();
                txtElectricMoney.Text = roomDTO.ElectricMoney.ToString();
                txtLastElectricNumber.Text = roomDTO.LastElectricNumber.ToString();
                txtWaterMoney.Text = roomDTO.WaterMoney.ToString();
                cbbWaterMoneyType.Text = roomDTO.WaterMoneyType;
                txtLastWaterNumber.Text = roomDTO.LastWaterNumber.ToString();
                cbbNetworkMoneyType.Text = roomDTO.NetworkMoneyType;
                txtNetworkMoney.Text = roomDTO.NetworkMoney.ToString();
                txtOtherMoney.Text = roomDTO.OtherMoney.ToString();
                txtDescription.Text = roomDTO.Description;
            }
            else if (type.Equals("ADD"))
            {
                lbTitle.Text = "Thêm phòng";
                btnUpdate.Text = "Thêm phòng";
            }

        }

        private void cbbWaterMoneyType_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeTypeWaterMoney();
        }

        private void cbbNetworkMoneyType_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeTypeNetworkMoney();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }
    }
}
