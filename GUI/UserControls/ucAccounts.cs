using BLL;
using DTO;
using GUI.customForm;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ucAccounts : UserControl
    {
        VaiTroBLL vaiTroBLL= new VaiTroBLL();
        List<VaiTroDTO> vaiTroDTOs= new List<VaiTroDTO>();
        public ucAccounts()
        {
            InitializeComponent();
        }

        private void ucAccounts_Load(object sender, EventArgs e)
        {
            CapNhatDuLieuCBO();
        }

        private void CapNhatDuLieuCBO()
        {
            DuLieuChoComboBox.duLieuSort(cboSortAccountsID);
            DuLieuChoComboBox.duLieuFilter(cboStateAccounts);
            LoadVaiTro();
        }

        private void LoadVaiTro()
        {
            VaiTroDTO tatca = new VaiTroDTO();
            tatca.MaVaiTro = -1;
            tatca.TenVaiTro = "Tất cả";
            vaiTroDTOs.Add(tatca);
            List<VaiTroDTO> tam = vaiTroBLL.LoadIDAndNameBLL();
            foreach (VaiTroDTO item in tam)
            {
                vaiTroDTOs.Add(item);
            }
            cboPhanQuyen.DataSource=vaiTroDTOs;
            cboPhanQuyen.DisplayMember = "TenVaiTro";
            cboPhanQuyen.ValueMember = "MaVaiTro";
            cboPhanQuyen.SelectedIndex = 0;
        }

        private void btnAddAccounts_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditAccounts_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                frmTaiKhoan frm = new frmTaiKhoan();
                frm.isAdd = false;

                //Bắt đầu sửa từ đoạn này
                


                //Kết thúc sửa từ đoạn này
                frm.ShowDialog();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
          
        }

        private void btnDeleteAccounts_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Xóa 
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }

        }

        private void btnRecoverAccounts_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Khôi phục
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }
    }
}
