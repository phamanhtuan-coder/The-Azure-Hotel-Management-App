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
using BLL;
using Utilities;
namespace GUI.customForm
{
    public partial class frmPhongBan : Form
    {
        public PhongBanDTO phongBanDTO = new PhongBanDTO();
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        public bool isAdd { get; set; }

        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txtMaPhongBan.Clear();
                txtMaPhongBan.Enabled = true;
                txtTenPB.Clear();
                txtTruongPhong.Clear();
                chkTruongPhong.Checked = false;
                dtpNgayNhanChuc.Value = DateTime.Now;
            }
            else
            {
                txtMaPhongBan.Text = phongBanDTO.MaPhongBan;
                txtMaPhongBan.Enabled = false;
                txtTenPB.Text = phongBanDTO.TenPhong;
                if (phongBanDTO.TruongPhong != 0 )
                {
                    chkTruongPhong.Checked = true;
                    txtTruongPhong.Text = phongBanDTO.TruongPhong.ToString();
                    dtpNgayNhanChuc.Value = phongBanDTO.NgayNhanChuc; 
                }
                else
                {
                    chkTruongPhong.Checked = false;
                }
               
            }


        }

        private void chkTruongPhong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTruongPhong.Checked == true)
            {
                grpThongTinTruongPhong.Enabled = true;

            }
            else
            {
                grpThongTinTruongPhong.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;

            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban

            LayDuLieuTuForm(phongBanDTO);
            bool check;
            if (isAdd)
            {
                check = phongBanBLL.ThemPhongBanMoi(phongBanDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công phòng ban mới!");
                   
                }
                else
                {
                    thongBao = new customMessageBox("Thêm thất bại, vui lòng kiểm tra lại!");
                    
                }
               

            }
            else
            {
                
                check = phongBanBLL.SuaPhongBan(phongBanDTO);
                if (check)
                {
                    thongBao = new customMessageBox("Đã sửa thành công phòng ban mới!");
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại, vui lòng kiểm tra lại!");
                }
               
            }

            thongBao.ShowDialog();
            this.Close();
            
        }

        private void LayDuLieuTuForm(PhongBanDTO phongBanDTO)
        {
            string tenPhongBan = txtTenPB.Text,maPhongBan = txtMaPhongBan.Text; 
            tenPhongBan = KiemTraInput.ChuanHoaHoTen(tenPhongBan);
            maPhongBan = KiemTraInput.ChuanHoaMaPhongBan(maPhongBan);
            phongBanDTO.MaPhongBan = maPhongBan;
            phongBanDTO.TenPhong = tenPhongBan;
            if (chkTruongPhong.Checked == true)
            {
                phongBanDTO.TruongPhong = int.Parse(txtTruongPhong.Text);
                phongBanDTO.NgayNhanChuc = dtpNgayNhanChuc.Value;

            }
            else
            {
                grpThongTinTruongPhong.Enabled = false;
                phongBanDTO.TruongPhong = null;
                phongBanDTO.NgayNhanChuc = DateTime.Now;
            }
            phongBanDTO.TrangThai = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaPhongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (txtMaPhongBan.Text.Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
