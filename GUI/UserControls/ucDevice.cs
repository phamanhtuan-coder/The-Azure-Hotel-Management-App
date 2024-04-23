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
using DTO;
using BLL;
namespace GUI.UserControls
{
    public partial class ucDevice : UserControl
    {
        public customMessageBox thongBao;
        public frmThietBi frm=new frmThietBi();
        ThietBiBLL ThietBiBLL = new ThietBiBLL();
        List<ThietBiDTO> ThietBiDTOs=new List<ThietBiDTO>();
        List<ThietBiDTO> ThietBiDTOstk=new List<ThietBiDTO>();

        public ucDevice()
        {
            InitializeComponent();
        }


        private void ucDevice_Load(object sender, EventArgs e)
        {
            dgvDevice.AutoGenerateColumns = false;
            Loadcombo();
            Loadds();

        }

        private void Loadds()
        {
            ThietBiDTOs = ThietBiBLL.laydstbi();
            dgvDevice.DataSource = ThietBiDTOs;
        }

        private void Loadcombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortDeviceID);
            DuLieuChoComboBox.duLieuSort(cboLocTheoTinhTrang);
            DuLieuChoComboBox.duLieuFilter(cboStateDeviceStatus);
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            frmThietBi frm = new frmThietBi();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvDevice.ClearSelection();
            Loadds();
        }
        public void laydutuform(frmThietBi frm)
        {
            frm.thietBiDTO.MaThietBi =(int)dgvDevice.SelectedRows[0].Cells["MaThietBi"].Value;
            frm.thietBiDTO.TenThietBi =dgvDevice.SelectedRows[0].Cells["TenThietBi"].Value.ToString();
            frm.thietBiDTO.MaTinhTrangThietBi=(int)dgvDevice.SelectedRows[0].Cells["MaTinhTrangThietBi"].Value;
        }
        private void btnEditDevice_Click(object sender, EventArgs e)
        {

            // bổ sung kiểm tra dòng có đang được chọn chưa, nếu có dòng được chọn thì tiến hành xử lý, nếu không thì thông báo lỗi
            if (dgvDevice.SelectedRows.Count > 0)
            {
                frmThietBi frm = new frmThietBi();
                frm.isAdd = false;
                //Bắt đầu sửa từ đoạn này
                laydutuform(frm);
                frm.ShowDialog();
                dgvDevice.ClearSelection();
                Loadds();
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn 1 dòng dữ liệu bạn muốn thay đổi!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteDevice_Click(object sender, EventArgs e)
        {
            if (dgvDevice.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn xóa dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int matbi = (int)dgvDevice.SelectedRows[0].Cells["MaThietBi"].Value;
                    bool check = ThietBiBLL.Xoatbi(matbi);
                    if (check)
                    {

                        dgvDevice.ClearSelection();
                        Loadds();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + matbi + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + matbi + "!"
                        );
                    }
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn xóa!");
                thongBao.ShowDialog();
            }
        }

        private void btnRecoverDevice_Click(object sender, EventArgs e)
        {
            if (dgvDevice.SelectedRows.Count > 0)
            {
                customMessageBox thongBao = new customMessageBox("Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?");
                DialogResult dr = thongBao.ShowDialog();
                if (dr != DialogResult.Cancel)
                {
                    int matbi = (int)dgvDevice.SelectedRows[0].Cells["MaThietBi"].Value;
                    bool check = ThietBiBLL.KhoiPhucttp(matbi);
                    if (check)
                    {

                        dgvDevice.ClearSelection();
                        Loadds();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + matbi + "!"
                        );
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + matbi + "!"
                        );
                    }
                }
            }
            else
            {
                customMessageBox thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
        }

        private void btnTraCuuDevice_Click(object sender, EventArgs e)
        {
            ThietBiDTOs = ThietBiBLL.laydstbi();
            dgvDevice.DataSource = ThietBiBLL;
            string searchKeyword = txtSearchDevice.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                ThietBiDTOstk = ThietBiBLL.TraCuutbi(ThietBiDTOs, searchKeyword);

                dgvDevice.DataSource = ThietBiDTOstk;

            }
            else
            {
                Loadds();
            }
        }

        private void cboStateDeviceStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThietBiDTOs = ThietBiBLL.FilterTrangThai(cboStateDeviceStatus.Text);
            dgvDevice.ClearSelection();
            dgvDevice.DataSource = ThietBiDTOs;
        }

        private void cboSortDeviceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortDeviceID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    ThietBiDTOs = ThietBiDTOs.OrderByDescending(item => item.MaThietBi).ToList();
                    break;
                default:
                    ThietBiDTOs = ThietBiDTOs.OrderBy(item => item.MaThietBi).ToList();
                    break;
            }

            dgvDevice.DataSource = ThietBiDTOs;
        }
    }
}
