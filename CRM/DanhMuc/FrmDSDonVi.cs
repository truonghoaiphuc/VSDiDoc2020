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

namespace VSDiDoc.DanhMuc
{
    public partial class FrmDSDonVi : FrmBase
    {
        public FrmDSDonVi()
        {
            InitializeComponent();
            Printable = customGridControl1;
            Landscape = true;
            repositoryItemImageComboBox1.Items.AddEnum(typeof(NoiQuanLy), true);
        }

        private void FrmDSDonVi_Load(object sender, EventArgs e)
        {            
            OnReload();

        }
        protected override void OnNew()
        {
            var f = new FrmDonVi(string.Empty);
            if (f.ShowDialog() == DialogResult.OK)
                OnReload();
            ReloadButtons();
        }

        protected override void OnReload()
        {
            this.donViTableAdapter.Fill(this.vSDiDocData.DonVi);
        }

        protected override bool OnSave()
        {
            customGridView1.CloseEditor();
            customGridView1.UpdateCurrentRow();

            if (customGridView1.HasColumnErrors) return false;
            try
            {
                var dt = vSDiDocData.DonVi.GetChanges() as VSDiDocData.DonViDataTable;
                if (dt != null)
                {
                    donViTableAdapter.Update(dt);
                    vSDiDocData.DonVi.AcceptChanges();
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

        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }
    }
}
