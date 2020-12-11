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

namespace QuanLyNhaChoThue.GUI.HouseManagement.Room
{
    public partial class FormCreateBill : Form
    {
        public FormCreateBill()
        {
            InitializeComponent();
        }

        private void FormCreateBill_Load(object sender, EventArgs e)
        {
            lblDateCreate.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
                MessageBox.Show("Số điện: " + billDTO.LastElectricNumber + "\n" + "Số nước: " + billDTO.LastWaterNumber);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Phải nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
