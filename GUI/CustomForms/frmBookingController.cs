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
    public partial class frmBookingController : Form
    {
        private string username;
        private int maPhong;
        private string ngayDat;
        private int soKhach;

        public frmBookingController()
        {
            InitializeComponent();
        }

        public frmBookingController(string username, int maPhong, string ngayDat, int soKhach)
        {
            InitializeComponent();
            this.username = username;
            this.maPhong = maPhong;
            this.ngayDat = ngayDat;
            this.soKhach = soKhach;
        }

        private void frmBookingController_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            txtMaKH.Enabled = false;
            txtMaKH.Text = username;
            dtpNgayDat.Enabled = false;
            dtpNgayDat.Text = ngayDat;
            txtMaPHG.Enabled = false;
            txtMaPHG.Text = maPhong.ToString();
            nudSoLuongKhach.Enabled = false;
            nudSoLuongKhach.Value = (decimal) soKhach;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
