using BLL;
using DTO;
using Syncfusion.XlsIO.Implementation.XmlSerialization;
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
                tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong3();
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
                tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong3();
                cboTinhTrangPhong.DataSource = tinhTrangPhongDTOs;
                cboTinhTrangPhong.DisplayMember = "TenTinhTrang";
                cboTinhTrangPhong.ValueMember = "MaTinhTrangPhong";
                cboLoaiPhong.SelectedIndex = PhongDTO.MaLoai;
                cboTinhTrangPhong.SelectedIndex = PhongDTO.MaTinhTrangPhong;
                rtxtMoTa.Text = PhongDTO.MoTa;
                if (PhongDTO.HinhAnh != null)
                {
                    picHinhPhong.Image = ByteArrayToImage(PhongDTO.HinhAnh);
                }

            }





        }

        private void laydltuform(PhongDTO p)
        {
            p.MaLoai = (int) cboLoaiPhong.SelectedValue;
            p.MaTinhTrangPhong=(int) cboTinhTrangPhong.SelectedValue;
            p.GiaPhong = nudGiaPhong.Value;
            p.SucChuaToiDa = (int)nudSucChuaToiDa.Value;
            p.MoTa= rtxtMoTa.Text ;
            p.HinhAnh = ImageToByteArray(picHinhPhong.Image);
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

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picHinhPhong.Image = Image.FromFile(open.FileName);
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

        private void picHinhPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
