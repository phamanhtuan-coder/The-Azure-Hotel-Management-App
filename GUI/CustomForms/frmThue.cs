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
    public partial class frmThue : Form
    {
        customMessageBox thongBao;

        public ThueDTO thueDTO = new ThueDTO();
        ThueBLL thueBLL = new ThueBLL();    
        
        public bool isAdd { get; set; }

        public frmThue()
        {
            InitializeComponent();
        }

        private void frmThue_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            if (!isAdd)
            {
               txtMucThue.Text = thueDTO.TenThue;
               nudMucThue.Value = (decimal) thueDTO.TyLeThue;
               rtxtMoTa.Text = thueDTO.MoTa;
            }
            else
            {
                txtMucThue.Text = "";
                nudMucThue.Value = 0;
                rtxtMoTa.Text = "";
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                GanDuLieu();
                // Nếu đúng là form Thêm thì chạy lệnh insert
                if (AddThue(thueDTO))
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu thuế mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu thuế mới!");
                    thongBao.ShowDialog();
                }

            }
            else
            {
                GanDuLieu();
                // nếu không thì chạy lệnh update
                if (EditThue(thueDTO))
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin thuế đã chọn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin thuế đã chọn!");
                    thongBao.ShowDialog();
                }
                
            }
            this.Close();           
        }
        private bool AddThue(ThueDTO thueDTO)
        {
            return thueBLL.AddThue(thueDTO);
        }
        private bool EditThue(ThueDTO thueDTO)
        {
            return thueBLL.EditThue(thueDTO);
        }
        private void GanDuLieu()
        {
            if (!string.IsNullOrEmpty(txtMucThue.Text))
            {
                thueDTO.TenThue = txtMucThue.Text;
            }

            if (nudMucThue.Value > 0)
            {
                thueDTO.TyLeThue = (double)nudMucThue.Value;
            }

            if (!string.IsNullOrEmpty(rtxtMoTa.Text))
            {
                thueDTO.MoTa = rtxtMoTa.Text;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
