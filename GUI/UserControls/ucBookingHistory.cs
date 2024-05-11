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
            dgvBookingHistory.AutoGenerateColumns = false;
            LoadDsDatPhong();
            LoadCombo();
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

        private void dtpBookingDate_Click(object sender, EventArgs e)
        {
            List<DatPhongDTO> dsLoc = new List<DatPhongDTO>();
            foreach (DatPhongDTO dg in dsPhong)
            {
                if (dg.NgayDatPhong.Date == (DateTime) dtpBookingDate.Value)
                {
                    dsLoc.Add(dg);
                }
            }
            dgvBookingHistory.DataSource = dsLoc;
        }
    }
}
