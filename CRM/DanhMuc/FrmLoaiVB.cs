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
    public partial class FrmLoaiVB : FrmBase
    {
        public FrmLoaiVB()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;
        }

        private void FrmLoaiVB_Load(object sender, EventArgs e)
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
        }
        protected override bool OnSave()
        {
            customGridView1.CloseEditor();
            customGridView1.UpdateCurrentRow();

            if (customGridView1.HasColumnErrors) return false;
            try
            {
                var dt = vSDiDocData.LoaiVanBan.GetChanges() as VSDiDocData.LoaiVanBanDataTable;
                if (dt != null)
                {
                    loaiVanBanTableAdapter.Update(dt);
                    vSDiDocData.LoaiVanBan.AcceptChanges();
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
