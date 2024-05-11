using BLL;
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
    public partial class frmHienCTHD : Form
    {

        public List<ChiTietHoaDonDTO> hs;
        public frmHienCTHD()
        {
            InitializeComponent();
        }

        private void frmHienCTHD_Load(object sender, EventArgs e)
        {
            dgvBillDetails.DataSource = hs;
            dgvBillDetails.DefaultCellStyle.ForeColor = Color.Black;
            dgvBillDetails.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvBillDetails.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
