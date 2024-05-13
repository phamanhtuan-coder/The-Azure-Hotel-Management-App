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
    public partial class frmTinhTrangPhong : Form
    {
        public bool isAdd { get; set; }
        public customMessageBox thongBao;
        public TinhTrangPhongDTO tinhTrang = new TinhTrangPhongDTO();
        TinhTrangPhongBLL tinhTrangPhongBLL = new TinhTrangPhongBLL();

        public frmTinhTrangPhong()
        {
            InitializeComponent();
        }

        private void frmTinhTrangPhong_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txtTenLP.Clear();
                rtxtMoTa.Clear();
            }
            else
            {
                txtTenLP.Text = tinhTrang.TenTinhTrang;
                rtxtMoTa.Text = tinhTrang.MoTa;
            }

        }
        private void laydltuform(TinhTrangPhongDTO lp)
        {
            if (!string.IsNullOrEmpty(txtTenLP.Text))
            {
                lp.TenTinhTrang = txtTenLP.Text;
            }

            lp.MoTa = rtxtMoTa.Text;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            laydltuform(tinhTrang);
            bool check;
            if (isAdd)
            {

                check = tinhTrangPhongBLL.themttphong(tinhTrang);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu tình trạng phòng mới!");
                    thongBao.ShowDialog();
                }

            }
            else
            {
                check = tinhTrangPhongBLL.suattphong(tinhTrang);
                if (check)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin tình trạng phòng đã chọn!");
                    thongBao.ShowDialog();
                }
            }
            this.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
