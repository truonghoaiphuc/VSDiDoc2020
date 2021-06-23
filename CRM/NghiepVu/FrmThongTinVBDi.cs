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

namespace VSDiDoc.NghiepVu
{
    public partial class FrmThongTinVBDi : FrmBase
    {
        private string _loaiVB = "CVDI";
        private string _Id = string.Empty;
        private bool _isEditable = false;
        private bool _isCopyandNew = false;
        private VSDiDocData.LoaiVanBanRow loaiVB;
        private VSDiDocData.VanBanDiRow _vb;
        public FrmThongTinVBDi(string loaivb, string id, bool isEditable=false)
        {
            InitializeComponent();
            SetValidationRule(SoVBTextEdit, TrichYeuTextEdit, SoLuongTextEdit, NoiBHSearchLookUpEdit, NgayVBDateEdit, NguoiKyLookUpEdit, NguoiLuuLookUpEdit, NoiLuuLookUpEdit);
            AutoCompleteStringCollection s = new AutoCompleteStringCollection();
            autoCompleteTableAdapter1.Fill(vSDiDocData.AutoComplete);
            foreach (var v in vSDiDocData.AutoComplete)
                s.Add(v.GoiY);
            TrichYeuTextEdit.AutoCompleteCustomSource = s;
            OnReload();
            _loaiVB = loaivb;
            _Id = id;
            _isEditable = isEditable;
            //SoVBTextEdit.Enabled = !_isEditable;
            barSaveAndNew.Enabled = !_isEditable;
            loaiVanBanTableAdapter1.FillByMaLoaiVB(vSDiDocData.LoaiVanBan, _loaiVB);
            loaiVB = vSDiDocData.LoaiVanBan.FirstOrDefault();
            
        }
        public FrmThongTinVBDi(VSDiDocData.VanBanDiRow vb, bool isCopy=true)
        {
            InitializeComponent();
            SetValidationRule(SoVBTextEdit, TrichYeuTextEdit, SoLuongTextEdit, NoiBHSearchLookUpEdit, NgayVBDateEdit, NguoiKyLookUpEdit, NguoiLuuLookUpEdit, NoiLuuLookUpEdit);
            AutoCompleteStringCollection s = new AutoCompleteStringCollection();
            autoCompleteTableAdapter1.Fill(vSDiDocData.AutoComplete);
            foreach (var v in vSDiDocData.AutoComplete)
                s.Add(v.GoiY);
            TrichYeuTextEdit.AutoCompleteCustomSource = s;
            OnReload();
            _isCopyandNew = isCopy;
            _loaiVB = vb.LoaiVB;
            SoVBTextEdit.Enabled = !_isEditable;
            loaiVanBanTableAdapter1.FillByMaLoaiVB(vSDiDocData.LoaiVanBan, _loaiVB);
            loaiVB = vSDiDocData.LoaiVanBan.FirstOrDefault();
            NoiBHSearchLookUpEdit.EditValue = vb.NoiBH;
            //SoLuongTextEdit.Text = vb.SoLuong.ToString();
            CopyAndNew(vb);
        }

        private void FrmThongTinVBDi_Load(object sender, EventArgs e)
        {
            UseEnableControl = false;
            LockControls(false);

            if(!_isCopyandNew)
                if (!string.IsNullOrEmpty(_Id))
                {
                    this.vanBanDiTableAdapter.FillById(this.vSDiDocData.VanBanDi, _Id);
                    _vb = vSDiDocData.VanBanDi.FirstOrDefault();
                    LoadListChild();
                }
                else
                {
                   
                    var phong = vSDiDocData.PhongBan.FirstOrDefault();
                    NoiBHSearchLookUpEdit.EditValue = phong.MaPhong;
                    OnNew();
                }            
        }

