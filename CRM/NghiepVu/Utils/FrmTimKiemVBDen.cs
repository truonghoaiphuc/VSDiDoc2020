using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using Lotus.Base;
using Lotus.Libraries;
using Lotus;

namespace VSDiDoc.NghiepVu
{
    public partial class FrmTimKiemVBDen : FrmBase
    {
        private DateEdit dtDate = new DateEdit();
        private TextEdit txtText = new TextEdit();
        private ImageComboBoxEdit cboStatus = new ImageComboBoxEdit();
        private LookUpEdit lkeDonVi = new LookUpEdit();
        private LookUpEdit lkeChungtu = new LookUpEdit();
        private SpinEdit spNumber = new SpinEdit();

        List<SearchCrieria> lstCriteria;
        List<SearchCondition> lstCondition;
        

        
        private string _maloai="";

        public string LoaiVB
        {
            get { return _maloai; }
            set { _maloai = value; }
        }

        public FrmTimKiemVBDen()
        {
            InitializeComponent();
            repositoryItemImageComboBox2.Items.AddEnum(typeof(Status),true);
            repositoryItemImageComboBox3.Items.AddEnum(typeof(Buoi),true);
            //_maloai = "CTNV";
            //xpcChungTu.Criteria = CriteriaOperator.Parse("LoaiVB.MaLoaiVB=?", _maloai);
            //xpvCTD.CriteriaString = string.Format("LoaiVB.MaLoaiVB='{0}'", _maloai);
            // TODO: This line of code loads data into the 'vSDiDocData.DonVi' table. You can move, or remove it, as needed.
            this.donViTableAdapter.Fill(this.vSDiDocData.DonVi);
            nguoiDungTableAdapter1.Fill(vSDiDocData.NguoiDung);            
            InitControl();
            lstCondition = SearchCondition.GetAllCondition();
            lstCriteria = InitCriteria();
            lkeTieuChi.Properties.DataSource = lstCriteria;
            lkeTieuChi.EditValue = lstCriteria[0].FieldName;
            btnSearch.PerformClick();
        }

        List<SearchCrieria> InitCriteria()
        {
            List<SearchCrieria> list = new List<SearchCrieria>();
            list.Add(new SearchCrieria() { FieldCaption = "Năm", FieldName = "Nam", type = FieldType.NUMBER, Controls = spNumber });
            list.Add(new SearchCrieria() { FieldCaption = "Ngày nhập", FieldName = "NgayNhap", type = FieldType.DATE, Controls = dtDate });
            list.Add(new SearchCrieria() { FieldCaption = "Ngày nhận", FieldName = "NgayNhan", type = FieldType.DATE, Controls = dtDate });
            list.Add(new SearchCrieria() { FieldCaption = "Loại chứng từ", FieldName = "ChungTu.MaCT", type = FieldType.DEFAULT, Controls = lkeChungtu });
            list.Add(new SearchCrieria() { FieldCaption = "Số văn bản", FieldName = "SoVB", type = FieldType.STRING, Controls = txtText });
            list.Add(new SearchCrieria() { FieldCaption = "Ký hiệu", FieldName = "KyHieu", type = FieldType.STRING, Controls = txtText });
            list.Add(new SearchCrieria() { FieldCaption = "Nơi ban hành văn bản", FieldName = "NoiGui", type = FieldType.DEFAULT, Controls = lkeDonVi });
            list.Add(new SearchCrieria() { FieldCaption = "Trích yếu", FieldName = "TrichYeu", type = FieldType.STRING, Controls = txtText });
            list.Add(new SearchCrieria() { FieldCaption = "Ngày văn bản", FieldName = "NgayVB", type = FieldType.DATE, Controls = dtDate });
            list.Add(new SearchCrieria() { FieldCaption = "Trạng thái", FieldName = "Status", type = FieldType.DEFAULT, Controls = cboStatus });
            list.Add(new SearchCrieria() { FieldCaption = "Ghi chú", FieldName = "GhiChu", type = FieldType.STRING, Controls = txtText });
            return list;
        }

        void InitControl()
        {
            spNumber.Dock = DockStyle.Fill;
            cboStatus.Dock = DockStyle.Fill;
            cboStatus.Properties.Items.AddEnum(typeof(Status));
            cboStatus.SelectedIndex = 0;
            txtText.Dock = DockStyle.Fill;
            dtDate.Dock = DockStyle.Fill;
            dtDate.DateTime = DateTime.Today;
            lkeDonVi.Dock = DockStyle.Fill;
            lkeDonVi.Properties.DataSource = vSDiDocData.DonVi;
            lkeDonVi.Properties.DisplayMember = "FullDonVi";
            lkeDonVi.Properties.ValueMember = "Id";
            lkeDonVi.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullDonVi"));
            lkeDonVi.Properties.ShowHeader = false;
            if (vSDiDocData.DonVi.Count > 0)
                lkeDonVi.EditValue = (vSDiDocData.DonVi.FirstOrDefault()).Id;
            lkeChungtu.Dock = DockStyle.Fill;
            lkeChungtu.Properties.DataSource = vSDiDocData.ChungTu;
            lkeChungtu.Properties.DisplayMember = "FullCT";
            lkeChungtu.Properties.ValueMember = "MaCT";
            lkeChungtu.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullCT"));
            lkeChungtu.Properties.ShowHeader = false;
            if (vSDiDocData.ChungTu.Count > 0)
                lkeChungtu.EditValue = (vSDiDocData.ChungTu.FirstOrDefault()).MaCT;
        }

