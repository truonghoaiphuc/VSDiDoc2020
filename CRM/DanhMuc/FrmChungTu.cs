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

namespace VSDiDoc.DanhMuc
{
    public partial class FrmChungTu : FrmBase
    {
        public FrmChungTu()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;
        }

        private void FrmChungTu_Load(object sender, EventArgs e)
        {         
            OnReload();

        }
        protected override void OnNew()
        {
            customGridView1.AddNewRow();
            customGridView1.UpdateCurrentRow();
        }

        protected override void OnReload()
        {            
            this.loaiVanBanTableAdapter.Fill(this.vSDiDocData.LoaiVanBan);
            this.chungTuTableAdapter.Fill(this.vSDiDocData.ChungTu);          
        }
        protected override bool OnSave()
        {
            customGridView1.CloseEditor();
            customGridView1.UpdateCurrentRow();

            if (customGridView1.HasColumnErrors) return false;
            try
            {
                var dt = vSDiDocData.ChungTu.GetChanges() as VSDiDocData.ChungTuDataTable;
                if (dt != null)
                {
                    chungTuTableAdapter.Update(dt);
                    vSDiDocData.ChungTu.AcceptChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
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
    }
}
