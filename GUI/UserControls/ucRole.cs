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
    public partial class ucRole : UserControl
    {
        List<RoleDTO> dsRole = new List<RoleDTO> ();
        List<RoleDTO> dsSearch = new List<RoleDTO>();
        RoleBLL roleBLL = new RoleBLL ();
        customMessageBox thongBao;
        public string MaPHQ { get; set; }
        public ucRole()
        {
            InitializeComponent();
        }


        private void ucRole_Load(object sender, EventArgs e)
        {
            CapDuLieuChoController();
            loadRole();
            KiemTraPQ();
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddRole.Enabled = false;
                btnDeleteRole.Enabled = false;
                btnRecoverRole.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddRole.Enabled = true;
                btnDeleteRole.Enabled = false;
                btnRecoverRole.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddRole.Enabled = true;
                btnDeleteRole.Enabled = true;
                btnRecoverRole.Enabled = true;
            }


        }
        private void CapDuLieuChoController()
        {
            //Gọi tới hàm cấp dữ liệu chung vì dữ liệu đa số giống nhau
            DuLieuChoComboBox.duLieuSort(cboSortRole);
            DuLieuChoComboBox.duLieuFilter(cboStateRole);
        }

        private void loadRole()
        {
            dsRole = roleBLL.FilterTrangThai(cboStateRole.Text);
            dgvRole.ClearSelection();
            dgvRole.DataSource = dsRole;
        }
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            frmPhanQuyen frm = new frmPhanQuyen();
            frm.isAdd = true;
            frm.ShowDialog();
            loadRole();
        }
        private void btnEditRole_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count > 0)
            {
                frmPhanQuyen frm = new frmPhanQuyen();
                frm.isAdd = false;
                // Bắt đầu phần có thể chỉnh sửa
                frm.MaPhanQuyen = dgvRole.SelectedRows[0].ToString();
                // kết thúc phần có thể chỉnh sửa
                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }
        //Xóa role
        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count > 0)
            {
                bool result = (bool)dgvRole.SelectedCells[7].Value;
                if (result)
                {
                    thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        string MPQ = dgvRole.SelectedCells[0].Value.ToString();
                        if (DeleteRoleGUI(MPQ))
                        {
                            thongBao = new customMessageBox("Xóa thành công dòng dữ liệu đã chọn!");
                            loadRole();
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Xóa thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    thongBao = new customMessageBox("Các giá trị bạn chọn đã xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }
        private bool DeleteRoleGUI(string pq)
        {
            return roleBLL.DeleteRoleBLL(pq);
        }
        //Khôi phục role
        private void btnRecoverRole_Click(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count > 0)
            {
                bool result = (bool)dgvRole.SelectedCells[7].Value;
                if (!result)
                {
                    customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                    DialogResult dr = thongBao.ShowDialog();
                    if (dr != DialogResult.Cancel)
                    {
                        string MPQ = dgvRole.SelectedCells[0].Value.ToString();
                        if (RestoreRoleGUI(MPQ))
                        {
                            thongBao = new customMessageBox("Khôi phục thành công dòng dữ liệu đã chọn!");
                            loadRole();
                            thongBao.ShowDialog();
                        }
                        else
                        {
                            thongBao = new customMessageBox("Khối phục thất bại dòng dữ liệu đã chọn!");
                            thongBao.ShowDialog();
                        }
                    }
                }
                else
                {
                    customMessageBox thongBao = new customMessageBox("Giá trị bạn chọn chưa xóa!");
                    thongBao.ShowDialog();
                }
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phúc!");
                thongBao.ShowDialog();
            }
        }

        private bool RestoreRoleGUI(string mPQ)
        {
            return roleBLL.RestoreRoleBLL(mPQ);
        }

        private void dgvRole_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRole.SelectedRows.Count > 0)
            {
                frmPhanQuyen frm = new frmPhanQuyen();
                frm.MaPhanQuyen= dgvRole.SelectedCells[0].ToString();
            }
        }

        private void cboStateRole_SelectedIndexChanged(object sender, EventArgs e)
        {

            dsRole = roleBLL.FilterTrangThai(cboStateRole.Text);
            dgvRole.ClearSelection();
            dgvRole.DataSource = dsRole;
        }

        private void cboSortRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRole.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    dsRole = dsRole.OrderByDescending(item => item.MaPhongBan).ToList();
                    break;
                default:
                    dsRole = dsRole.OrderBy(item => item.MaPhongBan).ToList();
                    break;
            }

            dgvRole.DataSource = dsRole;
        }

       

        private void btnTraCuuRole_Click(object sender, EventArgs e)
        {
            dgvRole.DataSource = dsRole;
            string searchKeyword = txtSearchRole.Text.Trim().ToLower();
            if (searchKeyword.Count() > 0)
            {
                dsSearch = roleBLL.TraCuuPhongBan(dsRole, searchKeyword);

                dgvRole.DataSource = dsSearch;

            }
            else
            {
                loadRole();
            }
        }

    }
}
