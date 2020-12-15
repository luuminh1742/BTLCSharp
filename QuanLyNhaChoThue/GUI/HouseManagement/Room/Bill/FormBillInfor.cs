using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
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
        BillDTO billDTO = new BillDTO();
        RoomBLL roomBLL = new RoomBLL();
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
            billDTO = billBll.FindById(billId);
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
            chkStatus.Checked = billDTO.Status;
            if (billDTO.Status)
            {
                chkStatus.Text = "Đã đóng tiền nhà";
                chkStatus.Enabled = false;
            }
            else
            {
                chkStatus.Text = "Chưa đóng tiền nhà";
            }
            lbCreateDate.Text = billDTO.CreatedDate.ToString();
            lbCreateBy.Text = billDTO.ModifiedBy;
            RoomDTO roomDTO = roomBLL.findOne(billDTO.RoomId);
            lbRoomName.Text = roomDTO.RoomName;
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkStatus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận phòng đã đóng tiền!", "Thông báo",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (billBll.UpdateStatus(billDTO.Id))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chkStatus.Checked = true;
                    chkStatus.Text = "Đã đóng tiền nhà";
                    chkStatus.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog(); //Khởi tạo đối tượng PrintDialog
            dlg.ShowDialog(); //Hiển thị hộp thoại PrintDialog
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MovePanel.MouseDown(this);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Red;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.White;
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            btnCancel.BackColor = Color.White;
        }
    }
}
