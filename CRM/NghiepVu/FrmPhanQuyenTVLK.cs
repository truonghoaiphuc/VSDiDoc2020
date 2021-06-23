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
    public partial class FrmPhanQuyenTVLK : FrmBase
    {
        public FrmPhanQuyenTVLK()
        {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(ChucDanh), true);
        }

        private void FrmPhanQuyenTVLK_Load(object sender, EventArgs e)
        {
            OnReload();

        }

        protected override void OnReload()
        {
            // TODO: This line of code loads data into the 'vSDiDocData.PhongBan' table. You can move, or remove it, as needed.
            this.phongBanTableAdapter.Fill(this.vSDiDocData.PhongBan);
            // TODO: This line of code loads data into the 'vSDiDocData.TVLK' table. You can move, or remove it, as needed.
            this.tVLKTableAdapter.Fill(this.vSDiDocData.TVLK);
            // TODO: This line of code loads data into the 'vSDiDocData.PhanQuyenTVLK' table. You can move, or remove it, as needed.
            this.phanQuyenTVLKTableAdapter.Fill(this.vSDiDocData.PhanQuyenTVLK);
            // TODO: This line of code loads data into the 'vSDiDocData.NguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungTableAdapter.Fill(this.vSDiDocData.NguoiDung);
        }

        protected override void OnNew()
        {
            var v = customGridView1.GetFocusedDataRow() as VSDiDocData.NguoiDungRow;
            if (v == null) return;
            customGridView2.AddNewRow();
            customGridView2.UpdateCurrentRow();
        }

        private void customGridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var r = customGridView2.GetFocusedDataRow() as VSDiDocData.PhanQuyenTVLKRow;
            r.Id = Guid.NewGuid().ToString();
            var v = customGridView1.GetFocusedDataRow() as VSDiDocData.NguoiDungRow;
            if (v == null) return;
            r.ChuyenVien = v.TenDangNhap;
        }

        protected override bool OnSave()
        {
            customGridView2.CloseEditor();
            customGridView2.UpdateCurrentRow();

            if (customGridView2.HasColumnErrors) return false;
            try
            {
                var dt = vSDiDocData.PhanQuyenTVLK.GetChanges() as VSDiDocData.PhanQuyenTVLKDataTable;
                if (dt != null)
                {
                    phanQuyenTVLKTableAdapter.Update(dt);
                    vSDiDocData.PhanQuyenTVLK.AcceptChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }        

        private void customGridView2_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            customGridView1.SetColumnError(colThanhVienLuuKy, e.ErrorText);
        }

        private void customGridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var r = customGridView2.GetFocusedDataRow() as VSDiDocData.PhanQuyenTVLKRow;
            if (r == null) return;
            if (r.IsThanhVienLuuKyNull())
            {
                e.Valid = false;
                e.ErrorText = "Chọn Thành viên lưu ký";
                return;
            }

            var count = vSDiDocData.PhanQuyenTVLK.Where(t => t.ThanhVienLuuKy == r.ThanhVienLuuKy).Count();
            if (count > 0)
            {
                e.Valid = false;
                e.ErrorText = "Thành viên lưu ký không được trùng";
            }
        }

    }
}
