using BLL;
using DTO;
using GUI.UserControls;
using Syncfusion.GridHelperClasses;
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
        VaiTroBLL vaiTroBLL= new VaiTroBLL();
        VaiTroDTO vaiTroDTO = new VaiTroDTO();
        public bool isAdd { get; set; }
        public int MaVaiTroID { get; set; }
        public string TenVaiTro { get; set; }
        public string MoTa { get; set; }
        public frmVaiTro()
        {
            InitializeComponent();
        }

        private void frmVaiTro_Load(object sender, EventArgs e)
        {
            if (!isAdd)
            {
                txtTenVT.Text = TenVaiTro;
                rtxtMoTa.Text = MoTa;
            }
            else
            {
                txtTenVT.Text = "";
                rtxtMoTa.Text = "";
            }
        }

        private void EpDuLieu()
        {
            vaiTroDTO.TenVaiTro= txtTenVT.Text;
            vaiTroDTO.MoTa= rtxtMoTa.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa
            if (isAdd)
            {
                EpDuLieu();
                if (vaiTroBLL.AddVaiTroBLL(vaiTroDTO))
                {
                    thongBao = new customMessageBox("Đã thêm thành công dữ liệu vai trò mới!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Đã thêm thất bại dữ liệu vai trò mới!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                vaiTroDTO.MaVaiTro = MaVaiTroID;
                EpDuLieu();
                if (vaiTroBLL.EditVaiTroBLL(vaiTroDTO))
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin vai trò đã chọn!");
                    thongBao.ShowDialog();
                }
                else
                {
                    thongBao = new customMessageBox("Sửa thành công thông tin vai trò đã chọn!");
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
