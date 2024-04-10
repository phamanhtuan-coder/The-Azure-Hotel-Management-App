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

        List<loaiphongDTO> dslp = new List<loaiphongDTO>();
        loaiphongBLL lpbll = new loaiphongBLL();
        public ucRoomType()
        {
            InitializeComponent();
        }


        private void khoiTaoGiaTrichoForm()
        {
            dslp = lpbll.laydslphong();
            dgvloaiphong.DataSource=dslp;
          
        }

        private void ucRoomType_Load(object sender, EventArgs e)
        {
            dgvloaiphong.AutoGenerateColumns = false;
            khoiTaoGiaTrichoForm();
            laycombo();
        }

        private void laycombo()
        {
            DuLieuChoComboBox.duLieuSort(cboSortRoomTypeID);
            
            DuLieuChoComboBox.duLieuFilter(cboStateRoomType);
        }
    }
}
