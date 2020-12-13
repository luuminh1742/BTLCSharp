using QuanLyNhaChoThue.BLL;
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

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room.Bill
{
    public partial class FormBillInfor : Form
    {
        private int billId;
        BillBLL billBll = new BillBLL();
        public FormBillInfor()
        {
            InitializeComponent();
        }
        public FormBillInfor(int billId)
        {
            InitializeComponent();
            this.billId = billId;
        }

        private void FormBillInfor_Load(object sender, EventArgs e)
        {
            LoadRoomMoney();


        }
        private void LoadRoomMoney()
        {
            BillDTO billDTO = billBll.FindById(billId);
            string[] row1 = { "Tiền phòng", billDTO.RoomMoney + " (VNĐ)" };
            string[] row2 = { "Tiền điện", billDTO.ElectricMoney + " (VNĐ)" };
            string[] row3 = { "Tiền nước", billDTO.WaterMoney +" (VNĐ)" };
            string[] row4 = { "Tiền mạng", billDTO.NetworkMoney + " (VNĐ)" };
            string[] row5 = { "Tiền khác", billDTO.OtherMoney + " (VNĐ)" };
            string[] row6 = { "Số điện cuối tháng", billDTO.LastElectricNumber + " (Số)" };
            string[] row7 = { "Số điện", billDTO.ElectricNumber + " (Số)" };
            string[] row8 = { "Số nước cuối tháng", billDTO.LastWaterNumber + " (Số)" };
            string[] row9 = { "Số nước", billDTO.WaterNumber + " (Số)" };
            string[] row10 = { "Tổng tiền", billDTO.TotalMoney + " (VNĐ)" };
            lvRoomMoney.Items.Add(new ListViewItem(row1));
            lvRoomMoney.Items.Add(new ListViewItem(row2));
            lvRoomMoney.Items.Add(new ListViewItem(row3));
            lvRoomMoney.Items.Add(new ListViewItem(row4));
            lvRoomMoney.Items.Add(new ListViewItem(row5));
            lvRoomMoney.Items.Add(new ListViewItem(row6));
            lvRoomMoney.Items.Add(new ListViewItem(row7));
            lvRoomMoney.Items.Add(new ListViewItem(row8));
            lvRoomMoney.Items.Add(new ListViewItem(row9));
            lvRoomMoney.Items.Add(new ListViewItem(row10));
            if (billDTO.Status)
            {
                lbStatus.Text = "Đã đóng tiền nhà";
            }
            else
            {
                lbStatus.Text = "Chưa đóng tiền nhà";
            }


        }
    }
}
