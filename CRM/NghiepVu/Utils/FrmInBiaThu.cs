using Lotus;
using Lotus.Base;
using Lotus.Libraries;
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
using VSDiDoc.NghiepVu.Utils;

namespace VSDiDoc.DanhMuc
{
    public partial class FrmInBiaThu : FrmBase
    {
        public FrmInBiaThu()
        {
            InitializeComponent();
            barEditReport.Visibility = HeThong.NguoiDungDangNhap.QuanTri ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            Printable = customGridControl1;
            Landscape = true;
            repositoryItemImageComboBox1.Items.AddEnum(typeof(NoiQuanLy), true);
        }

        private void FrmInBiaThu_Load(object sender, EventArgs e)
        {            
            OnReload();

        }

        protected override void OnReload()
        {
            this.donViTableAdapter.Fill(this.vSDiDocData.DonVi);
        }

        
        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        protected override void OnEdit()
        {
            customGridView1.ShowEditor();
            var dv = customGridView1.GetFocusedDataRow() as VSDiDocData.DonViRow;
            if (dv == null) return;

            var f = new FrmDonVi(dv.Id);
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();
            ReloadButtons();
        }

        private void barPrintLetter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var v = customGridView1.GetFocusedDataRow() as VSDiDocData.DonViRow;
            if (v == null) return;
            var f = new FrmCTBiaThucs(v);
            f.ShowDialog();
        }

        private void barPrintMember_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dtTVLK = vSDiDocData.DonVi.Where(x => x.IsTVLK==true).OrderBy(y=>y.MaTVLK);
            if (dtTVLK == null) return;
            var r = new RPVanBan();
            r.LoadLayout(Application.StartupPath + "\\Reports\\LabelMultiMedium.repx");
            r.DataSource = dtTVLK;
            if ((bool)barEditReport.EditValue)
                r.ShowDesigner();
            else
                r.ShowPreview();
        }

        private void barPrintList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MsgBox.ShowWaitForm();
            XtraReport rp = new XtraReport();
            rp.LoadLayout(Application.StartupPath + "\\Reports\\LabelMultiMedium.repx");
            rp.DataSource = LayDanhSachDuocChon();
            if ((bool)barEditReport.EditValue)
                rp.ShowDesigner();
            else
                rp.ShowPreview();
            MsgBox.CloseWaitForm();
        }

        BindingList<VSDiDocData.DonViRow> LayDanhSachDuocChon()
        {
            var list = new BindingList<VSDiDocData.DonViRow>();          
            int[] selectedRows = customGridView1.GetSelectedRows();
            for (int i = 0; i < selectedRows.Length; i++)
            {
                var donvi = customGridView1.GetDataRow(selectedRows[i]) as VSDiDocData.DonViRow;
                if (donvi == null) continue;

                list.Add(donvi);
                
            }

            return list;
        }

    }
}