        void CopyAndNew(VSDiDocData.VanBanDiRow vb)
        {
            var ParamVB = vSDiDocData.VanBanParam.Where(x => x.Phong == vb.NoiBH && x.LoaiVB == vb.LoaiVB).FirstOrDefault();
            string sovb = string.Format("{0}{1}", loaiVB.STT + 1, ParamVB.KyHieu);
            _Id = string.Format("{0}.{1}.{2}", _loaiVB, sovb, DateTime.Now.ToString("yyyyMMddHHmmss"));

            this.vanBanDiTableAdapter.FillById(vSDiDocData.VanBanDi, _Id);
            _vb = vSDiDocData.VanBanDi.NewVanBanDiRow();
            _vb.NgayNhap = DateTime.Now;
            _vb.SoLuong = vb.SoLuong;
            _vb.NguoiNhap = HeThong.NguoiDungDangNhap.TenDangNhap;            
            _vb.NoiBH = vb.NoiBH;
            _vb.TrichYeu = vb.TrichYeu;
            _vb.NgayVB = DateTime.Today;
            _vb.NguoiKy = vb.NguoiKy;
            _vb.NguoiLuu = vb.NguoiLuu;
            _vb.NoiLuu = vb.NoiLuu;
            _vb.LoaiVB = _loaiVB;
            _vb.Nam = loaiVB.Nam;
            _vb.SoVB = sovb;
            _vb.Id = _Id;


            //Xóa dữ liệu hiện tại trong bảng Nơi nhận và Đơn vị lưu
            vSDiDocData.NoiNhanVBDi.Clear();
            vSDiDocData.DonViLuuVBDi.Clear();

            //Lấy dữ liệu 2 bảng này của công văn cũ và fill vào công văn mới
            VSDiDocData dsOld = new VSDiDocData();
            this.donViLuuVBDiTableAdapter.FillByVBDi(dsOld.DonViLuuVBDi, vb.Id);
            this.noiNhanVBDiTableAdapter.FillByVBDi(dsOld.NoiNhanVBDi, vb.Id);

            foreach(var x in dsOld.DonViLuuVBDi)
            {                
                var r = vSDiDocData.DonViLuuVBDi.NewDonViLuuVBDiRow();
                r.Id = Guid.NewGuid().ToString();
                r.VBDi = _vb.Id;
                r.DonViLuu = x.DonViLuu;
                vSDiDocData.DonViLuuVBDi.AddDonViLuuVBDiRow(r);
            }

            foreach (var x in dsOld.NoiNhanVBDi)
            {                
                var r = vSDiDocData.NoiNhanVBDi.NewNoiNhanVBDiRow();
                r.Id = Guid.NewGuid().ToString();
                r.VBDi = _vb.Id;
                r.NoiNhan = x.NoiNhan;
                vSDiDocData.NoiNhanVBDi.AddNoiNhanVBDiRow(r);
            }


            vSDiDocData.VanBanDi.AddVanBanDiRow(_vb);

            vanBanDiBindingSource.EndEdit();

            TrichYeuTextEdit.Focus();
        }



        protected override void OnReload()
        {
            
            this.donViTableAdapter.Fill(this.vSDiDocData.DonVi);
                                   
            this.fileLuuTableAdapter.Fill(this.vSDiDocData.FileLuu);
            
            this.nguoiDungTableAdapter.Fill(this.vSDiDocData.NguoiDung);
            
            this.phongBanTableAdapter.Fill(this.vSDiDocData.PhongBan);
            
            vanBanParamTableAdapter1.Fill(this.vSDiDocData.VanBanParam);
        }

        void LoadListChild()
        {
            this.donViLuuVBDiTableAdapter.FillByVBDi(this.vSDiDocData.DonViLuuVBDi, _Id);

            this.noiNhanVBDiTableAdapter.FillByVBDi(this.vSDiDocData.NoiNhanVBDi, _Id);
        }

