using QuanLyNhaChoThue.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormRoomEdit : Form
    {
        public FormRoomEdit()
        {
            InitializeComponent();
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
                try
                {
                    RoomDTO roomDTO = new RoomDTO();
                    roomDTO.RoomName = txtRoomName.Text.Trim();
                    roomDTO.RoomMoney = int.Parse(txtRoomMoney.Text);
                    roomDTO.ElectricMoney = int.Parse(txtElectricMoney.Text);
                    roomDTO.LastElectricNumber = int.Parse(txtLastElectricNumber.Text);
                    roomDTO.WaterMoney = int.Parse(txtWaterMoney.Text);
                    roomDTO.LastWaterNumber = int.Parse(txtLastWaterNumber.Text);
                    roomDTO.NetworkMoney = int.Parse(txtNetworkMoney.Text);
                    roomDTO.OtherMoney = int.Parse(txtOtherMoney.Text);
                    roomDTO.Description = txtDescription.Text.Trim();
                    switch (cbbNetworkMoneyType.Text)
                    {
                        case "Theo đầu người":
                            roomDTO.WaterMoneyType = 0;
                            break;
                        case "Theo phòng":
                            roomDTO.WaterMoneyType = 1;
                            break;
                        case "Theo số công tơ":
                            roomDTO.WaterMoneyType = 2;
                            break;
                        case "Miễn phí":
                            roomDTO.WaterMoneyType = 3;
                            break;
                        default:
                            roomDTO.WaterMoneyType = -1;
                            break;
                    }
                    /*
                        * 0 - Theo đầu người
                        1 - Theo phòng
                        2 - Miễn phí
                    */
                    switch (cbbNetworkMoneyType.Text)
                    {
                        case "Theo đầu người":
                            roomDTO.WaterMoneyType = 0;
                            break;
                        case "Theo phòng":
                            roomDTO.WaterMoneyType = 1;
                            break;
                        case "Miễn phí":
                            roomDTO.WaterMoneyType = 2;
                            break;
                        default:
                            roomDTO.WaterMoneyType = -1;
                            break;
                    }


                    MessageBox.Show("SS");

                }
                catch(FormatException ex)
                {
                        MessageBox.Show(ex.Message, "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        }

        private void cbbWaterMoneyType_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeTypeWaterMoney();
        }

        private void cbbNetworkMoneyType_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeTypeNetworkMoney();
        }
    }
}
