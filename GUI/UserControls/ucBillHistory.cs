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
    public partial class ucBillHistory : UserControl
    {
        private frmMain _parentForm;
        customMessageBox thongBao;
        public ucBillHistory()
        {
            InitializeComponent();
        }

        public ucBillHistory(frmMain parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain parentForm = this.ParentForm as frmMain;
            ucPersonal ucPersonal = new ucPersonal(parentForm);
            parentForm.SwitchUserControl(ucPersonal);
            this.Dispose();
        }
    }
}
