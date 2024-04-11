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
    public partial class frmLoaiPhong : Form
    {
        public bool isAdd { get; set; }
        public customMessageBox thongBao;
        public loaiphongDTO loaiphong=new loaiphongDTO();
        loaiphongBLL loaiphongBLL = new loaiphongBLL();

        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            if (isAdd)
            {
                txtTenLP.Clear();
                rtxtMoTa.Clear();
            }
            else
            {
                txtTenLP.Text = loaiphong.TenLoai;
                rtxtMoTa.Text = loaiphong.Mota;
            }

        }
        private void laydltuform(loaiphongDTO lp)
        {
            lp.TenLoai = txtTenLP.Text;
            lp.Mota=rtxtMoTa.Text;
        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            laydltuform(loaiphong);
            bool check;
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                check = loaiphongBLL.themloaiphong(loaiphong);
                if (check)
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu loại phòng mới!");
                    thongBao.ShowDialog();
                }

            }
            else
            {
                // nếu không thì chạy lệnh update
                check = loaiphongBLL.sualoaiphong(loaiphong);
                if (check)
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin loại phòng đã chọn!");
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