        protected override void OnNew()
        {
            if (loaiVB == null) return;

            var phong = NoiBHSearchLookUpEdit.EditValue.ToString();

            var ParamVB = vSDiDocData.VanBanParam.Where(x => x.Phong == phong && x.LoaiVB == loaiVB.MaLoaiVB).FirstOrDefault();

            string sovb = string.Format("{0}{1}", loaiVB.STT + 1,ParamVB.KyHieu);
            _Id = string.Format("{0}.{1}.{2}", _loaiVB, sovb, DateTime.Now.ToString("yyyyMMddHHmmss"));

            this.vanBanDiTableAdapter.FillById(vSDiDocData.VanBanDi, _Id);
            _vb = vSDiDocData.VanBanDi.NewVanBanDiRow();
            _vb.NgayNhap = DateTime.Now;
            _vb.SoLuong = 1;
            _vb.NguoiNhap = HeThong.NguoiDungDangNhap.TenDangNhap;

            _vb.NoiBH = phong;

            _vb.NgayVB = DateTime.Today;


            _vb.LoaiVB = _loaiVB;

            _vb.Nam = loaiVB.Nam;
            _vb.SoVB = sovb;            

            _vb.Id = _Id;

            vSDiDocData.VanBanDi.AddVanBanDiRow(_vb);

            vanBanDiBindingSource.EndEdit();

            TrichYeuTextEdit.Focus();
        }

        private void customGridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var r = customGridView1.GetFocusedDataRow() as VSDiDocData.NoiNhanVBDiRow;
            r.Id = Guid.NewGuid().ToString();
            r.VBDi = _Id;
        }

