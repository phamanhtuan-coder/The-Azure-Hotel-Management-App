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
    public partial class frmDatDichVu : Form
    {

        public bool isAdd { get; set; }

        public frmDatDichVu()
        {
            InitializeComponent();
        }

        private void frmDatDichVu_Load(object sender, EventArgs e)
        {
          // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
        


            
            

        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu đặt dịch vụ!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin đặt dịch vụ!");
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
