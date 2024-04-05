﻿using System;
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
    public partial class frmTinhTrangTB : Form
    {
        public string maTinhTrangTB { get; set; }
        public string tenTinhTrangTB { get; set; }

        public string moTa { get; set; }

        public bool isAdd { get; set; }

        public frmTinhTrangTB()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
          // gán giá trị mặc định bằng các biến trên, néu là edit có giá trị truyền vào thì kiểm tra và chọn giá trị
          txtTenTrangThaiTB.Text = tenTinhTrangTB;
          
           rtxtMoTa.Text = moTa; 

        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            customMessageBox thongBao;
            // Kiểm tra if tiến hành xử lý sự kiện thêm/sửa phòng ban
            if (isAdd)
            {
                // Nếu đúng là form Thêm thì chạy lệnh insert

                thongBao = new customMessageBox("Đã thêm thành công dữ liệu phân quyền mới!");
                thongBao.ShowDialog();

            }
            else
            {
                // nếu không thì chạy lệnh update
                thongBao = new customMessageBox("Sửa thành công thông tin phân quyền đã chọn!");
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
