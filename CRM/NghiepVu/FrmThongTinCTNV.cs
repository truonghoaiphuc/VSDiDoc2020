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
    public partial class FrmThongTinCTNV : FrmBase
    {
        private string _Id = "";
        private string _loaivb = "";
        public FrmThongTinCTNV(string loaivb,string id)
        {
            InitializeComponent();
            SetValidationRule(NgayNhanDateEdit, SoVBTextEdit,  SoLuongTextEdit, TVLKGuiTextEdit, ChungTuTextEdit);
            _Id = id;
            _loaivb = loaivb;
        }

        private void FrmThongTinCTNV_Load(object sender, EventArgs e)
        {
            OnReload();
            Binding();
        }

        protected override void OnReload()
        {
            this.tVLKTableAdapter.Fill(vSDiDocData.TVLK);
            this.chungTuTableAdapter.FillByLoaiVB(vSDiDocData.ChungTu,_loaivb);
        }

        protected override bool OnSave()        
        {
            dataLayoutControl1.Validate();
            if (dxError.HasErrors) return false;
            if (!dxValid.Validate()) return false;            
            try
            {
                var dt = vSDiDocData.VanBanDen.GetChanges() as VSDiDocData.VanBanDenDataTable;
                vanBanDenTableAdapter.Update(dt);
                vSDiDocData.VanBanDen.AcceptChanges();
                this.DialogResult = DialogResult.OK;
                return true;
            }
            catch(Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }                        
        }


        void Binding()
        {
            this.vanBanDenTableAdapter.FillById(vSDiDocData.VanBanDen, _Id);
            var vb = vSDiDocData.VanBanDen.FirstOrDefault();            
        }
    }
}
