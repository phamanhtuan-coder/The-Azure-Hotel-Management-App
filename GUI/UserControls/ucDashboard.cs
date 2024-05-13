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
            LoadDanhGia();
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


        private void LoadDanhGia()
        {
            try
            {

                List<DanhGiaDTO> danhGiaMoiNhat= new List<DanhGiaDTO>();
                DanhGiaBLL danhGiaBLL = new DanhGiaBLL();
                danhGiaMoiNhat = danhGiaBLL.LayDanhGiaMoiNhat();
                int i = 0;
                foreach (var danhGia in danhGiaMoiNhat)
                {
                    Panel danhGiaPanel = TaoPanelDanhGia(danhGia);
                    danhGiaPanel.Dock = DockStyle.Top;
                    if (i == 0) 
                    {
                        danhGiaPanel.Margin = new Padding(5, 5, 0, 0);

                    }
                    flpRatings.Controls.Add(danhGiaPanel);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private Panel TaoPanelDanhGia(DanhGiaDTO danhGia)
        {
            Panel panelDanhGia = new Panel();
            panelDanhGia.BorderStyle = BorderStyle.FixedSingle;
            panelDanhGia.BackColor = Color.White;

            int parentPanelWidth = (flpRatings.ClientSize.Width / 2) - 10;
            panelDanhGia.Size = new Size(parentPanelWidth, 150);

            Label lblDiemSo = new Label();
            lblDiemSo.AutoSize = true;
            lblDiemSo.Location = new Point(10, 10);
            lblDiemSo.Font = new Font("Montserrat", 24, FontStyle.Bold);
            lblDiemSo.Text = danhGia.DiemDanhGia.ToString();
            if (danhGia.DiemDanhGia >= 4)
            {
                lblDiemSo.ForeColor = Color.Green;
            }
            else if (danhGia.DiemDanhGia >= 2)
            {
                lblDiemSo.ForeColor = Color.Yellow;
            }
            else if (danhGia.DiemDanhGia >= 1)
            {
                lblDiemSo.ForeColor = Color.Orange;
            }
            else
            {
                lblDiemSo.ForeColor = Color.Red;
            }
            panelDanhGia.Controls.Add(lblDiemSo);

            Label lblHoTenKH = new Label();
            lblHoTenKH.AutoSize = true;
            lblHoTenKH.Location = new Point(lblDiemSo.Right + 10, 10);
            lblHoTenKH.Font = new Font("Montserrat", 14, FontStyle.Bold);
            lblHoTenKH.Text = danhGia.HoTenKH;
            panelDanhGia.Controls.Add(lblHoTenKH);

            Label lblUsername = new Label();
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(lblDiemSo.Right + 10, lblHoTenKH.Bottom +2);
            lblUsername.Font = new Font("Montserrat", 12, FontStyle.Italic);
            lblUsername.Text = "@" + danhGia.TenDangNhap;
            panelDanhGia.Controls.Add(lblUsername);

            Panel panelTextBox = new Panel();
            panelTextBox.BackColor = Color.White;
            panelTextBox.BorderStyle = BorderStyle.None;
            panelTextBox.AutoScroll = true;
            panelTextBox.Dock = DockStyle.Bottom;
            panelTextBox.Height = 80;

            TextBox txtNhanXet = new TextBox();
            txtNhanXet.Multiline = true;
            txtNhanXet.ReadOnly = true;
            txtNhanXet.Enabled = false;
            txtNhanXet.BorderStyle = BorderStyle.None;
            txtNhanXet.BackColor = Color.White;
            txtNhanXet.Font = new Font("Montserrat", 13, FontStyle.Regular);
            txtNhanXet.Text = danhGia.NhanXet;
            txtNhanXet.ScrollBars = ScrollBars.Vertical;
            txtNhanXet.Dock = DockStyle.Fill;

            panelTextBox.Controls.Add(txtNhanXet);
            panelDanhGia.Controls.Add(panelTextBox);



            return panelDanhGia;
        }


    }
}
