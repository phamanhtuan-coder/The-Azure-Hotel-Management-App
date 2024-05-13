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
    public partial class frmDatPhong : Form
    {

        public bool isAdd { get; set; }
        public DatPhongDTO DatPhongDTO = new DatPhongDTO();
        DatPhongBLL DatPhongBLL = new DatPhongBLL();
        List<PhongDTO> PhongDTOs = new List<PhongDTO>();
        PhongBLL PhongBLL = new PhongBLL();
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị


            dtpNgayDat.MinDate = DateTime.Now;
            if (isAdd)
            {
                txtMaKH.Clear();
                dtpNgayDat.Value = dtpNgayDat.MinDate;
                LoadDSPhong();
                nudSoLuongKhach.Value = 1;
            }
            else
            {
                txtMaKH.Text =DatPhongDTO.MaKH.ToString();
                LoadDSPhong();
                cboMaPHG.SelectedItem = DatPhongDTO.MaPHG;
                nudSoLuongKhach.Value = DatPhongDTO.SoLuongKH;
            }

        }

        private void LoadDSPhong()
        {
            PhongDTOs = PhongBLL.LayDsPhongDaSanSang(dtpNgayDat.Value);
            cboMaPHG.DataSource = PhongDTOs;
            cboMaPHG.DisplayMember = "MaPHG";
            cboMaPHG.ValueMember = "MaPHG";
        }

        private void laydltuform(DatPhongDTO p)
        {
            
            p.MaPHG = int.Parse(cboMaPHG.Text);
            p.MaKH =int.Parse(txtMaKH.Text);
            p.NgayDatPhong = dtpNgayDat.Value;
            p.SoLuongKH =(int)nudSoLuongKhach.Value;

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            laydltuform(DatPhongDTO);
            bool check;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                if (string.IsNullOrWhiteSpace( txtMaKH.Text.Trim() ) )
                {
                    thongBao = new customMessageBox("Mã Khách hàng không được bỏ trống");
                    thongBao.ShowDialog();
                    return;
                }

                check = DatPhongBLL.them(DatPhongDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu đặt phòng mới!");
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu đặt phòng mới!");
                }

                thongBao.ShowDialog();

            }
            else
            {
                
                check = DatPhongBLL.sua(DatPhongDTO);
                if(check)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin đặt phòng đã chọn!");
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin đặt phòng đã chọn!");
                }

                thongBao.ShowDialog();
            }
            this.Close();
            
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            frmKhachHang taoKhachHang = new frmKhachHang();
            taoKhachHang.isAdd = true;
            taoKhachHang.ShowDialog();
        }

        private void dtpNgayDat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
