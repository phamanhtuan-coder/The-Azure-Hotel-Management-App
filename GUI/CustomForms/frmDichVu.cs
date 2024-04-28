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
                txttendichvu.Text = DichVuDTO.TenDV;
                nudGia.Value = DichVuDTO.GiaDV;
            }




        }


        public void laydltuform(DichVuDTO dv)
        {
            dv.TenDV = txttendichvu.Text;
            dv.GiaDV = nudGia.Value;

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

       
    }
}
