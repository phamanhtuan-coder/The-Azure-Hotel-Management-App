using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.UserControls
{
    public partial class ucStaff : UserControl
    {
        int PhanQuyen;
        string PhongBan;
        string GioiTinh;
        int NguoiQuanLy;
        string tt;
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
        List<PhongBanDTO> phongBanDTOs = new List<PhongBanDTO>();
        List<NhanVienDTO> dsNV = new List<NhanVienDTO>();
        List<NhanVienDTO> dsSearch = new List<NhanVienDTO>();
        List<VaiTroDTO> vaiTroDTOs = new List<VaiTroDTO>();
        public string MaPHQ { get; set; }
        public ucStaff()
        {
            InitializeComponent();
        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            CapNhatCBBNhanVien();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddStaff.Enabled = false;
                btnEditStaff.Enabled = false;
                btnDeleteStaff.Enabled = false;
                btnRecoverStaff.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddStaff.Enabled = true;
                btnEditStaff.Enabled = true;
                btnDeleteStaff.Enabled = false;
                btnRecoverStaff.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddStaff.Enabled = true;
                btnEditStaff.Enabled = true;
                btnDeleteStaff.Enabled = true;
                btnRecoverStaff.Enabled = true;
            }


        }

        private void LoadDSNhanVien()
        {
            nhanVienDTOs = new List<NhanVienDTO>();
            nhanVienDTOs = nhanVienBLL.Filer(PhanQuyen, PhongBan, GioiTinh, NguoiQuanLy, tt);
            dgvStaff.ClearSelection();
            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void loadNQL()
        {
            nhanVienDTOs = new List<NhanVienDTO>();
            NhanVienDTO TatCa= new NhanVienDTO();
            TatCa.MaNV = -1;
            TatCa.HoTenNV = "Tất cả";
            nhanVienDTOs.Add(TatCa);
            List<NhanVienDTO> tam= nhanVienBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                nhanVienDTOs.Add(item);
            }
            cboNguoiQuanLy.DataSource = nhanVienDTOs;
            cboNguoiQuanLy.DisplayMember = "HoTenNV";
            cboNguoiQuanLy.ValueMember= "MaNV";
            cboNguoiQuanLy.SelectedIndex = 0;
        }

        private void LoadPhong()
        {
            PhongBanBLL phongBanBLL = new PhongBanBLL();
            PhongBanDTO TatCa= new PhongBanDTO();
            TatCa.MaPhongBan = "00";
            TatCa.TenPhong = "Tất cả";
            phongBanDTOs.Add(TatCa);
            List<PhongBanDTO> tam= phongBanBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                phongBanDTOs.Add(item);
            }
            cboPhongBan.DataSource = phongBanDTOs;
            cboPhongBan.DisplayMember = "TenPhong";
            cboPhongBan.ValueMember = "MaPhongBan";
        }

        private void LoadVaiTro()
        {
            VaiTroBLL vaiTroBLL = new VaiTroBLL();
            VaiTroDTO TatCa = new VaiTroDTO();
            TatCa.MaVaiTro = -1;
            TatCa.TenVaiTro = "Tất cả";
            vaiTroDTOs.Add(TatCa);
            List<VaiTroDTO> tam= vaiTroBLL.LoadIDAndNameBLL();
            foreach (var item in tam)
            {
                vaiTroDTOs.Add(item);
            }
            cboPhanQuyen.DataSource = vaiTroDTOs;
            cboPhanQuyen.DisplayMember= "TenVaiTro";
            cboPhanQuyen.ValueMember= "MaVaiTro";
        }

        private void CapNhatCBBNhanVien()
        {
            LoadVaiTro();
            LoadPhong();
            loadNQL();
            DuLieuChoComboBox.duLieuSort(cboSortStaffID);
            DuLieuChoComboBox.duLieuFilter(cboStateAccounts);
            List<string> sortOptions = new List<string>
            {
                "Tất cả",
                "Nam",
                "Nữ"
            };
            cboGioiTinh.DataSource = sortOptions;
            cboGioiTinh.SelectedIndex = 0;
            if (cboPhongBan.SelectedIndex != 0 && cboPhanQuyen.SelectedIndex != 0)
            {
                cboPhongBan.SelectedIndex = 0;
                cboPhanQuyen.SelectedIndex = 0;
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.isAdd = true;
            frm.ShowDialog();
            loadNQL();
            LoadDSNhanVien();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này
                int MaNV = dgvStaff.Columns["ID"].Index;
                int HoTen = dgvStaff.Columns["HoTen"].Index;
                int CCCD = dgvStaff.Columns["CCCD"].Index;
                int GioiTinh = dgvStaff.Columns["colGioiTinh"].Index;
                int NgaySinh = dgvStaff.Columns["NgaySinh"].Index;
                int Email = dgvStaff.Columns["Email"].Index;
                int SDT = dgvStaff.Columns["SDT"].Index;
                int DiaChi = dgvStaff.Columns["DiaChi"].Index ;
                int username = dgvStaff.Columns["colTTK"].Index;
                int MaNQL = dgvStaff.Columns["MaNQL"].Index;
                int Luong = dgvStaff.Columns["Luong"].Index;
                int columnIndex = dgvStaff.Columns["HinhAnh"].Index;

                frm.nv.MaNV = (int) dgvStaff.SelectedRows[0].Cells[MaNV].Value;
                object cellValue = dgvStaff.SelectedRows[0].Cells[columnIndex].Value;
                if (cellValue != null)
                {
                    frm.nv.HinhAnh = (byte[])dgvStaff.SelectedRows[0].Cells[columnIndex].Value;
                }
                
                frm.nv.HoTenNV= dgvStaff.SelectedRows[0].Cells[HoTen].Value.ToString();
                frm.nv.CCCD= dgvStaff.SelectedRows[0].Cells[CCCD].Value.ToString();
                frm.nv.GioiTinh = dgvStaff.SelectedRows[0].Cells[GioiTinh].Value.ToString();
                frm.nv.NgaySinh = (DateTime) dgvStaff.SelectedRows[0].Cells[NgaySinh].Value;
                frm.nv.Email = dgvStaff.SelectedRows[0].Cells[Email].Value.ToString();
                frm.nv.SDT = dgvStaff.SelectedRows[0].Cells[SDT].Value.ToString();
                frm.nv.DiaChi = dgvStaff.SelectedRows[0].Cells[DiaChi].Value.ToString();
                frm.nv.TenTaiKhoan = (string) dgvStaff.SelectedRows[0].Cells[username].Value;
                frm.nv.MaNQL = (int?) dgvStaff.SelectedRows[0].Cells[MaNQL].Value;
                frm.nv.Luong = (decimal) dgvStaff.SelectedRows[0].Cells[Luong].Value;
                //Kết thúc đoạn được sửa
                frm.ShowDialog();
                loadNQL();
                LoadDSNhanVien();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvStaff.Columns["TrangThai"].Index;
                if ((bool)dgvStaff.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        if (XoaNhanVien())
                        {
                            loadNQL();
                            LoadDSNhanVien();
                            thongBao = new customMessageBox("Xóa thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Xóa thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Bạn không thể xóa nhân viên đã xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private bool XoaNhanVien()
        {
            if (dgvStaff.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                int vitriMaNV = dgvStaff.Columns["ID"].Index;
                int  MaNV= (int)dgvStaff.SelectedRows[0].Cells[vitriMaNV].Value;
                return nhanVienBLL.XoaNhanVienBLL(MaNV);
            }
            else
            {
                return false;
            }
        }

        private void btnRecoverStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                customMessageBox thongBao;
                int TrangThai = dgvStaff.Columns["TrangThai"].Index;
                if (!(bool)dgvStaff.SelectedRows[0].Cells[TrangThai].Value)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        if (KhoiPhucNhanVien())
                        {
                            loadNQL();
                            LoadDSNhanVien();
                            thongBao = new customMessageBox("Khôi phục thành công dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Khôi phục thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {                   
                    thongBao = new customMessageBox("Bạn không thể khôi phục nhân viên khi chưa xóa!");
                    thongBao.ShowDialog();                   
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private bool KhoiPhucNhanVien()
        {
            if (dgvStaff.SelectedRows.Count > 0)//  Sửa điều kiện đoạn này
            {
                frmNhanVien frm = new frmNhanVien();
                int vitriMaNV = dgvStaff.Columns["ID"].Index;
                int MaNV = (int)dgvStaff.SelectedRows[0].Cells[vitriMaNV].Value;
                return nhanVienBLL.KhoiPhucNhanVienBLL(MaNV);
            }
            else
            {
                return false;
            }
        }

        private void cboStateAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            tt =cboStateAccounts.SelectedValue.ToString();
            LoadDSNhanVien();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            GioiTinh = cboGioiTinh.Text;
            LoadDSNhanVien();
        }

        private void cboNguoiQuanLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            NguoiQuanLy = (int) cboNguoiQuanLy.SelectedValue;
            LoadDSNhanVien();
        }

        private void cboPhanQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            PhanQuyen = (int)cboPhanQuyen.SelectedValue;
            LoadDSNhanVien();
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            picAvata.Image = null;
            PhongBan = cboPhongBan.SelectedValue.ToString();
            LoadDSNhanVien();
        }

        private void cboSortAccountTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortStaffID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    nhanVienDTOs = nhanVienDTOs.OrderByDescending(item => item.MaTaiKhoan).ToList();
                    break;
                default:
                    nhanVienDTOs = nhanVienDTOs.OrderBy(item => item.MaTaiKhoan).ToList();
                    break;
            }

            dgvStaff.DataSource = nhanVienDTOs;
        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string columnName = "HinhAnh";
                int columnIndex = dgvStaff.Columns[columnName].Index;
                object cellValue = dgvStaff.SelectedRows[0].Cells[columnIndex].Value;

                if (cellValue != null)
                {
                    byte[] hinh = (byte[])cellValue;
                    picAvata.Image = ByteArrayToImage(hinh);
                }
                else
                {
                    picAvata.Image = null;
                }
            }
        }
        private static byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(byte[] hinh)
        {
            using (MemoryStream m = new MemoryStream(hinh))
            {
                return Image.FromStream(m);
            }
        }

        private void btnTraCuuStaff_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = nhanVienDTOs;
            string searchKeyword = txtSearchStaff.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = nhanVienBLL.TraCuuNhanVien(nhanVienDTOs, searchKeyword);
                dgvStaff.DataSource = dsSearch;

            }
            else
            {
                LoadDSNhanVien();
            }
        }
    }
}
