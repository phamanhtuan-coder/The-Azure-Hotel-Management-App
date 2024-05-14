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
        //Khai báo biến
        public string MaPHQ { get; set; }
        PhongBanBLL phongBanBLL;
        PhongBanDTO phongBanDTO = new PhongBanDTO();
        List<PhongBanDTO> dsPhongBan = new List<PhongBanDTO>();
        List<PhongBanDTO> dsTimKiem = new List<PhongBanDTO>();
        customMessageBox thongBao;


        public ucDepartment()
        {
            InitializeComponent();
        }

        //Khi load Uc lên thì hiển thị gì
        private void ucDepartment_Load(object sender, EventArgs e)
        {
            LayDanhSachPhongBan();
            dgvDepartment.AutoGenerateColumns = false;
            colNgayNhanChuc.DefaultCellStyle.Format = "dd/MM/yyyy";
            CapDuLieuChoController();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddDepartment.Enabled = false;
                btnEditDepartment.Enabled = false;
                btnDeleteDepartment.Enabled = false;
                btnRecoverDepartment.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddDepartment.Enabled = true;
                btnEditDepartment.Enabled = true;
                btnDeleteDepartment.Enabled = false;
                btnRecoverDepartment.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddDepartment.Enabled = true;
                btnEditDepartment.Enabled = true;
                btnDeleteDepartment.Enabled = true;
                btnRecoverDepartment.Enabled = true;
            }


        }

        //Cáp dữ liệu cho các combo box
        private void CapDuLieuChoController()
        {
            //Gọi tới hàm cấp dữ liệu chung vì dữ liệu đa số giống nhau
            DuLieuChoComboBox.duLieuSort(cboSortDepartment);
            DuLieuChoComboBox.duLieuSort(cboSortSoLuongNV);
            DuLieuChoComboBox.duLieuFilter(cboStateDepartment);
        }

        //Lấy danh sách phòng ban và hiển thị lên DataGridView
        private void LayDanhSachPhongBan()
        {
            phongBanBLL = new PhongBanBLL();
            dsPhongBan = phongBanBLL.LayDanhSachPhongBan();
            dgvDepartment.DataSource = dsPhongBan;
        }

        //Khi bấm nút thêm
        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            //Set cho biến isAdd thành true để form biết đây là form thêm
            frm.isAdd = true;
            //Sau đó gọi form hiển thị lên để người dùng thay đổi thông tin
            frm.ShowDialog();
            //Sau khi xử lý xong thì load lại danh sách, hiện tại danh sách load lại sẽ là toàn bộ dữ liệu (sẽ sửa lại sau)
            dgvDepartment.ClearSelection();
            LayDanhSachPhongBan();
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            // bổ sung kiểm tra dòng có đang được chọn chưa, nếu có dòng được chọn thì tiến hành xử lý, nếu không thì thông báo lỗi
            if (dgvDepartment.SelectedRows.Count > 0)
            {
                frmPhongBan frm = new frmPhongBan();
                //Set cho biến isAdd thành false để form biết đây không phải form thêm
                frm.isAdd = false;
                
                //Vì không phải form thêm nên sẽ gọi tới hàm lấy dữ liệu từ dòng đang chọn truyền qua BUS xử lý
                LayDuLieuTuForm(frm);
                //Sau đó gọi form hiển thị lên để người dùng thay đổi thông tin
                frm.ShowDialog();
                //Sau khi xử lý xong thì load lại danh sách, hiện tại danh sách load lại sẽ là toàn bộ dữ liệu (sẽ sửa lại sau)
                dgvDepartment.ClearSelection();
                LayDanhSachPhongBan();
            }
            else
            {
                //Thông báo nếu không có dòng được chọn
                thongBao = new customMessageBox("Hãy chọn 1 dòng dữ liệu bạn muốn thay đổi!");
                thongBao.ShowDialog();
            }
        }

        private void LayDuLieuTuForm(frmPhongBan frm)
        {
            //Gán giá trị như bình thường
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
            //Vì form sẽ hiển thị cả trạng thái hoạt động và xóa nên phải check xem dòng đang chọn trạng thái là gì
            frm.phongBanDTO.TrangThai = Convert.ToBoolean(dgvDepartment.SelectedRows[0].Cells["colTrangThai"].Value) ;
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
                    phongBanBLL = new PhongBanBLL();
                    bool check = phongBanBLL.XoaPhongBan(maPhongBan);
                    if (check)
                    {
                        
                        dgvDepartment.ClearSelection();
                        LayDanhSachPhongBan();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + maPhongBan + "!"
                        );
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + maPhongBan + "!"
                        );
                        thongBao.ShowDialog();
                    }

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
                    phongBanBLL = new PhongBanBLL();
                    bool check = phongBanBLL.KhoiPhucPhongBan(maPhongBan);
                    if (check)
                    {
                        
                        dgvDepartment.ClearSelection();
                        LayDanhSachPhongBan();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + maPhongBan + "!"
                        );
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + maPhongBan + "!"
                        );
                        thongBao.ShowDialog();
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
