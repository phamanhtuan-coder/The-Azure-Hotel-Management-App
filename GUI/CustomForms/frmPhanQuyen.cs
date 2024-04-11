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
    public partial class frmPhanQuyen : Form
    {
        RoleDTO roleDTO= new RoleDTO();
        RoleBLL roleBLL= new RoleBLL();

        public string MaPhanQuyen { get;set; }
        public bool isAdd { get; set; }
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            LoadVT();
            loadPB();
        }

        private void loadPB()
        {
            List<PhongBanDTO> list = roleBLL.LoadPBBLL();
            cboTenPhongBan.DataSource= list;
            cboTenPhongBan.DisplayMember = "TenPhong";
            cboTenPhongBan.ValueMember = "MaPhongBan";
        }

        private void LoadVT()
        {
            List<TenVT> list = roleBLL.LoadVTBLL();
            cboVaiTro.DataSource = list;
            cboVaiTro.DisplayMember = "TenVaiTro";
            cboVaiTro.ValueMember = "MaVaiTro";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                roleDTO.MaVaiTro = (int)cboVaiTro.SelectedValue;
                roleDTO.MaPhongBan = cboTenPhongBan.SelectedValue.ToString();
                roleDTO.MaPhanQuyen = roleDTO.MaPhongBan.ToString()+"-"+roleDTO.MaVaiTro.ToString("0#");

                if (roleBLL.AddRoleBLL(roleDTO))
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu phân quyền mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu phân quyền mới!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                roleDTO.MaPhanQuyen = MaPhanQuyen;
                roleDTO.MaVaiTro = (int)cboVaiTro.SelectedValue;
                roleDTO.MaPhongBan = cboTenPhongBan.SelectedValue.ToString();
                if (roleBLL.EditRoleBLL(roleDTO))
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin phân quyền đã chọn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thất bại thông tin phân quyền đã chọn!");
                    thongBao.ShowDialog();
                }
                
            }
            this.Close();
            
        }

        //private string maPB(string v)
        //{
        //    return roleBLL.maPBBLL(v);
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
