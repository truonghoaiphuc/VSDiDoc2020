using Lotus;
using Lotus.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using CRM;
namespace CRM.Reports
{
    public partial class FrmSoLuotCSKH : FrmBaseReport
    {
        public FrmSoLuotCSKH()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;

        }

        private void FrmPhapLy_Load(object sender, EventArgs e)
        {                        
            OnReload(); 
        }

     

        protected override void OnEdit()
        {
            //var p = customGridView1.GetFocusedDataRow() as CRMData.PhieuDatHangRow;
            //if (p == null) return;

            //var f = new FrmThongTinPhieuDH(p.SoPhieu);
            //if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    OnReload();

            //ReloadButtons();
        }

        protected override void OnReload()
        {
            base.OnReload();
            txtTile1.EditValue =
            txtTiLe2.EditValue = null;

            soLuotCSKHTableAdapter.Fill(dataReport.SoLuotCSKH, DateFrom, DateTo);
            var ThongKeAD = new DataReportTableAdapters.ThongKeTongTableAdapter();
            var data = ThongKeAD.GetData(DateFrom, DateTo);
            var t = data.FirstOrDefault();
            if(t!=null)
            {
                txtTile1.EditValue = t.TiLe1;
                txtTiLe2.EditValue = t.TiLe2;
            }

        }
       
       

        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }
    }
}