        private void lkeTieuChi_EditValueChanged(object sender, EventArgs e)
        {
            if (lkeTieuChi.EditValue == null) return;
            var sc = lstCriteria.FirstOrDefault(t => t.FieldName == lkeTieuChi.EditValue) as SearchCrieria;
            gGiatri.Controls.Clear();
            gGiatri.Controls.Add(sc.Controls);
            List<SearchCondition> lst = SearchCondition.GetConditionBy(lstCondition, sc.type);
            lkeDieuKien.Properties.DataSource = lst;
            if (lst.Count > 0) lkeDieuKien.EditValue = lst[0].Value;
        }

        private void btnAddDK_Click(object sender, EventArgs e)
        {
            var sc = lstCriteria.FirstOrDefault(t => t.FieldName == lkeTieuChi.EditValue) as SearchCrieria;
            if (gGiatri.Controls[0] is DateEdit)
            {
                DateEdit dt = (DateEdit)gGiatri.Controls[0];
                lstDieukien.Items.Add(string.Format(lkeDieuKien.EditValue.ToString(), sc.FieldName, dt.DateTime.ToString("MM/dd/yyyy")),
                                        string.Format("{0} {1} {2}", lkeTieuChi.Text, lkeDieuKien.Text, dt.DateTime.ToString("dd/MM/yyyy")), CheckState.Checked, true);
            }
            else if (gGiatri.Controls[0] is LookUpEdit)
            {
                LookUpEdit lke = (LookUpEdit)gGiatri.Controls[0];
                lstDieukien.Items.Add(string.Format(lkeDieuKien.EditValue.ToString(), sc.FieldName, lke.EditValue.ToString()),
                                        string.Format("{0} {1} {2}", lkeTieuChi.Text, lkeDieuKien.Text, lke.Text), CheckState.Checked, true);
            }
            else if (gGiatri.Controls[0] is ImageComboBoxEdit)
            {
                ImageComboBoxEdit img = (ImageComboBoxEdit)gGiatri.Controls[0];
                lstDieukien.Items.Add(string.Format(lkeDieuKien.EditValue.ToString(), sc.FieldName, (int)img.EditValue),
                                        string.Format("{0} {1} {2}", lkeTieuChi.Text, lkeDieuKien.Text, img.Text), CheckState.Checked, true);
            }
            else if (gGiatri.Controls[0] is SpinEdit)
            {
                SpinEdit spin = (SpinEdit)gGiatri.Controls[0];
                lstDieukien.Items.Add(string.Format(lkeDieuKien.EditValue.ToString(), sc.FieldName, spin.EditValue),
                                        string.Format("{0} {1} {2}", lkeTieuChi.Text, lkeDieuKien.Text, spin.EditValue.ToString()), CheckState.Checked, true);
            }
            else if (gGiatri.Controls[0] is TextEdit)
            {
                TextEdit txt = (TextEdit)gGiatri.Controls[0];
                lstDieukien.Items.Add(string.Format(lkeDieuKien.EditValue.ToString(), sc.FieldName, txt.Text),
                                        string.Format("{0} {1} {2}", lkeTieuChi.Text, lkeDieuKien.Text, txt.Text), CheckState.Checked, true);
            }            
        }

        string BuildCondition()
        {
            //string strList = string.Format("LoaiVB='{0}'",_maloai);
            string strList = "";
            if (lstDieukien.Items.Count == 0) return strList;
            for (int i = 0; i < lstDieukien.Items.Count; i++)
            {
                if (lstDieukien.Items[i].CheckState == CheckState.Unchecked) continue;
                strList += " AND " + lstDieukien.Items[i].Value.ToString();
            }
            return strList;
        }

        private void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MsgBox.ShowWaitForm();
            //xpcVBD.CriteriaString = BuildCondition();
            //xpvCTD.CriteriaString = BuildCondition();
            //UOW.ReloadChangedObjects();
            //xpcVBD.Reload();
            MsgBox.CloseWaitForm();
        }

        private void btnRemoveDK_Click(object sender, EventArgs e)
        {
            if (lstDieukien.Items.Count == 0) return;
            lstDieukien.Items.RemoveAt(lstDieukien.SelectedIndex);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lstDieukien.Items.Count == 0) return;
            lstDieukien.Items.Clear();
        }

        private void FrmTimKiemCTDen_Load(object sender, EventArgs e)
        {            
            UseEnableControl = false;
            LockControls(false);            
        }
        protected override void OnReload()
        {
            chungTuTableAdapter1.FillByLoaiVB(vSDiDocData.ChungTu, _maloai);
            string strSQL = string.Format("select * from VanBanDen vb join ChungTu ct on vb.ChungTu=ct.MaCT where 1=1 and vb.LoaiVB='{0}' ",_maloai);
            strSQL += BuildCondition();
            DataSet ds = SQLHelper.ExecuteDataset(strSQL);
            customGridControl1.DataSource = ds.Tables[0];

            //vanBanDenTableAdapter.FillBySearchVBDen(vSDiDocData.VanBanDen, BuildCondition());

        }
    }
}