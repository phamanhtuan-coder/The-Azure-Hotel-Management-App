using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
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
    public partial class ucBookingHistory : UserControl
    {
        public customMessageBox thongBao;
        DatPhongBLL DatPhongBLL = new DatPhongBLL();
        List<DatPhongDTO> dsPhong = new List<DatPhongDTO>();
        private frmMain _parentForm;
        public int maKH { set; get; }

        public ucBookingHistory()
        {
            InitializeComponent();
        }

       

        public ucBookingHistory(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }


        private void ucBooking_Load(object sender, EventArgs e)
        {
            LoadCombo();
            dgvBookingHistory.AutoGenerateColumns = false;
            colNgayDat.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayNhanPhong.DefaultCellStyle.Format = "dd/MM/yyyy";
            colNgayTraPhong.DefaultCellStyle.Format = "dd/MM/yyyy";
            LoadDsDatPhong();
            
        }
        private void LoadDsDatPhong()
        {
            dsPhong = DatPhongBLL.LayDSPhongTheoUser(maKH);
            dgvBookingHistory.DataSource = dsPhong;

        }

        private void LoadCombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortBookingID);
           
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucPersonal ucPersonal = new ucPersonal(parentForm);
            ucPersonal.user = parentForm.user;
            ucPersonal.userKH = parentForm.userKH;
            parentForm.SwitchUserControl(ucPersonal);
            this.Dispose();
        }

        private void dtpBookingDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            List<DatPhongDTO> dsLoc = new List<DatPhongDTO>();
            foreach (DatPhongDTO dp in dsPhong)
            {
                if (dp.NgayDatPhong.Date == (DateTime)dtpBookingDate.Value)
                {
                    dsLoc.Add(dp);
                }
            }
            dgvBookingHistory.DataSource = dsLoc;
        }

        private void dtpCheckInDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            List<DatPhongDTO> dsLoc = new List<DatPhongDTO>();
            foreach (DatPhongDTO dp in dsPhong)
            {
                if (dp.NgayNhanPhong?.Date == dtpCheckInDate.Value?.Date)
                {
                    dsLoc.Add(dp);
                }
            }
            dgvBookingHistory.DataSource = dsLoc;
        }

        private void dtpCheckOutDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            List<DatPhongDTO> dsLoc = new List<DatPhongDTO>();
            foreach (DatPhongDTO dp in dsPhong)
            {
                if (dp.NgayTraPhong?.Date == dtpCheckOutDate.Value?.Date)
                {
                    dsLoc.Add(dp);
                }
            }
            dgvBookingHistory.DataSource = dsLoc;
        }

    }
}
