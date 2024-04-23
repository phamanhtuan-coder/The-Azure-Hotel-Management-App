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
    public partial class frmThietBi : Form
    {
        public string maPhanQuyen { get; set; }
        public string tenVaiTro { get; set; }
        public string tenPhongBan { get; set; }

        public string moTa { get; set; }

        public bool isAdd { get; set; }
        public customMessageBox thongBao;
        public ThietBiDTO thietBiDTO = new ThietBiDTO();
        ThietBiBLL thietBiBLL = new ThietBiBLL();
        TTThietBiBLL tThietBiBLL=new TTThietBiBLL();
        List<TTThietBiDTO> tttb=new List<TTThietBiDTO>();
        public frmThietBi()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            if (isAdd)
            {
                txttenthietbi.Clear();
                tttb = tThietBiBLL.laydsTBi2();
                cboTrangThai.DataSource = tttb;
                cboTrangThai.DisplayMember = "TenTinhTrang";
                cboTrangThai.ValueMember = "MaTinhTrangThietBi";
                rtxtMoTa.Clear();
                rtxtMoTa.Clear();
            }
            else
            {
                txttenthietbi.Text = thietBiDTO.TenThietBi;
                tttb = tThietBiBLL.laydsTBi2();
                cboTrangThai.DataSource = tttb;
                cboTrangThai.DisplayMember = "TenTinhTrang";
                cboTrangThai.ValueMember = "MaTinhTrangThietBi";
                cboTrangThai.SelectedIndex = thietBiDTO.MaTinhTrangThietBi-1;
            }

        }
        public void laydltuform(ThietBiDTO tb)
        {
            tb.TenThietBi = txttenthietbi.Text;
            tb.MaTinhTrangThietBi = cboTrangThai.SelectedIndex+1 ;
            
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            laydltuform(thietBiDTO);
            bool check;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert
                check = thietBiBLL.themtbi(thietBiDTO);
                thongBao = new customMessageBox("Đã thêm thành công dữ liệu thiết bị mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                check = thietBiBLL.suatbi(thietBiDTO);
                thongBao = new customMessageBox("Sửa thành công thông tin thiết bị đã chọn!");
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
