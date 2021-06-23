using Lotus;
using Lotus.Base;
using Lotus.Base.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSDiDoc.DanhMuc;

namespace VSDiDoc.NghiepVu
{
    public partial class FrmThongTinVBDen : FrmBase
    {
        private string _LoaiVB = string.Empty;
        private string _Id = string.Empty;
        private bool _isEditable = false;
        VSDiDocData.LoaiVanBanRow loaiVB;
        private VSDiDocData.VanBanDenRow _vb;
        private bool _isEdit = false;

        public FrmThongTinVBDen(string loaivb, string Id, bool isEditable=false)
        {
            InitializeComponent();
            SetValidationRule(SoVBTextEdit, NgayNhanDateEdit, SoLuongTextEdit, ChungTuLookUpEdit, lkeNoiGui, TrichYeuTextEdit, NgayVBDateEdit);

            AutoCompleteStringCollection s = new AutoCompleteStringCollection();
            autoCompleteTableAdapter1.Fill(vSDiDocData.AutoComplete);
            foreach (var v in vSDiDocData.AutoComplete)
                s.Add(v.GoiY);
            TrichYeuTextEdit.AutoCompleteCustomSource = s;

            _LoaiVB = loaivb;
            _Id = Id;
            _isEditable = isEditable;
            SoVBTextEdit.Enabled = _isEditable;
            loaiVanBanTableAdapter1.FillByMaLoaiVB(vSDiDocData.LoaiVanBan, _LoaiVB);
            loaiVB = vSDiDocData.LoaiVanBan.FirstOrDefault();            
        }

        private void FrmThongTinVBDen_Load(object sender, EventArgs e)
        {
            
            OnReload();
            this.chungTuTableAdapter.FillByLoaiVB(vSDiDocData.ChungTu, _LoaiVB);
                        
            if (string.IsNullOrEmpty(_Id))
            {
                OnNew();
                barSaveandNew.Enabled = !_isEditable;
            }
            else
            {
                barSaveandNew.Enabled = false;
                OnEdit();
            }            
        }

        protected override void OnReload()
        {            
            this.donViTableAdapter.Fill(this.vSDiDocData.DonVi);                        
        }

        protected override void OnEdit()
        {
            this.vanBanDenTableAdapter.FillById(vSDiDocData.VanBanDen, _Id);
            var dv = vSDiDocData.VanBanDen.FirstOrDefault();
            if (dv == null) return;
            _isEdit = true;
        }

        protected override void OnNew()
        {
            if (loaiVB == null) return;
            string sovb = string.Format("{0:d6}", loaiVB.STT + 1);
            _Id = string.Format("{0}.{1}.{2}",_LoaiVB, sovb,DateTime.Now.ToString("yyyyMMddHHmmss"));

            this.vanBanDenTableAdapter.FillById(vSDiDocData.VanBanDen, _Id);
            _vb = vSDiDocData.VanBanDen.NewVanBanDenRow();
            _vb.NgayNhap = DateTime.Now;
            _vb.NgayNhan = DateTime.Now;
            _vb.SoLuong = 1;
            _vb.NguoiNhap = HeThong.NguoiDungDangNhap.TenDangNhap;

          
            


            _vb.LoaiVB = _LoaiVB;            
            
            _vb.Nam = loaiVB.Nam;
            _vb.SoVB = sovb;
            _vb.Status = 0;

            _vb.Id = _Id;

            var ctTable = (chungTuBindingSource.DataSource) as VSDiDocData;
            var ct = ctTable.ChungTu.FirstOrDefault();

            _vb.ChungTu = ct == null ? "" : ct.MaCT;

            vSDiDocData.VanBanDen.AddVanBanDenRow(_vb);            
         
            vanBanDenBindingSource.EndEdit();

            ChungTuLookUpEdit.Focus();
        }




     
        protected override bool OnSave()
        {
            if (LuuVanBan())
            {
                if(_isEdit || _isEditable)
                {
                    MsgBox.ShowSuccessfulDialog("Cập nhật dữ liệu thành công");
                    this.DialogResult = DialogResult.OK;
                    return true;
                }
                if (MsgBox.ShowYesNoDialog("Thêm văn bản thành công! Bạn muốn tiếp tục thêm văn bản?") == DialogResult.Yes)
                {
                    var trichyeu = _vb.TrichYeu;
                    var ngay = _vb.NgayVB;
                    var ct = _vb.ChungTu;

                    OnNew();

                    _vb.ChungTu = ct;
                    _vb.TrichYeu = trichyeu;
                    _vb.NgayVB = ngay;

                    ChungTuLookUpEdit.Focus();

                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    return true;
                }
                    
            }
            return false;
        }






        bool CheckTrung()
        {
            var data = new VSDiDocData();
            vanBanDenTableAdapter.FillBySoVB(data.VanBanDen, _vb.LoaiVB, _vb.SoVB, _vb.Nam);
            if (data.VanBanDen.Count > 0)
                return true;
            return false;
        }


        bool KiemTra()
        {
            // kiem tra moi save chư :D
            dataLayoutControl1.Validate();
            if (!dxValid.Validate()) return false;
            vanBanDenBindingSource.EndEdit();
            if(_vb != null)
                if (CheckTrung())
                {
                    MsgBox.ShowErrorDialog(string.Format("Đã tồn tại số văn bản [{0}] trong hệ thống. Vui lòng kiểm tra lại!", _vb.SoVB));
                    return false;
                }

            return true;
        }


        bool LuuVanBan()
        {
            if (KiemTra() == false) return false;

            try
            {
                var dt = vSDiDocData.VanBanDen.GetChanges() as VSDiDocData.VanBanDenDataTable;
                if (dt != null)
                {
                    vanBanDenTableAdapter.Update(dt);
                    vSDiDocData.VanBanDen.AcceptChanges();
                    if(!_isEditable && !_isEdit)
                    {
                        loaiVB.STT += 1;
                        var lvb = vSDiDocData.LoaiVanBan.GetChanges() as VSDiDocData.LoaiVanBanDataTable;
                        loaiVanBanTableAdapter1.Update(lvb);
                        vSDiDocData.LoaiVanBan.AcceptChanges();
                    }                    
                }
                //this.DialogResult = DialogResult.OK;
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }

        #region KeyPress
        private void ChungTuLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                KyHieuTextEdit.Focus();
        }

        private void KyHieuTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lkeNoiGui.Focus();
        }

        private void NoiGuiGridLookUpEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TrichYeuTextEdit.Focus();
        }

        private void TrichYeuTextEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NgayVBDateEdit.Focus();
        }

        private void NgayVBDateEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GhiChuTextEdit.Focus();
        }
        #endregion

        private void lkeNoiGui_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Tag != null)
                if (e.Button.Tag.ToString() == "AddNewDV")
                {
                    var f = new FrmDonVi("");
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        this.donViTableAdapter.Fill(vSDiDocData.DonVi);
                        lkeNoiGui.Properties.DataSource = vSDiDocData.DonVi;
                        lkeNoiGui.EditValue = f.ID;
                    }
                }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          //  LockControls(false);
        }


    }
}
