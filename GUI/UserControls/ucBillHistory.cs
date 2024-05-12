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
    public partial class ucBillHistory : UserControl
    {
        public string MaPHQ { get; set; }
        private frmMain _parentForm;
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
        public int maKH { get; set; }
        public ucBillHistory()
        {
            InitializeComponent();
        }

        public ucBillHistory(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            dgvBillHistory.AutoGenerateColumns = false;
            LoadDuLieuKH();
            LoadDuLieuNV();
            LoadDuLieuThue();
            LoadDuLieuCombobox();
            TruyVanDanhSachHoaDon();
            dtpBillDate.MaxDateTime = DateTime.Now;
        }

        private void LoadDuLieuThue()
        {
            ThueBLL thueBLL = new ThueBLL();
            List<ThueDTO> list = thueBLL.TruyVanTenVaMaThue();
            colMaThue.DataSource = list;
            colMaThue.ValueMember = "MaThue";
            colMaThue.DisplayMember = "TenThue";
        }

        private void LoadDuLieuNV()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            List<NhanVienDTO> list = nhanVienBLL.TruyVanNVDAG();
            colMaNV.DataSource = list;
            colMaNV.DisplayMember = "HoTenNV";
            colMaNV.ValueMember = "MaNV";
        }

        private void LoadDuLieuKH()
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            List<KhachHangDTO> list = khachHangBLL.LoadIDvaNameKH();
            colMaKH.DataSource = list;
            colMaKH.DisplayMember = "HoTenKH";
            colMaKH.ValueMember = "MaKH";
        }

        private void TruyVanDanhSachHoaDon()
        {
            hoaDonDTOs = new List<HoaDonDTO>();
            hoaDonDTOs = hoaDonBLL.TruyVanDanhSachHoaDonTheoUser(maKH);
            dgvBillHistory.ClearSelection();
            dgvBillHistory.DataSource = hoaDonDTOs;
        }

        private void LoadDuLieuCombobox()
        {
            DuLieuChoComboBox.duLieuSort(cboSortBillID);
            DuLieuChoComboBox.duLieuSort(cboSortSumBill);
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

        private void btnTraCuuBill_Click(object sender, EventArgs e)
        {

        }

        private void cboSortBillID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortBillID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    hoaDonDTOs = hoaDonDTOs.OrderByDescending(item => item.MaHoaDon).ToList();
                    break;
                default:
                    hoaDonDTOs = hoaDonDTOs.OrderBy(item => item.MaHoaDon).ToList();
                    break;
            }

            dgvBillHistory.DataSource = hoaDonDTOs;
        }

        private void cboSortSumBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortSumBill.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    hoaDonDTOs = hoaDonDTOs.OrderByDescending(item => item.TongHoaDon).ToList();
                    break;
                default:
                    hoaDonDTOs = hoaDonDTOs.OrderBy(item => item.TongHoaDon).ToList();
                    break;
            }

            dgvBillHistory.DataSource = hoaDonDTOs;
        }

        private void dtpBillDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            List<HoaDonDTO> dsLoc = new List<HoaDonDTO>();
            foreach (HoaDonDTO hd in hoaDonDTOs)
            {
                if (hd.NgayLapHoaDon.Date == (DateTime) dtpBillDate.Value)
                {
                    dsLoc.Add(hd);
                }
            }
            dgvBillHistory.DataSource = dsLoc;
        }
    }
}
