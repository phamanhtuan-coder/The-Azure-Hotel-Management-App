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
    public partial class ucRoomType : UserControl
    {
        public frmLoaiPhong frm = new frmLoaiPhong();
        public customMessageBox thongBao;

        List<loaiphongDTO> dslp = new List<loaiphongDTO>();
        loaiphongBLL lpbll = new loaiphongBLL();
        public ucRoomType()
        {
            InitializeComponent();
        }
        

        private void ucRoomType_Load(object sender, EventArgs e)
        {
            dslp = lpbll.laydslphong();
            dgvloaiphong.DataSource=dslp;
            dgvloaiphong.AutoGenerateColumns = false;
            laycombo();
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomTypeID);
            
            DuLieuChoComboBox.duLieuFilter(cboStateRoomType);
        }
    }
}
