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
    public partial class frmHangThanhVien : Form
    {
       public string maHang { get; set; }
        public string tenhang { get; set; }
        public double mucChietKhau { get; set; }

        public bool isAdd { get; set; }

        public frmHangThanhVien()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenHang.Text = tenhang;
            nudChietKhau.Value = (Decimal)mucChietKhau;
            

        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu hạng thành viên mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin hạng thành viên đã chọn!");
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
