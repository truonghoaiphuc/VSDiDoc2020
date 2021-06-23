using Lotus.Base;
using Lotus.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VSDiDoc.NghiepVu.Utils
{
    public partial class FrmThongKeCTNV : FrmBaseReport
    {
        public FrmThongKeCTNV()
        {
            InitializeComponent();
        }

        protected override void OnReload()
        {
            base.OnReload();
            this.chungTuTableAdapter.Fill(this.vSDiDocData.ChungTu);
            this.nguoiDungTableAdapter.Fill(this.vSDiDocData.NguoiDung);
            proc_ThongKeCTNVbyCVTableAdapter.Fill(vSDiDocReports.Proc_ThongKeCTNVbyCV,DateFrom,DateTo);
            proc_ThongKeCTNVTableAdapter.Fill(vSDiDocReports.Proc_ThongKeCTNV, DateFrom, DateTo);

        }

        private void FrmThongKeCTNV_Load(object sender, EventArgs e)
        {
            OnReload();

        }
    }
}
