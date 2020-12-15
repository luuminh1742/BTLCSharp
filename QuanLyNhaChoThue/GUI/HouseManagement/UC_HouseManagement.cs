using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.GUI.HouseManagement.Room;

namespace QuanLyNhaChoThue.GUI.HouseManagement
{
    public partial class UC_HouseManagement : UserControl
    {
        HouseBLL houseBll = new HouseBLL();
        List<HouseDTO> listHouse = new List<HouseDTO>();
        public UC_HouseManagement()
        {
            InitializeComponent();
        }

        private void pctAddHouse_Click(object sender, EventArgs e)
        {
            
        }

        private void UC_HouseManagement_Load(object sender, EventArgs e)
        {
            lvHouse.Clear();
            listHouse = houseBll.findAll();
            foreach (HouseDTO houseDTO in listHouse)
            {
                lvHouse.Items.Add(houseDTO.Name+"\n"+houseDTO.Address,0);
            }
           
        }

        public static int houseId = 0;
        private void ShowFormRoom()
        {
            var formRoom = new FormRoom(houseId);
            formRoom.houseId = houseId;
            formRoom.ShowDialog();
            
        }
        private void lvHouse_DoubleClick(object sender, EventArgs e)
        {
            var firstSelectedItem = lvHouse.SelectedItems[0];
            int indexHouseSelected = firstSelectedItem.Index;
            houseId = listHouse[indexHouseSelected].Id;
            Thread thread = new Thread(new ThreadStart(ShowFormRoom)); //Tạo luồng mới
            thread.Start(); //Khởi chạy luồng
            FormMain.formMain.Close();

        }

        private void lvHouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            var formEditHouse = new FormHouseEdit("ADD", 0, "", "", "");
            formEditHouse.ShowDialog();
            UC_HouseManagement_Load(sender, e);
        }
    }
}
