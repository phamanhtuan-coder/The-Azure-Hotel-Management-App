﻿using BLL;
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
    public partial class frmHoaDon : Form
    {

        public bool isAdd { get; set; }
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();
        ThueBLL thueBLL = new ThueBLL();
        List<ThueDTO> thueDTOs = new List<ThueDTO>();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
            LoadDuLieuCombobox();       
        }

        private void LoadDuLieuCombobox()
        {
            LoadTenVaMaNhanVien();
            LoadTenVaMaThue();
        }

        private void LoadTenVaMaThue()
        {
            ThueDTO khong = new ThueDTO();
            khong.TenThue = "None";
            khong.MaThue = -1;
            thueDTOs.Add(khong);
            foreach (ThueDTO item in thueBLL.TruyVanTenVaMaThue())
            {
                thueDTOs.Add(item);
            }
            cboMaThue.DataSource = thueDTOs;
            cboMaThue.DisplayMember = "TenThue";
            cboMaThue.ValueMember = "MaThue";
            cboMaThue.SelectedIndex = 0;
        }

        private void LoadTenVaMaNhanVien()
        {
            NhanVienDTO Khong= new NhanVienDTO();
            Khong.HoTenNV = "None";
            Khong.MaNV = -1;
            nhanVienDTOs.Add(Khong);          
            foreach(NhanVienDTO item in nhanVienBLL.TruyVanTenVaMaNhanVien())
            {
                nhanVienDTOs.Add(item);
            }
            cboMaNV.DataSource = nhanVienDTOs;
            cboMaNV.DisplayMember = "HoTenNV";
            cboMaNV.ValueMember = "MaNV";
            cboMaNV.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu hóa đơn!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin hóa đơn!");
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
