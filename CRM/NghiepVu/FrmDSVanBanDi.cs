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
using VSDiDoc.Report;

namespace VSDiDoc.NghiepVu
{
    public partial class FrmDSVanBanDi : FrmBaseReport
    {
        private string _loaivb = "CVDI";

        public string LoaiVB
        {
            get { return _loaivb; }
            set { _loaivb = value; }
        }

        public FrmDSVanBanDi()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;
            barCopy.Enabled = btnAdd.Enabled;
        }

        private void FrmDSVanBanDi_Load(object sender, EventArgs e)
        {            
            OnReload();
        }

        protected override void OnReload()
        {
            base.OnReload();
            MsgBox.ShowWaitForm();
            this.fileLuuTableAdapter.Fill(this.vSDiDocData.FileLuu);
            this.nguoiDungTableAdapter.Fill(this.vSDiDocData.NguoiDung);
            this.phongBanTableAdapter.Fill(this.vSDiDocData.PhongBan);
            if (ReportType == Lotus.Base.ReportType.All)
                this.vanBanDiTableAdapter.FillByLoaiVB(this.vSDiDocData.VanBanDi, _loaivb);
            else
                this.vanBanDiTableAdapter.FillByNgayVB(this.vSDiDocData.VanBanDi, _loaivb, DateFrom, DateTo);
            MsgBox.CloseWaitForm();
        }

        protected override void OnNew()
        {
            var f = new FrmThongTinVBDi(_loaivb, "");
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();

            ReloadButtons();
        }

        protected override void OnEdit()
        {            
            var v = customGridView1.GetFocusedDataRow() as VSDiDocData.VanBanDiRow;
            if (v == null) return;

            var f = new FrmThongTinVBDi(_loaivb, v.Id, true);
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
                var dt = vSDiDocData.VanBanDi.GetChanges() as VSDiDocData.VanBanDiDataTable;
                if (dt != null)
                {
                    vanBanDiTableAdapter.Update(dt);
                    vSDiDocData.VanBanDi.AcceptChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }

        }

        protected override void OnPrint()
        {
            var f = new FrmInSoVBDen(LoaiSo.VBDI);
            f.LoaiVB = _loaivb;
            f.ShowDialog();
        }


        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void barCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var v = customGridView1.GetFocusedDataRow() as VSDiDocData.VanBanDiRow;
            if (v == null) return;
            var f = new FrmThongTinVBDi(v);
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();

            ReloadButtons();
        }
    }
}
