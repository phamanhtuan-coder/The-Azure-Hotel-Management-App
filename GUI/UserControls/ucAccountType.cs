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
    public partial class ucAccountType : UserControl
    {
        VaiTroBLL vaiTroBLL= new VaiTroBLL();
        List<VaiTroDTO> vaiTroDTOs = new List<VaiTroDTO>();
        frmVaiTro frm = new frmVaiTro();
        customMessageBox thongBao;
        public ucAccountType()
        {
            InitializeComponent();
        }

        private void ucAccountType_Load(object sender, EventArgs e)
        {
        }

        private void loadDSRole()
        {
            vaiTroDTOs = vaiTroBLL.LoadDSRoleBLL();
            dgvAccountType.DataSource=vaiTroDTOs;
        }

        private void loadDSRoleTT(int i)
        {
            vaiTroDTOs = vaiTroBLL.LoadDSRoleTTBLL(i);
            dgvAccountType.DataSource = vaiTroDTOs;
        }

        private void btnAddAccountType_Click(object sender, EventArgs e)
        {
            frm.isAdd = true;
            frm.ShowDialog();
        }

        private void btnEditAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
               
                frm.isAdd = false;

               

                //kết thúc sửa 
                frm.ShowDialog();
            }
            else
            {
                 thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }

           
        }

        private void btnDeleteAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Xóa 
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }

            
        }

        private void btnRecoverAccountType_Click(object sender, EventArgs e)
        {
            if (dgvAccountType.SelectedRows.Count > 0)
            {
                thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    // Khôi phục
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void lblAccountType_Click(object sender, EventArgs e)
        {

        }
    }
}
