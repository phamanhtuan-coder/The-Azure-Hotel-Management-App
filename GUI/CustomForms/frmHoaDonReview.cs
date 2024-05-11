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

namespace GUI.CustomForms
{
    public partial class frmHoaDonReview : Form
    {
        private static string server = ".";
        private static string database = "UngDungQuanLyKhachSan";
        private static string connectionString =
            $"Data Source={server};Initial Catalog={database};Integrated Security=true;";
        public frmHoaDonReview()
        {
            InitializeComponent();
        }

        private void frmHoaDonReview_Load(object sender, EventArgs e)
        {

            LoadDuLieuChoReport();
            this.reportViewer1.RefreshReport();
        }

        private void LoadDuLieuChoReport()
        {
            DataSet dsCTHoaDon = GetDataFromDatabase(); // Instantiate the DataSet

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "GUI.rptCTHoaDon.rdlc";

            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
            reportDataSource.Name = "dsCTHoaDon";
            reportDataSource.Value = dsCTHoaDon.Tables["DatPhongDataTable"];
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        }

        private DataSet GetDataFromDatabase()
        {
            string maHD = "14";
            DataSet ds = new DataSet();
            string strFill = $"SELECT DP.MaDatPhong, DP.MaKH, DP.MaPHG, DP.NgayDatPhong, DP.NgayNhanPhong, DP.NgayTraPhong, DP.SoLuongKH, DP.TrangThai AS PhongTrangThai, P.GiaPhong, DV.* FROM DatPhong DP INNER JOIN Phong P ON DP.MaPHG = P.MaPHG LEFT JOIN DatDichVu DV ON DP.MaDatPhong = DV.MaDatPhong WHERE DP.MaDatPhong IN (SELECT MaDatPhong FROM HoaDon HD JOIN ChiTietHoaDon CT ON HD.MaHoaDon = CT.MaHD WHERE HD.MaHoaDon = {maHD});";
            SqlDataAdapter adapter = new SqlDataAdapter(strFill, connectionString);
            adapter.Fill(ds, "DatPhongDataTable");
            return ds;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
