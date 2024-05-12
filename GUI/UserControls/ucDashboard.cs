using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucDashboard : UserControl
    {
        DatPhongBLL datPhongBLL = new DatPhongBLL();
        public ucDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            LoadChart();
        }

        private void LoadChart()
        {
            ChartBLL chartBLL = new ChartBLL();
            List<ChartDTO> list = chartBLL.LoadChart();
            list.Reverse();
            foreach (ChartDTO chartDTO in list)
            {
                chartThongKe.Series["Tiền đặt phòng"].Points.AddXY(chartDTO.Ngay.ToString("dd/MM/yyyy"), chartDTO.TongGiaPhong);
                chartThongKe.Series["Tiền đặt dịch vụ"].Points.AddXY(chartDTO.Ngay.ToString("dd/MM/yyyy"), chartDTO.TongGiaDichVu);
            }
        }

        private void LoadDuLieu()
        {
            int kq = datPhongBLL.loadDuKienCount();
            if (kq > 0)
            {
                lblDuKienCount.Text = kq.ToString();
            }
            else lblDuKienCount.Text = "0";
            int kq1 = datPhongBLL.SoLuongCheckin();
            if (kq1 > 0)
            {
                lblCountCheckIn.Text = kq1.ToString();
            }
            else lblCountCheckIn.Text = "0";
            int kq2 = datPhongBLL.SoLuongCheckOut();
            if (kq2 > 0)
            {
                lblCountCheckOut.Text = kq2.ToString();
            }
            else lblCountCheckOut.Text = "0";
            int kq3 = datPhongBLL.SoLuongHuy();
            if (kq3 > 0)
            {
                lblCountTotal.Text = kq3.ToString();
            }
            else lblCountCheckOut.Text = "0";
        }
    }
}
