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
    public partial class frmPhongBan : Form
    {
        public string maPhongBan { get; set; }
        public string tenPhongBan { get; set; }
        public string truongPhong  { get; set; }
        public DateTime ngayNhanChuc { get; set; }
        public bool isTruongPhong { get; set; }
        public bool isAdd { get; set; }

        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            grpThongTinTruongPhong.ForeColor = Color.White;
            grpThongTinTruongPhong.Enabled = false;
            txtTenPB.Text = tenPhongBan;
            if (isTruongPhong == true)
            {
                chkTruongPhong.Checked = true;
            }
            if (chkTruongPhong.Checked == true)
            {
                grpThongTinTruongPhong.Enabled = true;
                txtTruongPhong.Text = truongPhong;
                dtpNgayNhanChuc.Value = ngayNhanChuc;

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
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu phòng ban mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin phòng ban đã chọn!");
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
