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
using Syncfusion.XPS;
using System.IO;

namespace GUI.UserControls
{
    public partial class ucRoom : UserControl
    {
        int LoaiPhong = -1;
        int TTPhong = -1;
        string trangthai = "Tất cả";
        public customMessageBox thongBao;
        frmPhong frm = new frmPhong();
        PhongBLL PhongBLL=new PhongBLL();
        List<PhongDTO> phongDTOs = new List<PhongDTO>();
        List<PhongDTO> phongDTOstk = new List<PhongDTO>();
        List<LoaiPhongDTO> loaiPhongDTOs = new List<LoaiPhongDTO>();
        LoaiPhongBLL loaiPhongBLL = new LoaiPhongBLL();
        List<TinhTrangPhongDTO> tinhTrangPhongDTOs = new List<TinhTrangPhongDTO>();
        TinhTrangPhongBLL TinhTrangPhongBLL = new TinhTrangPhongBLL();
        public string MaPHQ { get; set; }

        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            LoadTenLoai();
            LoadTenTT();
            layds();
            dgvRoom.AutoGenerateColumns = false;
            colGiaPhong.DefaultCellStyle.Format = "#,##0";
            colGiaPhong.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            laycombo();
            KiemTraPQ();
        }

           
        private void LoadTenTT()
        {
            List<TinhTrangPhongDTO> tam = TinhTrangPhongBLL.laydsttphong();
            colMaTinhTrangPhong.DataSource = tam;
            colMaTinhTrangPhong.DisplayMember = "TenTinhTrang";
            colMaTinhTrangPhong.ValueMember = "MaTinhTrangPhong";
        }
        private void KiemTraPQ()
        {
            if (MaPHQ.Contains("01"))
            {

                btnAddRoom.Enabled = false;
                btnEditRoom.Enabled = false;
                btnDeleteRoom.Enabled = false;
                btnRecoverRoom.Enabled = false;
            }
            else if (MaPHQ.Contains("03"))
            {
                btnAddRoom.Enabled = true;
                btnEditRoom.Enabled = true;
                btnDeleteRoom.Enabled = false;
                btnRecoverRoom.Enabled = false;
            }
            else if (MaPHQ.Contains("04") || (MaPHQ.Contains("02")))
            {
                btnAddRoom.Enabled = true;
                btnEditRoom.Enabled = true;
                btnDeleteRoom.Enabled = true;
                btnRecoverRoom.Enabled = true;
            }


        }
        private void LoadTenLoai()
        {
            List<LoaiPhongDTO> tam = loaiPhongBLL.laydslphong();
            colMaLoai.DataSource = tam;
            colMaLoai.DisplayMember = "TenLoai";
            colMaLoai.ValueMember = "MaLoai";
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
            LoadcboTTPhong();
            LoadcboLoaiPhong();
        }

        private void LoadcboLoaiPhong()
        {
            List<LoaiPhongDTO> tam = loaiPhongBLL.laydslphong();
            List<LoaiPhongDTO> list = new List<LoaiPhongDTO> ();
            LoaiPhongDTO loai = new LoaiPhongDTO();
            loai.MaLoai = -1;
            loai.TenLoai = "None";
            list.Add( loai );
            foreach(LoaiPhongDTO item in tam)
            {
                list.Add (item);
            }
            cboSortRoomType.DataSource = list;
            cboSortRoomType.DisplayMember = "TenLoai";
            cboSortRoomType.ValueMember = "MaLoai";
            cboSortRoomType.SelectedIndex = 0;    
            
        }