        private void customGridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var r = customGridView2.GetFocusedDataRow() as VSDiDocData.DonViLuuVBDiRow;
            r.Id = Guid.NewGuid().ToString();
            r.VBDi = _Id;
        }

        bool LuuVB()
        {
            string EOL = "\r\n";
            string strNN = "";
            string strDVL = "";
            foreach (var nn in vSDiDocData.NoiNhanVBDi)
            {
                if (nn.DonViRow != null)
                    strNN += nn.DonViRow.TenDonVi + EOL;
            }
                
            foreach (var dv in vSDiDocData.DonViLuuVBDi)
            {
                if (dv.PhongBanRow != null)
                    strDVL += dv.PhongBanRow.KyHieu + EOL;
            }
                

            _vb.NoiNhan = strNN;
            _vb.DViLuu = strDVL;



            var dtVB = vSDiDocData.VanBanDi.GetChanges() as VSDiDocData.VanBanDiDataTable;
            if(dtVB!=null)
            {
                this.vanBanDiTableAdapter.Update(dtVB);
                vSDiDocData.VanBanDi.AcceptChanges(); 
            }
            var dtNN = vSDiDocData.NoiNhanVBDi.GetChanges() as VSDiDocData.NoiNhanVBDiDataTable;
            if (dtNN != null)
            {
                this.noiNhanVBDiTableAdapter.Update(dtNN);
                vSDiDocData.NoiNhanVBDi.AcceptChanges();
            }
                
            var dtDVL = vSDiDocData.DonViLuuVBDi.GetChanges() as VSDiDocData.DonViLuuVBDiDataTable;
            if (dtDVL != null)
            {
                vSDiDocData.DonViLuuVBDi.AcceptChanges();
                this.donViLuuVBDiTableAdapter.Update(dtDVL);
            }
                
            if (!_isEditable)
            {
                loaiVB.STT += 1;
                var lvb = vSDiDocData.LoaiVanBan.GetChanges() as VSDiDocData.LoaiVanBanDataTable;
                loaiVanBanTableAdapter1.Update(lvb);
                vSDiDocData.LoaiVanBan.AcceptChanges();
            }
            return true;
        }


        bool KiemTra()
        {
            // kiem tra moi save chư :D
            dataLayoutControl1.Validate();
            if (!dxValid.Validate()) return false;


            if (customGridView1.HasColumnErrors) return false;
            if (customGridView2.HasColumnErrors) return false;


            vanBanDiBindingSource.EndEdit();
            if (_vb != null)
                if (CheckTrung())
                {
                    MsgBox.ShowErrorDialog(string.Format("Đã tồn tại số văn bản [{0}] trong hệ thống. Vui lòng kiểm tra lại!", _vb.SoVB));
                    return false;
                }
            if(customGridView1.RowCount <= 1)
            {
                MsgBox.ShowErrorDialog("Bạn chưa chọn nơi nhận cho văn bản");
                return false;
            }

            if (customGridView2.RowCount <= 1)
            {
                MsgBox.ShowErrorDialog("Bạn chưa chọn đơn vị lưu văn bản");
                return false;
            }

            return true;            
        }

        bool CheckTrung()
        {
            var data = new VSDiDocData();
            vanBanDiTableAdapter.FillBySoVB(data.VanBanDi, _vb.SoVB, _vb.Nam, _vb.LoaiVB);
            if (data.VanBanDen.Count > 0)
                return true;
            return false;
        }

        bool CheckDuplicate()        
        {

            var duplicate = vSDiDocData.NoiNhanVBDi.GroupBy(r => r.NoiNhan).Where(gr => gr.Count() > 1).ToList();
            if (duplicate.Any())
            {
                MsgBox.ShowErrorDialog("Có giá trị bị trùng trong danh sách nơi nhận");
                return false;
            }                
            return false;
                
        }

        private void NoiBHSearchLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (_isEditable) return;
            NoiBHSearchLookUpEdit.Update();
            if (string.IsNullOrEmpty(NoiBHSearchLookUpEdit.EditValue.ToString())) return;

            if (_vb == null) return;

            _vb.NoiBH = NoiBHSearchLookUpEdit.EditValue.ToString();

            var ParamVB = vSDiDocData.VanBanParam.Where(x => x.Phong == _vb.NoiBH && x.LoaiVB == loaiVB.MaLoaiVB).FirstOrDefault();

            _vb.SoVB = string.Format("{0}{1}", loaiVB.STT + 1, ParamVB.KyHieu);

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!KiemTra()) return;

            if (!LuuVB()) return;

            this.DialogResult = DialogResult.OK;                        
        }

        private void customGridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            customGridView1.SetColumnError(colNoiNhan, e.ErrorText);
        }

        private void customGridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var r = customGridView1.GetFocusedDataRow() as VSDiDocData.NoiNhanVBDiRow;
            if (r == null) return;
            if (r.IsNoiNhanNull())
            {
                e.Valid = false;
                e.ErrorText = "Chọn nơi nhận";
                return;
            }

            //var count = vSDiDocData.NoiNhanVBDi.Where(t => t.NoiNhan == r.NoiNhan).Count();
            //if (count > 0)
            //{
            //    e.Valid = false;
            //    e.ErrorText = "Nơi nhận không được trùng";
            //}

        }

        private void barSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!KiemTra()) return;
            if (LuuVB())
            {
                if (_isEditable)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else if (MsgBox.ShowYesNoDialog("Giao dịch thành công! Bạn có muốn tiếp tục lấy số?") == DialogResult.Yes)
                {
                    VSDiDocData old = new VSDiDocData();
                    vSDiDocData.VanBanDi.CopyToDataTable(old.VanBanDi, LoadOption.Upsert);
                    vSDiDocData.NoiNhanVBDi.CopyToDataTable(old.NoiNhanVBDi, LoadOption.Upsert);
                    vSDiDocData.DonViLuuVBDi.CopyToDataTable(old.DonViLuuVBDi, LoadOption.Upsert);
                    CopyAndNew(old.VanBanDi.FirstOrDefault());

                    LockControls(false);

                }
                else
                    this.DialogResult = DialogResult.OK;
            }
        }

        private void customGridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var r = customGridView2.GetFocusedDataRow() as VSDiDocData.DonViLuuVBDiRow;
            if (r == null) return;
            if (r.IsDonViLuuNull())
            {
                e.Valid = false;
                e.ErrorText = "Chọn đơn vị lưu";
                return;
            }

            //var count = vSDiDocData.DonViLuuVBDi.Where(t => t.DonViLuu == r.DonViLuu).Count();
            //if (count > 0)
            //{
            //    e.Valid = false;
            //    e.ErrorText = "Đơn vị nhận bản lưu không được trùng";
            //}
        }

        private void customGridView2_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            customGridView2.SetColumnError(colDonViLuu, e.ErrorText);
        }
    }
}
