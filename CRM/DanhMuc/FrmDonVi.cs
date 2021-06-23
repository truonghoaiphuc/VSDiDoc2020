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
    public partial class FrmDonVi : FrmBase
    {
        string _Id = string.Empty;

        public string ID {
            get { return _Id; }
            set { _Id = value; }
        }
        public FrmDonVi(string Id)
        {
            InitializeComponent();
            SetValidationRule(TenDonViTextEdit);
            _Id = Id;
            QuanLyImageComboBoxEdit.Properties.Items.AddEnum(typeof(NoiQuanLy),true);
            Bindings();
        }

        private void FrmDonVi_Load(object sender, EventArgs e)
        {

        }

        private void Bindings()
        {
            this.donViTableAdapter.FillByID(vSDiDocData.DonVi, _Id);
            if(string.IsNullOrEmpty(_Id))
            {
                var t = vSDiDocData.DonVi.NewDonViRow();
                t.Id = _Id = Guid.NewGuid().ToString();
                t.MaDonVi = "";
                t.IsTVLK = false;
                t.QuanLy = (int)NoiQuanLy.CNHCM;
                vSDiDocData.DonVi.AddDonViRow(t);
                donViBindingSource.EndEdit();
            }

            var dv = vSDiDocData.DonVi.FirstOrDefault();
            if (dv == null) return;
        }

        protected override bool OnSave()
        {
            dataLayoutControl1.Validate();
            if (!dxValid.Validate()) return false;
            donViBindingSource.EndEdit();            
            try
            {
                var dt = vSDiDocData.DonVi.GetChanges() as VSDiDocData.DonViDataTable;
                if (dt != null)
                {
                    donViTableAdapter.Update(dt);
                    vSDiDocData.DonVi.AcceptChanges();
                }                
                this.DialogResult = DialogResult.OK;
                return true;
            }
            catch (Exception ex)
            {
                MsgBox.ShowErrorDialog(ex.Message);
                return false;
            }
        }
    }
}