        private void LoadcboTTPhong()
        {
            List<TinhTrangPhongDTO> tam = TinhTrangPhongBLL.laydsttphong();
            List<TinhTrangPhongDTO> list = new List<TinhTrangPhongDTO>();
            TinhTrangPhongDTO tinhTrang = new TinhTrangPhongDTO();
            tinhTrang.TenTinhTrang = "None";
            tinhTrang.MaTinhTrangPhong = -1;
            list.Add(tinhTrang);
            foreach(TinhTrangPhongDTO item in tam)
            {
                list.Add(item);
            }
            cboRoomStatus.DataSource = list;
            cboRoomStatus.DisplayMember = "TenTinhTrang";
            cboRoomStatus.ValueMember = "MaTinhTrangPhong";
            cboRoomStatus.SelectedIndex = 0;

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            frm = new frmPhong();
            frm.isAdd = true;
            frm.ShowDialog();
            dgvRoom.ClearSelection();
            Filter();
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
            frm.PhongDTO.HinhAnh = (byte[])dgvRoom.SelectedRows[0].Cells["colHinhAnh"].Value;
            frm.PhongDTO.TrangThai = Convert.ToBoolean(dgvRoom.SelectedRows[0].Cells["colTrangThai"].Value);
        }
        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {

                frm.Close();
                frm = new frmPhong();
                frm.isAdd = false;
                LayDuLieuTuForm(frm);
                frm.ShowDialog();
                dgvRoom.ClearSelection();
                Filter();
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
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn xóa dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int maphong = (int)dgvRoom.SelectedRows[0].Cells["colMaPHG"].Value;
                    bool check = PhongBLL.Xoap(maphong);
                    if (check)
                    {

                        dgvRoom.ClearSelection();
                        Filter();
                        thongBao = new customMessageBox(
                            "Xóa thành công dữ liệu có mã là: " + maphong + "!"
                        );
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Xóa thất bại dữ liệu có mã là: " + maphong + "!"
                        );
                        thongBao.ShowDialog();
                    }
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
                thongBao = new customMessageBox(
                    "Bạn có chắc chắn muốn khôi phục dòng dữ liệu này không?"
                );
                DialogResult dr = thongBao.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    int maphong = (int)dgvRoom.SelectedRows[0].Cells["colMaPHG"].Value;
                    bool check = PhongBLL.kpp(maphong);
                    if (check)
                    {

                        dgvRoom.ClearSelection();
                        Filter();
                        thongBao = new customMessageBox(
                            "Khôi phục thành công dữ liệu có mã là: " + maphong + "!"
                        );
                        thongBao.ShowDialog();
                    }
                    else
                    {
                        thongBao = new customMessageBox(
                            "Khôi phục thất bại dữ liệu có mã là: " + maphong + "!"
                        );
                        thongBao.ShowDialog();
                    }
                }
               
            }        
            else
            {
                thongBao = new customMessageBox("Hãy chọn một dòng dữ liệu bạn muốn khôi phục!");
                thongBao.ShowDialog();
            }
            
        }

        private void btnTraCuuRoom_Click(object sender, EventArgs e)
        {
            phongDTOs = PhongBLL.laydsp();
            dgvRoom.DataSource = phongDTOs;
            string searchKeyword = txtSearchRoom.Text.Trim();
            if (searchKeyword.Count() > 0)
            {
                phongDTOstk = PhongBLL.TraCuuPhong(phongDTOs, searchKeyword);

                dgvRoom.DataSource = phongDTOstk;

            }
            else
            {
                layds();
            }
        }

        private void cboStateRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            trangthai = cboStateRoom.Text;
            if (trangthai.Length > 0)
            {
                Filter();
            }         
        }    
        private void cboRoomStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            TTPhong = (int)cboRoomStatus.SelectedValue;
            if (TTPhong >= -1)
            {
                Filter();
            }
        }

        private void cboSortRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiPhong = (int)cboSortRoomType.SelectedValue;
            if (LoaiPhong >= -1)
            {
                Filter();
            }
        }
        private void Filter()
        {
            phongDTOs = PhongBLL.FilterTrangThai(trangthai, TTPhong, LoaiPhong);
            dgvRoom.ClearSelection();
            dgvRoom.DataSource = phongDTOs;
        }
        private void cboSortPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortPrice.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    phongDTOs = phongDTOs.OrderByDescending(item => item.GiaPhong).ToList();
                    break;
                default:
                    phongDTOs = phongDTOs.OrderBy(item => item.GiaPhong).ToList();
                    break;
            }

            dgvRoom.DataSource = phongDTOs;
        }

        private void cboSortRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sortOption = cboSortRoomID.SelectedItem.ToString();
            switch (sortOption)
            {
                case "Giảm dần":
                    phongDTOs = phongDTOs.OrderByDescending(item => item.MaPHG).ToList();
                    break;
                default:
                    phongDTOs = phongDTOs.OrderBy(item => item.MaPHG).ToList();
                    break;
            }

            dgvRoom.DataSource = phongDTOs;
        }

        

        private void dgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {
                string columnName = "colHinhAnh";
                int columnIndex = dgvRoom.Columns[columnName].Index;
                object cellValue = dgvRoom.SelectedRows[0].Cells[columnIndex].Value;

                if (cellValue != null)
                {
                    byte[] hinh = (byte[])cellValue;
                    picRoom.Image = ByteArrayToImage(hinh);
                }
                else
                {
                    picRoom.Image = Properties.Resources.no_pictures;
                }
            }
        }
        private static byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        Image ByteArrayToImage(byte[] hinh)
        {
            using (MemoryStream m = new MemoryStream(hinh))
            {
                return Image.FromStream(m);
            }
        }
    }
}
