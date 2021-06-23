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
    public partial class FrmHuyDuyetCTNV : FrmBaseReport
    {
        private string _loaiVB = "CTNV";
        public FrmHuyDuyetCTNV()
        {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(Status), true);
            repositoryItemImageComboBox2.Items.AddEnum(typeof(Buoi), true);
        }

        private void FrmHuyDuyetCTNV_Load(object sender, EventArgs e)
        {          
            OnReload();
        }

        protected override void OnReload()
        {             
            base.OnReload();
            this.chungTuTableAdapter.FillByLoaiVB(this.vSDiDocData.ChungTu, _loaiVB);            
            this.tVLKTableAdapter.Fill(this.vSDiDocData.TVLK);            
            this.vanBanDenTableAdapter.FillByCTNVApprove(this.vSDiDocData.VanBanDen,DateFrom,DateTo);
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
            if (ct.Status == (int)Status.APPROVED || ct.Status== (int)Status.DENY)
            {
                if(MsgBox.ShowYesNoDialog(string.Format("Bạn muốn HỦY DUYỆT bộ chứng từ số [{0}--{1}]",ct.SoVB,ct.ChungTu))==DialogResult.Yes)
                {
                    ct.Status = (int)Status.PENDING;
                    ct.TVLKNhan = null;

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
