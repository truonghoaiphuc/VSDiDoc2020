using DevExpress.XtraReports.UI;
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

namespace VSDiDoc.NghiepVu.Utils
{
    public partial class FrmCTBiaThucs : FrmBase
    {
        VSDiDocData.DonViRow _dv;
        VSDiDocData ds;
        public FrmCTBiaThucs(VSDiDocData.DonViRow dv)
        {
            InitializeComponent();
            barEditReport.Visibility = HeThong.NguoiDungDangNhap.QuanTri ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            ds = new VSDiDocData();
            ds.DonVi.ImportRow(dv);
            txtNoiNhan.Text = dv.FullDonVi;
            memDiaChi.Text = dv.DiaChi;
            _dv = dv;
        }

        private void FrmCTBiaThucs_Load(object sender, EventArgs e)
        {
            UseEnableControl = false;
            LockControls(false);
            OnReload();
        }

        protected override void OnReload()
        {
            this.vanBanDiTableAdapter.FillByNoiNhan(this.vSDiDocData.VanBanDi,_dv.Id);
        }

        protected override void OnPrint()
        {
            MsgBox.ShowWaitForm();
            XtraReport rp = new XtraReport();
            LayDanhSachDuocChon();
            if (ds.VanBanDi.Rows.Count > 0)
            {
                rp.DataSource = ds;
                switch (rdgSize.EditValue.ToString())
                {
                    case "LARGE":
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\XtraReportLarge.repx");
                        break;
                    case "MEDIUM":
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\XtraReportMedium.repx");
                        break;
                    case "SMALL":
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\xtraReportSmall.repx");
                        break;
                    default:
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\XtraReportMedium.repx");
                        break;
                }
            }
            else
            {              
                rp.DataSource = ds.DonVi;
                switch (rdgSize.EditValue.ToString())
                {
                    case "LARGE":
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\XtraReportLarge_None.repx");
                        break;
                    case "MEDIUM":
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\XtraReportMedium_None.repx");
                        break;
                    case "SMALL":
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\xtraReportSmall_None.repx");
                        break;
                    default:
                        rp.LoadLayout(Application.StartupPath + "\\Reports\\XtraReportMedium_None.repx");
                        break;
                }
            }
            if ((bool)barEditReport.EditValue)
                rp.ShowDesigner();
            else
                rp.ShowPreview();

            MsgBox.CloseWaitForm();
        }

        void LayDanhSachDuocChon()
        {
            ds.VanBanDi.Clear();
            int[] selectedRows = customGridView1.GetSelectedRows();
            for (int i = 0; i < selectedRows.Length; i++)
            {
                var vb = customGridView1.GetDataRow(selectedRows[i]) as VSDiDocData.VanBanDiRow;
                if (vb == null) continue;
                ds.VanBanDi.ImportRow(vb);
            }
        }
    }
}
