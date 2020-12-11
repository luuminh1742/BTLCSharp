using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaChoThue.GUI.AccountSetting
{
    public partial class UC_ManageAccount : UserControl
    {
        public UC_ManageAccount()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var formPasswordEdit = new FormPasswordEdit();
            formPasswordEdit.ShowDialog();
        }

        private void btnUpdateInfor_Click(object sender, EventArgs e)
        {
            var formUpdateAccount = new FormUpdateAccount();
            formUpdateAccount.ShowDialog();
        }
    }
}
