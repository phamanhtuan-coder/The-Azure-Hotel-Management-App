using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.UserControls
{
    public partial class ucDepartment : UserControl
    {
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        PhongBanDTO phongBanDTO = new PhongBanDTO();
        List<PhongBanDTO> dsPhongBan = new List<PhongBanDTO>();
        List<PhongBanDTO> dsTimKiem = new List<PhongBanDTO>();
        customMessageBox thongBao;

        public ucDepartment()
        {
            InitializeComponent();
        }

        private void ucDepartment_Load(object sender, EventArgs e)
        {
            LayDanhSachPhongBan();
            dgvDepartment.AutoGenerateColumns = false;
            CapDuLieuChoController();
        }

        private void CapDuLieuChoController()
        {
            DuLieuChoComboBox.duLieuSort(cboSortDepartment);
            DuLieuChoComboBox.duLieuSort(cboSortSoLuongNV);
            DuLieuChoComboBox.duLieuFilter(cboStateDepartment);
        }

        private void LayDanhSachPhongBan()
        {
            dsPhongBan = phongBanBLL.LayDanhSachPhongBan();
            dgvDepartment.DataSource = dsPhongBan;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvDepartment.ClearSelection();
            LayDanhSachPhongBan();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            // bổ sung kiểm tra dòng có đang được chọn chưa, nếu có dòng được chọn thì tiến hành xử lý, nếu không thì thông báo lỗi
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                frmPhongBan frm = new frmPhongBan();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này
                LayDuLieuTuForm(frm);
                //Kết thúc sửa từ đoạn này
                frm.ShowDialog();
                dgvDepartment.ClearSelection();
                LayDanhSachPhongBan();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn 1 dòng dữ liệu bạn muốn thay đổi!");
                thongBao.ShowDialog();
            }
        }

        private void LayDuLieuTuForm(frmPhongBan frm)
        {
            frm.phongBanDTO.MaPhongBan = dgvDepartment
                .SelectedRows[0]
                .Cells["colMaPhongBan"]
                .Value.ToString();
            frm.phongBanDTO.TenPhong = dgvDepartment
                .SelectedRows[0]
                .Cells["colTenPhong"]
                .Value.ToString();
            frm.phongBanDTO.TruongPhong = (int)
                dgvDepartment.SelectedRows[0].Cells["colTruongPhong"].Value;
            frm.phongBanDTO.NgayNhanChuc = DateTime.Parse(
                dgvDepartment.SelectedRows[0].Cells["colNgayNhanChuc"].Value.ToString()
            );
            frm.phongBanDTO.TrangThai = true;
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn xóa dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    String maPhongBan = dgvDepartment
                        .SelectedRows[0]
                        .Cells["colMaPhongBan"]
                        .Value.ToString();
                    bool check = PhongBanBLL.XoaPhongBan(maPhongBan);
                    if (check)
                    {
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu phòng ban có mã là: " + maPhongBan + "!"
                        );
                        dgvDepartment.ClearSelection();
                        LayDanhSachPhongBan();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu phòng ban có mã là: " + maPhongBan + "!"
                        );
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Hủy xóa!");
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverDepartment_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    String maPhongBan = dgvDepartment
                        .SelectedRows[0]
                        .Cells["colMaPhongBan"]
                        .Value.ToString();
                    bool check = PhongBanBLL.KhoiPhucPhongBan(maPhongBan);
                    if (check)
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu phòng ban có mã là: " + maPhongBan + "!"
                        );
                        dgvDepartment.ClearSelection();
                        LayDanhSachPhongBan();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu phòng ban có mã là: " + maPhongBan + "!"
                        );
                    }
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void cboStateDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsPhongBan = phongBanBLL.FilterTrangThai(cboStateDepartment.Text);
            dgvDepartment.ClearSelection();
            dgvDepartment.DataSource = dsPhongBan;
        }

        private void cboSortDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortDepartment.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    dsPhongBan = dsPhongBan.OrderByDescending(item => item.MaPhongBan).ToList();
                    break;
                default:
                    dsPhongBan = dsPhongBan.OrderBy(item => item.MaPhongBan).ToList();
                    break;
            }

            dgvDepartment.DataSource = dsPhongBan;
        }

        private void btnTraCuuDepartment_Click(object sender, EventArgs e)
        {
            dgvDepartment.DataSource = dsPhongBan;
            string searchKeyword = txtSearchDepartment.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
               dsTimKiem = phongBanBLL.TraCuuPhongBan(dsPhongBan, searchKeyword);
                
                dgvDepartment.DataSource = dsTimKiem;
                
            }
            else
            {
                LayDanhSachPhongBan();
            }
           
        }
    }
}
