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


            if (isAdd)
            {
                txtMaKH.Clear();
                PhongDTOs = PhongBLL.laydsp();
                cboMaPHG.DataSource = PhongDTOs;
                cboMaPHG.DisplayMember = "MaPHG";
                cboMaPHG.ValueMember = "MaPHG";
                dtpNgayDat.Value = DateTime.Now;
                nudSoLuongKhach.Value = 1;
            }
            else
            {
                
                txtMaKH.Text =DatPhongDTO.MaKH.ToString();
                PhongDTOs = PhongBLL.laydsp();
                cboMaPHG.DataSource = PhongDTOs;
                cboMaPHG.DisplayMember = "MaPHG";
                cboMaPHG.ValueMember = "MaPHG";
                cboMaPHG.SelectedItem = DatPhongDTO.MaPHG;
                dtpNgayDat.Value = DatPhongDTO.NgayDatPhong;
                nudSoLuongKhach.Value = DatPhongDTO.SoLuongKH;
            }




        }
        private void laydltuform(DatPhongDTO p)
        {
            
            p.MaPHG = int.Parse(cboMaPHG.Text);
            p.MaKH =int.Parse(txtMaKH.Text);
            p.NgayDatPhong = dtpNgayDat.Value;
            p.SoLuongKH =(int)nudSoLuongKhach.Value;
            p.NgayNhanPhong =DateTime.Parse( DateTime.Now.ToString("dd/MM/yyyy"));
            p.NgayTraPhong =DateTime.Parse( DateTime.Now.ToString("dd/MM/yyyy"));

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            laydltuform(DatPhongDTO);
            bool check;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
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
                // nếu không thì chạy lệnh update
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
            taoKhachHang.ShowDialog();
        }
    }
}
