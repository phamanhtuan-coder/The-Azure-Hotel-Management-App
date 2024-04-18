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
using BLL;
using DTO;

namespace GUI.UserControls
{
    public partial class ucRoom : UserControl
    {
        public customMessageBox thongBao;
        frmPhong frm = new frmPhong();
        PhongBLL PhongBLL=new PhongBLL();
        List<PhongDTO> phongDTOs = new List<PhongDTO>();
        List<PhongDTO> phongDTOstk = new List<PhongDTO>();
        List<LoaiPhongDTO> loaiPhongDTOs = new List<LoaiPhongDTO>();
        LoaiPhongBLL loaiPhongBLL = new LoaiPhongBLL();
        List<TinhTrangPhongDTO> tinhTrangPhongDTOs = new List<TinhTrangPhongDTO>();
        TinhTrangPhongBLL TinhTrangPhongBLL = new TinhTrangPhongBLL();

        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            layds();
            dgvRoom.AutoGenerateColumns = false;
            laycombo();

        }

        private void layds()
        {
            phongDTOs = PhongBLL.laydsp();
            dgvRoom.DataSource = phongDTOs;
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomID);
            DuLieuChoComboBox.duLieuSort(cboSortPrice);
            DuLieuChoComboBox.duLieuFilter(cboStateRoom);

            tinhTrangPhongDTOs = TinhTrangPhongBLL.laydsttphong();
            cboRoomStatus.DataSource = tinhTrangPhongDTOs;
            cboRoomStatus.DisplayMember = "TenTinhTrang";
            cboRoomStatus.ValueMember = "MaTinhTrangPhong";
            loaiPhongDTOs = loaiPhongBLL.laydslphong();
            cboSortRoomType.DataSource = loaiPhongDTOs;
            cboSortRoomType.DisplayMember = "TenLoai";
            cboSortRoomType.ValueMember = "MaLoai";
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frmPhong frm = new frmPhong();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvRoom.ClearSelection();
            layds();
        }
        private void LayDuLieuTuForm(frmPhong frm)
        {
            //Gán giá trị như bình thường
            frm.PhongDTO.MaPHG=(int)dgvRoom.SelectedRows[0].Cells["colMaPHG"].Value;
            frm.PhongDTO.MaLoai = (int)dgvRoom.SelectedRows[0].Cells["colMaLoai"].Value;
            frm.PhongDTO.MaTinhTrangPhong = (int)dgvRoom.SelectedRows[0].Cells["colMaTinhTrangPhong"].Value;
            frm.PhongDTO.GiaPhong = (decimal)dgvRoom.SelectedRows[0].Cells["colGiaPhong"].Value;
            frm.PhongDTO.SucChuaToiDa = (int)dgvRoom.SelectedRows[0].Cells["colSucChuaToiDa"].Value;
            frm.PhongDTO.MoTa = dgvRoom.SelectedRows[0].Cells["colMoTa"].Value.ToString();
            frm.PhongDTO.TrangThai = Convert.ToBoolean(dgvRoom.SelectedRows[0].Cells["colTrangThai"].Value);
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {


                frmPhong frm = new frmPhong();
                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvRoom.ClearSelection();
                layds();


                frm.ShowDialog();
            }
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn chỉnh sửa!");
                thongBao.ShowDialog();
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
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

        private void btnRecoverRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
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

        
    }
}
