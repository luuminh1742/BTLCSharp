using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.HouseManagement
{
    public partial class UC_HouseManagement : UserControl
    {
        public UC_HouseManagement()
        {
            InitializeComponent();
        }

        private void pctAddHouse_Click(object sender, EventArgs e)
        {
            var formEditHouse = new FormHouseEdit();
            formEditHouse.ShowDialog();
        }
    }
}
