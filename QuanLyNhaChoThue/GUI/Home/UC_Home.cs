using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyNhaChoThue.BLL;
using QuanLyNhaChoThue.DTO;
using QuanLyNhaChoThue.Utils;

namespace QuanLyNhaChoThue.GUI.Home
{
    public partial class UC_Home : UserControl
    {
        BillBLL billBll = new BillBLL();
        public UC_Home()
        {
            InitializeComponent();
        }
        public void fillChart()
        {
            foreach (var series in chartstatistic.Series)
            {
                series.Points.Clear();
            }
            chartstatistic.Titles.Clear();
            chartstatistic.Titles.Add("Thống kê trạng thái hóa đơn của từng tháng");
            List<ViewStatisticDTO> list = billBll.StatisticBill(FormLogin.userName);
            StatisticUtil statisticUtil = new StatisticUtil();
            try
            {
                var dataStatistic = statisticUtil.convert(list);
                if (dataStatistic == null) return;
                foreach (StatisticUtil item in dataStatistic)
                {
                    chartstatistic.Series["Đã thanh toán hóa đơn"].Points.AddXY(item.date, item.finished);
                    chartstatistic.Series["Chưa thanh toán hóa đơn"].Points.AddXY(item.date, item.unfinished);
                }
            }catch(Exception ex)
            {

            }
        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
