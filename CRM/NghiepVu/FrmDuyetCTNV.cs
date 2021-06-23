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

namespace VSDiDoc.NghiepVu
{
    public partial class FrmDuyetCTNV : FrmBaseReport
    {
        private string _loaiVB = "CTNV";
        public FrmDuyetCTNV()
        {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(Status), true);
            repositoryItemImageComboBox2.Items.AddEnum(typeof(Buoi), true);
            barNgayHL.EditValue = DateTime.Today;
        }

        private void FrmDuyetCTNV_Load(object sender, EventArgs e)
        {          
            OnReload();
        }

        protected override void OnReload()
        {             
            base.OnReload();
            this.chungTuTableAdapter.FillByLoaiVB(this.vSDiDocData.ChungTu, _loaiVB);            
            this.tVLKTableAdapter.Fill(this.vSDiDocData.TVLK);            
            this.vanBanDenTableAdapter.FillByNgayNhan(this.vSDiDocData.VanBanDen,_loaiVB,DateFrom,DateTo);
        }

        protected override void OnEdit()
        {
            var t = customGridView1.GetFocusedDataRow() as VSDiDocData.VanBanDenRow;
            if (t == null) return;
            if(t.Status==(int)Status.PENDING)
            {
                var f = new FrmThongTinCTNV(t.LoaiVB, t.Id);
                if (f.ShowDialog() == DialogResult.OK)
                    OnReload();
            }
            ReloadButtons();
      }
        protected override bool OnSave()        
        {
            var ct = customGridView1.GetFocusedDataRow() as VSDiDocData.VanBanDenRow;
            if (ct == null) return false;
            if (ct.Status == (int)Status.PENDING)
            {
                if(MsgBox.ShowYesNoDialog(string.Format("Bạn muốn duyệt bộ chứng từ số [{0}--{1}]",ct.SoVB,ct.ChungTu))==DialogResult.Yes)
                {
                    ct.Status = (int)Status.APPROVED;
                    ct.NgayGiao = DateTime.Today;
                    ct.NgayHieuLuc = (DateTime)barNgayHL.EditValue;

                    var loaict = (chungTuBindingSource.DataSource as VSDiDocData).ChungTu.First(x => x.MaCT == ct.ChungTu) as VSDiDocData.ChungTuRow;
                    if (loaict.IsYCCK)
                    {
                        var f = new FrmSelectTVLK();
                        f.ShowDialog();
                        ct.TVLKNhan = f.TVLK;
                    }


                    if (Luu())
                    {
                        MsgBox.ShowSuccessfulDialog("Duyệt chứng từ thành công");
                        customGridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                        customGridView1.FocusedColumn = colSoVB;
                        return true;
                    }
                }                
            }
            return false;
        }

        protected override bool OnDelete()
        {
            var ct = customGridView1.GetFocusedDataRow() as VSDiDocData.VanBanDenRow;
            if (ct == null) return false;
            if (ct.Status == (int)Status.PENDING)
            {
                if (MsgBox.ShowYesNoDialog(string.Format("Bạn muốn LOẠI bộ chứng từ số [{0}--{1}]", ct.SoVB, ct.ChungTu)) == DialogResult.Yes)
                {
                    ct.Status = (int)Status.DENY;
                    ct.NgayGiao = DateTime.Today;

                    if (Luu())
                    {
                        MsgBox.ShowSuccessfulDialog("LOẠI chứng từ thành công");
                        customGridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                        customGridView1.FocusedColumn = colSoVB;
                        return true;
                    }
                }
            }
            return false;
        }
        
        bool Luu()
        {
            try
            {
                var dt = vSDiDocData.VanBanDen.GetChanges() as VSDiDocData.VanBanDenDataTable;
                vanBanDenTableAdapter.Update(dt);
                vSDiDocData.VanBanDen.AcceptChanges();
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
            return true;
        }

        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }
    }
}
