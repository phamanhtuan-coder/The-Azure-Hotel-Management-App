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
    public partial class frmDanhGia : Form
    {
      customMessageBox thongBao;
        public bool isAdd { get; set; }

        public frmDanhGia()
        {
            InitializeComponent();
        }

        private void frmDanhGia_Load(object sender, EventArgs e)
        { 
            
            

        }

      

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa 
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                
                thongBao = new customMessageBox("Đã thêm thành công dữ liệu đánh giá mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin đánh giá đã chọn!");
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
