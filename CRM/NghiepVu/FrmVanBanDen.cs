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
using DevExpress.XtraReports.UI;
using VSDiDoc.Report;

namespace VSDiDoc.NghiepVu
{
    public partial class FrmVanBanDen : FrmBaseReport
    {
        private string _loaivb = "";

        public string LoaiVB
        {
            get { return _loaivb; }
            set { _loaivb = value; }
        }
        public FrmVanBanDen()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;
            barNewAB.Enabled = btnAdd.Enabled;
            //_loaivb = "CVDE";
        }

        private void FrmVanBanDen_Load(object sender, EventArgs e)
        {                        
            OnReload();
        }


        protected override void OnReload()
        {
            base.OnReload();
            MsgBox.ShowWaitForm();
            this.chungTuTableAdapter.Fill(this.vSDiDocData.ChungTu);
            this.donViTableAdapter.Fill(this.vSDiDocData.DonVi);
            if (ReportType == Lotus.Base.ReportType.All)
                this.vanBanDenTableAdapter.FillByLoaiVB(this.vSDiDocData.VanBanDen, _loaivb);
            else
                this.vanBanDenTableAdapter.FillByNgayNhan(this.vSDiDocData.VanBanDen, _loaivb, DateFrom, DateTo);
            MsgBox.CloseWaitForm();
        }

        protected override void OnNew()
        {
            var f = new FrmThongTinVBDen(_loaivb, "");
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();
            ReloadButtons();
        }

        protected override void OnEdit()
        {
            customGridView1.ShowEditor();
            var dv = customGridView1.GetFocusedDataRow() as VSDiDocData.VanBanDenRow;
            if (dv == null) return;

            var f = new FrmThongTinVBDen(dv.LoaiVB,dv.Id);
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();
            ReloadButtons();
        }

        protected override bool OnDelete()
        {
            if (MsgBox.ShowYesNoDialog("Bạn có chắc muốn xóa những dòng này?") == System.Windows.Forms.DialogResult.No) return false;

            customGridView1.DeleteSelectedRows();
            if (OnSave() == false)
            {
                OnReload();
                return false;
            }

            return true;
        }

        protected override bool OnSave()
        {
            customGridView1.CloseEditor();
            customGridView1.UpdateCurrentRow();

            if (customGridView1.HasColumnErrors) return false;
            try
            {
                var dt = vSDiDocData.VanBanDen.GetChanges() as VSDiDocData.VanBanDenDataTable;
                if (dt != null)
                {
                    vanBanDenTableAdapter.Update(dt);
                    vSDiDocData.VanBanDen.AcceptChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }

        }

        //protected override void OnPrint()
        // {
        //    var r = new RPVanBan();
        //    var ds = new VSDiDocData();
        //    vanBanDenTableAdapter.FillByNgayNhan(ds.VanBanDen, _loaivb, DateFrom, DateTo);
        //    r.LoadLayout(Application.StartupPath + "\\Reports\\VBDHC.repx");
        //    r.DataSource = ds.VanBanDen;

        //    r.ShowDesigner();
        //}

        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void barNewAB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new FrmThongTinVBDen(_loaivb, "",true);
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();
            ReloadButtons();
        }
    }
}
