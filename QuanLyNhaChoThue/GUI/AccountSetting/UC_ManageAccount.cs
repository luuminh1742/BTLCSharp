using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;

namespace QuanLyNhaChoThue.GUI.AccountSetting
{
    public partial class UC_ManageAccount : UserControl
    {
        UserBLL userBll = new UserBLL();
        UserDTO user = new UserDTO();
        string userName = FormLogin.userName;
        public UC_ManageAccount()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var formPasswordEdit = new FormPasswordEdit(user.Id);
            formPasswordEdit.ShowDialog();
        }

        private void btnUpdateInfor_Click(object sender, EventArgs e)
        {
            var formUpdateAccount = new FormUpdateAccount
                (user.Id,user.UserName, user.FullName, user.Gender, user.Address, user.Phone);
            formUpdateAccount.ShowDialog();
            loadForm(FormUpdateAccount.username);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadForm(string username)
        {
            try
            {
                user = userBll.FindOne(userName);
                lbUserName.Text = user.UserName;
                lbFullName.Text = user.FullName;
                lbGender.Text = user.Gender;
                lbPhone.Text = user.Phone;
                lbAddress.Text = user.Address;
            }
            catch (Exception ex)
            {

            }
        }


        private void UC_ManageAccount_Load(object sender, EventArgs e)
        {

            loadForm(userName);
        }
    }
}
