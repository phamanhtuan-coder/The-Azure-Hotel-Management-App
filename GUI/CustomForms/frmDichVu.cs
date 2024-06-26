﻿using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.customForm
{
    public partial class frmDichVu : Form
    {
        


        public bool isAdd { get; set; }
        public customMessageBox thongBao;
        DichVuBLL DichVuBLL = new DichVuBLL();
        public DichVuDTO DichVuDTO = new DichVuDTO();
        List<DichVuDTO> dichVuDTOs = new List<DichVuDTO>();
        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên
            if (isAdd)
            {
                txttendichvu.Clear();
                nudGia.Value = 0;
            }
            else
            {
                if (DichVuDTO.HinhAnh != null)
                {
                    picHinhAnh.Image = ByteArrayToImage(DichVuDTO.HinhAnh);
                }
                
                txttendichvu.Text = DichVuDTO.TenDV;
                nudGia.Value = DichVuDTO.GiaDV;
            }
        }


        public void laydltuform(DichVuDTO dv)
        {
            if (picHinhAnh.Image != null)
            {
                dv.HinhAnh = ImageToByteArray(picHinhAnh.Image);
            }

            if (txttendichvu.Text.Trim().Length > 0)
            {
                dv.TenDV = txttendichvu.Text;
            }     

            if (nudGia.Value > 0)
            {
                dv.GiaDV = nudGia.Value;
            }

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            laydltuform(DichVuDTO);
            bool check;

            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                check = DichVuBLL.themdvu(DichVuDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu dịch vụ mới!");
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu dịch vụ mới!");
                }
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                check = DichVuBLL.suadvu(DichVuDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin dịch vụ đã chọn!");
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin dịch vụ đã chọn!");
                }
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
                picHinhAnh.Image = Image.FromFile(open.FileName);
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
    }
}
