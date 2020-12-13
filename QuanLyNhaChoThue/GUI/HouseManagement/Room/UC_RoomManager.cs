using System;
using System.Windows.Forms;
using QuanLyNhaChoThue.BLL;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class UC_RoomManager : UserControl
    {
        /*HouseBLL houseBll = new HouseBLL();
        RoomBLL roomBll = new RoomBLL();*/
        public int houseId;
        public UC_RoomManager()
        {
            InitializeComponent();
        }

        private void UC_RoomManager_Load(object sender, EventArgs e)
        {
            LoadHouse();
            LoadListRoom();
        }
        private void LoadHouse()
        {
            HouseBLL houseBll = new HouseBLL();

            // load house
            dgvHouseInfor.DataSource = houseBll.findById(houseId);
            //houseId = int.Parse(dgvHouseInfor.Rows[0].Cells[0].Value.ToString());
            dgvHouseInfor.Columns["Id"].Visible = false;
            dgvHouseInfor.Columns["UserId"].Visible = false;
            dgvHouseInfor.Columns[1].HeaderCell.Value = "Tên nhà";
            dgvHouseInfor.Columns[2].HeaderCell.Value = "Địa chỉ";
            dgvHouseInfor.Columns[3].HeaderCell.Value = "Mô tả";
        }

        private void LoadListRoom()
        {
            RoomBLL roomBll = new RoomBLL();
            // load list room in house
            dgvRoom.DataSource = null;
            dgvRoom.DataSource = roomBll.findByHouseId(houseId);
            dgvRoom.Columns["Id"].Visible = false;
            dgvRoom.Columns["HouseId"].Visible = false;
            dgvRoom.Columns["ElectricMoney"].Visible = false;
            dgvRoom.Columns["WaterMoney"].Visible = false;
            dgvRoom.Columns["NetworkMoney"].Visible = false;
            dgvRoom.Columns["OtherMoney"].Visible = false;
            dgvRoom.Columns["NetworkMoneyType"].Visible = false;
            dgvRoom.Columns["WaterMoneyType"].Visible = false;
            dgvRoom.Columns["LastElectricNumber"].Visible = false;
            dgvRoom.Columns["LastWaterNumber"].Visible = false;

            dgvRoom.Columns[2].HeaderCell.Value = "Tên phòng";
            dgvRoom.Columns[3].HeaderCell.Value = "Tiền phòng";
            dgvRoom.Columns[12].HeaderCell.Value = "Người thuê";
            dgvRoom.Columns[13].HeaderCell.Value = "Mô tả";
            dgvRoom.Columns[14].HeaderCell.Value = "Trạng thái";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            var formRoomEdit = new FormRoomEdit(0, houseId, "ADD");
            formRoomEdit.ShowDialog();
            UC_RoomManager_Load(sender, e);
        }

        private void dgvRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int roomId = int.Parse(dgvRoom.Rows[row].Cells["Id"].Value.ToString());
            var formInforRoom = new FormRoomInfor(roomId);
            formInforRoom.ShowDialog();
        }

        private void dgvHouseInfor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = 0;
            string houseName = dgvHouseInfor.Rows[row].Cells[1].Value.ToString();
            string address = dgvHouseInfor.Rows[row].Cells[2].Value.ToString();
            string description = dgvHouseInfor.Rows[row].Cells[3].Value.ToString();
            var formHouseEdit = new FormHouseEdit("EDIT",houseId,houseName,address,description);
            formHouseEdit.ShowDialog();
            LoadListRoom();

        }
    }
}
