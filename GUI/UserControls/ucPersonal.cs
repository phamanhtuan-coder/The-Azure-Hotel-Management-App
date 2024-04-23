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
    public partial class ucPersonal : UserControl
    {

        public ucPersonal()
        {
            InitializeComponent();
        }

        private frmMain _parentForm;

        public ucPersonal(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ucPersonal_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLichSuDP_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucBookingHistory ucBookingHistory = new ucBookingHistory(parentForm);
            parentForm.SwitchUserControl(ucBookingHistory);
            this.Dispose();
        }
    }
       
}
