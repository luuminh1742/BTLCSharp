using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;
using System;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormCreateBill : Form
    {
        BillBLL billBll = new BillBLL();
        private int roomId;
        public FormCreateBill()
        {
            InitializeComponent();
        }
        public FormCreateBill(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
        }

        private void FormCreateBill_Load(object sender, EventArgs e)
        {
            lblDateCreate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                int lastWater = int.Parse(txtLastWater.Text);
                int lastElectric = int.Parse(txtLastElectric.Text);
                BillDTO billDTO = new BillDTO();
                billDTO.LastElectricNumber = lastElectric;
                billDTO.LastWaterNumber = lastWater;
                billDTO.RoomId = roomId;
                if (billBll.Insert(billDTO))
                {
                    MessageBox.Show("Tạo hóa đơn thành công", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo hóa đơn thất bại", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phải nhập số", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            MoveItem.MouseDown(this);
        }
    }
}
