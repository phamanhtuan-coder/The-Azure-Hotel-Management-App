using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Net.Http.Headers;

namespace GUI.CustomForms
{
    public partial class frmHoaDonReview : Form
    {
        public List<ChiTietHoaDonDTO> hs;
        public string maHD { get; set; }
        public string maNV { get; set; }
        public string maKH { get; set; }
        public string ngayLap { get; set; }
        public frmHoaDonReview()
        {
            InitializeComponent();
        }

        private void frmHoaDonReview_Load(object sender, EventArgs e)
        {
            rpvCTHD.LocalReport.ReportEmbeddedResource = "GUI.rptCTHoaDon.rdlc";
            rpvCTHD.LocalReport.DataSources.Add(new ReportDataSource("dsCTHD", hs));
            
           

            rpvCTHD.LocalReport.SetParameters(new ReportParameter("paMaHD", maHD));
            rpvCTHD.LocalReport.SetParameters(new ReportParameter("paMaNV", maNV));
            rpvCTHD.LocalReport.SetParameters(new ReportParameter("paMaKH", maKH));
            rpvCTHD.LocalReport.SetParameters(new ReportParameter("paNgayLapHD", ngayLap));
            rpvCTHD.ZoomMode = ZoomMode.PageWidth;
            this.rpvCTHD.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDonReview_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                rpvCTHD.ZoomMode = ZoomMode.PageWidth;
            }
            else
            {
                rpvCTHD.ZoomMode = ZoomMode.FullPage;
            }
        }
    }
}
