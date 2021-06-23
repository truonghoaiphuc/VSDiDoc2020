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
    public partial class FrmCTNghiepVu : FrmBaseReport
    {
        private string _loaiVB = "CTNV";
        private VSDiDocData.LoaiVanBanRow loaivbRow;
        private int iSoVB, iTo;
        public FrmCTNghiepVu()
        {
            InitializeComponent();
            repositoryItemImageComboBox1.Items.AddEnum(typeof(Status), true);
            repositoryItemImageComboBox2.Items.AddEnum(typeof(Buoi), true);
            SetValidationRule(NgayNhanDateEdit, SoVBTextEdit, txtDenSo, SoLuongTextEdit, TVLKGuiTextEdit, ChungTuTextEdit);
            txtDenSo.Properties.MaxValue = 999999;
            Binding();
        }

        private void FrmCTNghiepVu_Load(object sender, EventArgs e)
        {
            UseEnableControl = false;
            LockControls(false);            
            OnReload();
        }

        void ValidateSoVB()
        {
            if (Convert.ToInt32(txtDenSo.EditValue) < iSoVB)
                dxError.SetError(txtDenSo, "Đến số không được < số hiện tại");
            else
                dxError.ClearErrors();
        }


        protected override void OnReload()
        {             
            base.OnReload();
            this.chungTuTableAdapter.FillByLoaiVB(this.vSDiDocData.ChungTu, _loaiVB);            
            this.tVLKTableAdapter.Fill(this.vSDiDocData.TVLK);            
            this.vanBanDenTableAdapter.FillByCTNV(this.vSDiDocData.VanBanDen,_loaiVB,DateFrom,DateTo,(int)Status.PENDING);
            loaiVanBanTableAdapter1.FillByMaLoaiVB(vSDiDocData.LoaiVanBan, _loaiVB);
            loaivbRow = vSDiDocData.LoaiVanBan.FirstOrDefault();
            iSoVB = iTo = loaivbRow.STT + 1;
            SoVBTextEdit.EditValue = iSoVB;
            txtDenSo.Properties.MinValue = iSoVB;
            txtDenSo.EditValue = iTo;
            
            txtDenSo.Focus();
            txtDenSo.SelectAll();
            UseEnableControl = false;
            LockControls(false);

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
            iTo = Convert.ToInt32(txtDenSo.EditValue);
            dataLayoutControl1.Validate();
            ValidateSoVB();
            if (dxError.HasErrors) return false;
            if (!dxValid.Validate()) return false;
            MsgBox.ShowWaitForm();
            this.vanBanDenTableAdapter.FillById(this.vSDiDocData.VanBanDen, "");
            for (int i = iSoVB; i <= iTo; i++)
            {
                var vb = vSDiDocData.VanBanDen.NewVanBanDenRow();
                vb.Id = string.Format("{0}.{1}.{2}", _loaiVB, string.Format("{0:d6}", i), DateTime.Now.ToString("yyyyMMddHHmmss"));
                vb.NgayNhap = DateTime.Now;
                vb.NgayNhan = NgayNhanDateEdit.DateTime;
                vb.SoVB = string.Format("{0:d6}", i);
                vb.SoLuong = Convert.ToInt32( SoLuongTextEdit.Text);
                vb.TVLKGui = TVLKGuiTextEdit.EditValue.ToString();
                vb.ChungTu = ChungTuTextEdit.EditValue.ToString();
                vb.TrichYeu = TrichYeuTextEdit.Text;
                vb.ChungKhoan = ChungKhoanTextEdit.Text;
                vb.GhiChu = GhiChuTextEdit.Text;
                vb.Buoi = BuoiRadioGroup.SelectedIndex;
                vb.IsMail = IsMailCheckEdit.Checked;
                vb.LoaiVB = loaivbRow.MaLoaiVB;
                vb.Nam = loaivbRow.Nam;
                vb.Status = (int)Status.PENDING;
                vb.NguoiNhap = HeThong.NguoiDungDangNhap.TenDangNhap;

                vSDiDocData.VanBanDen.AddVanBanDenRow(vb);
            }
            try
            {
                var dt = vSDiDocData.VanBanDen.GetChanges() as VSDiDocData.VanBanDenDataTable;
                vanBanDenTableAdapter.Update(dt);
                vSDiDocData.VanBanDen.AcceptChanges();
                loaivbRow.STT = iTo;
                var lvbdt = vSDiDocData.LoaiVanBan.GetChanges() as VSDiDocData.LoaiVanBanDataTable;
                if(lvbdt!=null)
                {
                    loaiVanBanTableAdapter1.Update(lvbdt);
                    vSDiDocData.LoaiVanBan.AcceptChanges();
                    MsgBox.ShowSuccessfulDialog("Thêm chứng từ thành công");
                    OnReload();
                }
            }
            catch
            {
                MsgBox.ShowErrorDialog("Có lỗi xảy ra trong quá trình thêm chứng từ");
                return false;
            }
            MsgBox.CloseWaitForm();
            return true;
        }


        void Binding()
        {
            
            NgayNhanDateEdit.DateTime = DateTime.Today;
            //TVLKGuiTextEdit.EditValue = (tVLKBindingSource.DataSource as VSDiDocData).TVLK.FirstOrDefault().MaTVLK;
            //ChungTuTextEdit.EditValue = (chungTuBindingSource.DataSource as VSDiDocData).ChungTu.FirstOrDefault().MaCT;
            TrichYeuTextEdit.Text = "";
            ChungKhoanTextEdit.Text = "";
            IsMailCheckEdit.Checked = false;
            BuoiRadioGroup.SelectedIndex = DateTime.Now.Hour > 12 ? 1 : 0;
            SoLuongTextEdit.EditValue = 1;
        }

        private void txtDenSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TVLKGuiTextEdit.Focus(); 
        }

        private void TVLKGuiTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ChungTuTextEdit.Focus();
        }

        private void customGridView1_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LockControls(false);
        }
    }
}
