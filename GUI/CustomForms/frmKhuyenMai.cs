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

namespace GUI.customForm
{
    public partial class frmKhuyenMai : Form
    {
        customMessageBox thongBao;
        public bool isAdd { get; set; }

        KhuyenMaiBLL khuyenMaiBLL = new KhuyenMaiBLL();
        public KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO();

        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            LoadDuLieuHangThanhVien();
            if (!isAdd)
            {
                txtMucKM.Text = khuyenMaiDTO.TenKM;
                nudMucKM.Value = khuyenMaiDTO.KhuyenMai;

                foreach (HangThanhVienDTO item in cboHangTV.Items)
                {
                    if (item.MaLoaiHangThanhVien == khuyenMaiDTO.MaLoaiHangThanhVien)
                    {
                        cboHangTV.SelectedItem = item;
                    }
                }
            }
            else
            {
                txtMucKM.Text = "";
                nudMucKM.Value = 0;
                cboHangTV.SelectedIndex = 0;
            }
        }
        private void LoadDuLieuHangThanhVien()
        {
            HangThanhVienDTO TatCa = new HangThanhVienDTO();
            TatCa.MaLoaiHangThanhVien = -1;
            TatCa.TenHang = "Tất cả";
            List<HangThanhVienDTO> list = new List<HangThanhVienDTO> { TatCa };
            HangThanhVienBLL hangThanhVienBLL = new HangThanhVienBLL();
            foreach (var item in hangThanhVienBLL.LoadIDAndNameBLL())
            {
                list.Add(item);
            }
            cboHangTV.DataSource = list;
            cboHangTV.DisplayMember = "TenHang";
            cboHangTV.ValueMember = "MaLoaiHangThanhVien";
            cboHangTV.SelectedIndex = 0;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                if (AddKhuyenMai())
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu khuyến mãi mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu khuyến mãi mới!");
                    thongBao.ShowDialog();
                }             
            }
            else
            {
                // nếu không thì chạy lệnh update
                if (EditKhuyenMai())
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin khuyến mãi đã chọn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin khuyến mãi đã chọn!");
                    thongBao.ShowDialog();
                }                
            }
            this.Close();
            
        }      
        private void GanDuLieu()
        {
            khuyenMaiDTO.TenKM = txtMucKM.Text;
            khuyenMaiDTO.KhuyenMai = nudMucKM.Value;
            khuyenMaiDTO.MaLoaiHangThanhVien = (int) cboHangTV.SelectedValue;
        }
        private bool AddKhuyenMai()
        {
            return khuyenMaiBLL.AddKhuyenMai(khuyenMaiDTO);
        }
        private bool EditKhuyenMai()
        {
            return khuyenMaiBLL.EditKhuyenMai(khuyenMaiDTO);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
