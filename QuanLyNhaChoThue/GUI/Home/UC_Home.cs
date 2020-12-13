using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        private void fillChart()
        {
            /*chartstatistic.Series["Đã thanh toán hóa đơn"].Points.AddXY("10-2020", "10");
            chartstatistic.Series["Chưa thanh toán hóa đơn"].Points.AddXY("10-2020", "0");

            chartstatistic.Series["Đã thanh toán hóa đơn"].Points.AddXY("11-2020", "7");
            chartstatistic.Series["Chưa thanh toán hóa đơn"].Points.AddXY("11-2020", "3");
            chartstatistic.Titles.Add("Thống kê trạng thái hóa đơn của từng tháng");*/
            //chart1.Series[0].ChartType = SeriesChartType.Pie;

            List<ViewStatisticDTO> list = billBll.StatisticBill(FormLogin.userName);
            StatisticUtil statisticUtil = new StatisticUtil();
            try
            {
                var dataStatistic = statisticUtil.convert(list);

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
