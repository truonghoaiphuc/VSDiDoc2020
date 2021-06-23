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
    public partial class FrmNoiLuu : FrmBase
    {
        public FrmNoiLuu()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;
        }

        private void FrmNoiLuu_Load(object sender, EventArgs e)
        {
            OnReload();

        }
        protected override void OnNew()
        {
            customGridView1.AddNewRow();
            var r = customGridView1.GetFocusedDataRow() as VSDiDocData.FileLuuRow;
            r.Id = Guid.NewGuid().ToString();
            customGridView1.UpdateCurrentRow();
        }

        protected override void OnReload()
        {
            this.fileLuuTableAdapter.Fill(this.vSDiDocData.FileLuu);         
        }
        protected override bool OnSave()
        {
            customGridView1.CloseEditor();
            customGridView1.UpdateCurrentRow();

            if (customGridView1.HasColumnErrors) return false;
            try
            {
                var dt = vSDiDocData.FileLuu.GetChanges() as VSDiDocData.FileLuuDataTable;
                if (dt != null)
                {
                    fileLuuTableAdapter.Update(dt);
                    vSDiDocData.FileLuu.AcceptChanges();
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
