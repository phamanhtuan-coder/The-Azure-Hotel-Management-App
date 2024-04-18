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
    public partial class frmPhong : Form
    {
        


        public bool isAdd { get; set; }
        public customMessageBox thongBao;
        public PhongDTO PhongDTO = new PhongDTO();
        PhongBLL PhongBLL = new PhongBLL();
        List<LoaiPhongDTO> loaiPhongDTOs = new List<LoaiPhongDTO>();
        LoaiPhongBLL loaiPhongBLL = new LoaiPhongBLL();
        List<TinhTrangPhongDTO> tinhTrangPhongDTOs = new List<TinhTrangPhongDTO>();
        TinhTrangPhongBLL TinhTrangPhongBLL = new TinhTrangPhongBLL();
        
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                loaiPhongDTOs = loaiPhongBLL.laydslphong();
                cboLoaiPhong.DataSource=loaiPhongDTOs;
                cboLoaiPhong.DisplayMember = "TenLoai";
                cboLoaiPhong.ValueMember = "MaLoai";
                tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong();
                cboTinhTrangPhong.DataSource = tinhTrangPhongDTOs;
                cboTinhTrangPhong.DisplayMember = "TenTinhTrang";
                cboTinhTrangPhong.ValueMember = "MaTinhTrangPhong";
                rtxtMoTa.Clear();
            }
            else
            {
                loaiPhongDTOs = loaiPhongBLL.laydslphong();
                cboLoaiPhong.DataSource = loaiPhongDTOs;
                cboLoaiPhong.DisplayMember = "TenLoai";
                cboLoaiPhong.ValueMember = "MaLoai";
                tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong();
                cboTinhTrangPhong.DataSource = tinhTrangPhongDTOs;
                cboTinhTrangPhong.DisplayMember = "TenTinhTrang";
                cboTinhTrangPhong.ValueMember = "MaTinhTrangPhong";
                cboLoaiPhong.SelectedIndex = PhongDTO.MaLoai;
                cboTinhTrangPhong.SelectedIndex = PhongDTO.MaTinhTrangPhong;
                rtxtMoTa.Text = PhongDTO.MoTa;
            }





        }

        private void laydltuform(PhongDTO p)
        {
            p.MaLoai = cboLoaiPhong.SelectedIndex;
            p.MaTinhTrangPhong=cboTinhTrangPhong.SelectedIndex ;
            p.GiaPhong = nudGiaPhong.Value;
            p.SucChuaToiDa = (int)nudSucChuaToiDa.Value;
            p.MoTa= rtxtMoTa.Text ;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            laydltuform(PhongDTO);
            bool check;
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                check = PhongBLL.themp(PhongDTO);
                thongBao = new customMessageBox("Đã thêm thành công dữ liệu phòng mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                check = PhongBLL.suap(PhongDTO);
                thongBao = new customMessageBox("Sửa thành công thông tin phòng đã chọn!");
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
