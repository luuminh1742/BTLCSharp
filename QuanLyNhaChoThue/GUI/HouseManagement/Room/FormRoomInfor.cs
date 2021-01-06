using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.GUI.HouseManagement.Room.Bill;
using QuanLyNhaChoThue.GUI.HouseManagement.Room.Member;
using QuanLyNhaChoThue.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormRoomInfor : Form
    {
        UserBLL userBll = new UserBLL();
        RoomBLL roomBll = new RoomBLL();
        RoomDTO roomDTO = new RoomDTO();
        BillBLL billBll = new BillBLL();
        public FormRoomInfor()
        {
            InitializeComponent();
        }
        public FormRoomInfor(int roomId)
        {
            InitializeComponent();
            roomDTO.Id = roomId;
        }

        private void FormRoomInfor_Load(object sender, EventArgs e)
        {
            roomDTO = roomBll.findOne(roomDTO.Id);
            if(roomDTO.Member == 0)
            {
                btnUpdateBill.Enabled = false;
            }
            else
            {
                btnUpdateBill.Enabled = true;
            }
            lbInfor.Text = "Phòng : " + roomDTO.RoomName;
            lbMember.Text = "Thành viên : " + roomDTO.Member;
            LoadMember(roomDTO.Id);
            LoadMoneyTypes();
            LoadBill();
            dgvMember.AllowUserToAddRows = false;
            dgvBill.AllowUserToAddRows = false;
            dgvMember.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMember.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvMember.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void LoadBill()
        {
            dgvBill.DataSource = null;
            dgvBill.DataSource = billBll.FindByRoomId(roomDTO.Id);
            dgvBill.Columns["Id"].Visible = false;
            dgvBill.Columns["RoomId"].Visible = false;
            dgvBill.Columns["MemberName"].Visible = false;
            dgvBill.Columns["RoomMoney"].Visible = false;
            dgvBill.Columns["ElectricMoney"].Visible = false;
            dgvBill.Columns["WaterMoney"].Visible = false;
            dgvBill.Columns["NetworkMoney"].Visible = false;
            dgvBill.Columns["OtherMoney"].Visible = false;
            dgvBill.Columns["LastElectricNumber"].Visible = false;
            dgvBill.Columns["ElectricNumber"].Visible = false;
            dgvBill.Columns["LastWaterNumber"].Visible = false;
            dgvBill.Columns["WaterNumber"].Visible = false;
            dgvBill.Columns["WaterNumber"].Visible = false;
            dgvBill.Columns["ModifiedBy"].Visible = false; 
            dgvBill.Columns[12].HeaderCell.Value = "Tổng tiền";
            dgvBill.Columns[14].HeaderCell.Value = "Ngày tạo";
            dgvBill.Columns[15].HeaderCell.Value = "Ngày đóng tiền";
            dgvBill.Columns[16].HeaderCell.Value = "Trạng thái";
           
        }
        private void LoadMember(int roomId)
        {
            dgvMember.DataSource = null;
            dgvMember.DataSource = userBll.FindMemBerByRoomId(roomId);
            dgvMember.Columns["Id"].Visible = false;
            dgvMember.Columns["UserName"].Visible = false;
            dgvMember.Columns["Password"].Visible = false;
            dgvMember.Columns["ModifiedDate"].Visible = false;
            dgvMember.Columns["Status"].Visible = false;
            dgvMember.Columns["RoomId"].Visible = false;
            dgvMember.Columns[3].HeaderCell.Value = "Họ tên";
            dgvMember.Columns[4].HeaderCell.Value = "Giới tính";
            dgvMember.Columns[5].HeaderCell.Value = "Địa chỉ";
            dgvMember.Columns[6].HeaderCell.Value = "Số điện thoại";
            dgvMember.Columns[7].HeaderCell.Value = "Ngày bắt đầu thuê";
            
        }
        private void LoadMoneyTypes()
        {
            lvMoneyTypes.Items.Clear();
            /*lvMoneyTypes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);*/
            string[] row1 = { "Tiền phòng", roomDTO.RoomMoney + " (VNĐ/Phòng)" };
            string[] row2 = { "Tiền điện", roomDTO.ElectricMoney + " (VNĐ/Số)" };
            /*Theo đầu người
            Theo phòng
            Theo số công tơ
            Miễn phí*/
            string typeWater = "";
            switch (roomDTO.WaterMoneyType)
            {
                case "Theo đầu người":
                    typeWater = " (VNĐ/Người)";
                    break;
                case "Theo phòng":
                    typeWater = " (VNĐ/Phòng)";
                    break;
                case "Theo số công tơ":
                    typeWater = " (VNĐ/Số)";
                    break;
                case "Miễn phí":
                    typeWater = " (VNĐ)";
                    break;
            }
            string[] row3 = { "Tiền nước", roomDTO.WaterMoney + typeWater };
            /*Theo đầu người
            Theo phòng
            Miễn phí*/
            string typeNetword = "";
            switch (roomDTO.NetworkMoneyType)
            {
                case "Theo đầu người":
                    typeNetword = " (VNĐ/Người)";
                    break;
                case "Theo phòng":
                    typeNetword = " (VNĐ/Phòng)";
                    break;
                case "Miễn phí":
                    typeNetword = " (VNĐ)";
                    break;
            }
            string[] row4 = { "Tiền mạng", roomDTO.NetworkMoney + typeNetword };
            string[] row5 = { "Tiền khác", roomDTO.OtherMoney + " (VNĐ)" };
            string[] row6 = { "Số điện cuối tháng", roomDTO.LastElectricNumber + " (Số)" };
            string[] row7 = { "Số nước cuối tháng", roomDTO.LastWaterNumber + " (Số)" };
            lvMoneyTypes.Items.Add(new ListViewItem(row1));
            lvMoneyTypes.Items.Add(new ListViewItem(row2));
            lvMoneyTypes.Items.Add(new ListViewItem(row3));
            lvMoneyTypes.Items.Add(new ListViewItem(row4));
            lvMoneyTypes.Items.Add(new ListViewItem(row5));
            lvMoneyTypes.Items.Add(new ListViewItem(row6));
            lvMoneyTypes.Items.Add(new ListViewItem(row7));
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            var formRoomEdit = new FormRoomEdit(roomDTO.Id,roomDTO.HouseId,"EDIT");
            formRoomEdit.ShowDialog();
            FormRoomInfor_Load(sender,e);
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            UserDTO user = new UserDTO();
            user.Id = int.Parse(dgvMember.Rows[row].Cells["Id"].Value.ToString());
            user.FullName = dgvMember.Rows[row].Cells[3].Value.ToString();
            user.Address = dgvMember.Rows[row].Cells[5].Value.ToString();
            user.Gender = dgvMember.Rows[row].Cells[4].Value.ToString();
            user.Phone = dgvMember.Rows[row].Cells[6].Value.ToString();
            var formMemberEdit = new FormMemberEdit("EDIT",user.Id,user.FullName,
                user.Gender,user.Address,user.Phone);
            formMemberEdit.ShowDialog();
            FormRoomInfor_Load(sender, e);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            var formMemberEdit = new FormMemberEdit("ADD",roomDTO.Id);
            formMemberEdit.ShowDialog();
            FormRoomInfor_Load(sender, e);
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            var formCreateBill = new FormCreateBill(roomDTO.Id);
            formCreateBill.ShowDialog();
            FormRoomInfor_Load(sender, e);
        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int billId = int.Parse(dgvBill.Rows[row].Cells[0].Value.ToString());
            var formBillInfor = new FormBillInfor(billId);
            formBillInfor.ShowDialog();
            FormRoomInfor_Load(sender, e);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMember_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Thêm người thuê", btnAddMember);
        }

        private void btnUpdateBill_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Lập hóa đơn", btnUpdateBill);
        }

        private void btnUpdateRoom_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Cập nhật phòng", btnUpdateRoom);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }
    }
}
