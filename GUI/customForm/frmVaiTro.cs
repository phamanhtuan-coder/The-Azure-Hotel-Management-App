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
    public partial class frmVaiTro : Form
    {
       public string maVaiTro { get; set; }
       public string tenVaiTro { get; set; }

        public string moTa { get; set; }
        public bool isAdd { get; set; }

        public frmVaiTro()
        {
            InitializeComponent();
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            txtTenVT.Text = tenVaiTro;
            rtxtMoTa.Text = moTa;
            

        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                
                thongBao = new customMessageBox("Đã thêm thành công dữ liệu vai trò mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin vai trò đã chọn!");
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
