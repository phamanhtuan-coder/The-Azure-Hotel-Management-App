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
    public partial class frmTinhTrangTB : Form
    {

        public bool isAdd { get; set; }
        public customMessageBox thongBao;
        public TTThietBiDTO tTThietBiDTO = new TTThietBiDTO();
        TTThietBiBLL tThietBiBLL = new TTThietBiBLL();
        public frmTinhTrangTB()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txtTenTrangThaiTB.Clear();
                rtxtMoTa.Clear();
            }
            else
            {
                txtTenTrangThaiTB.Text = tTThietBiDTO.TenTinhTrang;
                rtxtMoTa.Text = tTThietBiDTO.MoTa;
            }

        }

        private void laydltuform(TTThietBiDTO tb)
        {
            tb.TenTinhTrang = txtTenTrangThaiTB.Text;
            tb.MoTa = rtxtMoTa.Text;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            laydltuform(tTThietBiDTO);
            bool check;
            if (isAdd)
            {
                check = tThietBiBLL.themTTTBi(tTThietBiDTO);

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu phân quyền mới!");
                thongBao.ShowDialog();

            }
            else
            {
                check = tThietBiBLL.suaTTTBi(tTThietBiDTO);
                thongBao = new customMessageBox("Sửa thành công thông tin phân quyền đã chọn!");
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
