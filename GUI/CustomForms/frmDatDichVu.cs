using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI.customForm
{
    public partial class frmDatDichVu : Form
    {

        public bool isAdd { get; set; }
        public DatDichVuDTO DatDichVuDTO = new DatDichVuDTO();
        DatPhongBLL datPhongBLL = new DatPhongBLL();
        DatDichVuBLL datDichVuBLL = new DatDichVuBLL();
        List<DatPhongDTO> datPhongDTOs = new List<DatPhongDTO>();
        DichVuBLL DichVuBLL=new DichVuBLL();
        List<DichVuDTO> dichVuDTOs = new List<DichVuDTO>();
        public frmDatDichVu()
        {
            InitializeComponent();
        }

        private void frmDatDichVu_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị

            if (isAdd)
            {
                datPhongDTOs = datPhongBLL.laydsp2();
                cboMaDP.DataSource = datPhongDTOs;
                cboMaDP.ValueMember = "MaDatPhong";
                dichVuDTOs = DichVuBLL.laydsdvu();
                cboMaDV.DataSource=dichVuDTOs;
                cboMaDV.DisplayMember = "TenDV";
                cboMaDV.ValueMember = "MaDV";
                nudSoLuong.Value = nudSoLuong.Minimum;
                dtpNgayDat.Value = DateTime.Now;
            }
            else
            {
                datPhongDTOs = datPhongBLL.laydsp2();
                cboMaDP.DataSource = datPhongDTOs;
                cboMaDP.ValueMember = "MaDatPhong";
                cboMaDP.SelectedIndex = DatDichVuDTO.MaDatPhong-1;
                dichVuDTOs = DichVuBLL.laydsdvu();
                cboMaDV.DataSource = dichVuDTOs;
                cboMaDV.DisplayMember = "TenDV";
                cboMaDV.ValueMember = "MaDV";
                cboMaDV.SelectedIndex = DatDichVuDTO.MaDV-1;
                nudSoLuong.Value = DatDichVuDTO.SoLuong;
                dtpNgayDat.Value = DatDichVuDTO.NgayDat;
            }




        }
        private void laydltuform(DatDichVuDTO p)
        {
            
            p.MaDatPhong =int.Parse(cboMaDP.SelectedIndex + 1.ToString());
            p.MaDV =cboMaDV.SelectedIndex + 1;
            p.SoLuong = int.Parse(nudSoLuong.Text);
            p.NgayDat = dtpNgayDat.Value;

        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            laydltuform(DatDichVuDTO);
            bool check;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                check = datDichVuBLL.them(DatDichVuDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu đặt dịch vụ!");
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu đặt dịch vụ!");
                }
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                check = datDichVuBLL.sua(DatDichVuDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin đặt dịch vụ!");
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin đặt dịch vụ!");
                }
                thongBao.ShowDialog();
            }
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
