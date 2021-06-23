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
    public partial class FrmSelectTVLK : FrmBase
    {
        private string _MaTVLK;
        public string TVLK
        {
            get { return _MaTVLK; }
            set { _MaTVLK = value; }
        }

        public FrmSelectTVLK()
        {
            InitializeComponent();
        }
        private void FrmSelectTVLK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vSDiDocData.TVLK' table. You can move, or remove it, as needed.
            OnReload();
        }

        protected override void OnReload()
        {
            this.tVLKTableAdapter.Fill(this.vSDiDocData.TVLK);
            var tvlk = vSDiDocData.TVLK.FirstOrDefault();
            if (tvlk != null)
                lookUpEdit1.EditValue = tvlk.MaTVLK;
        }
        private void lookUpEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _MaTVLK = lookUpEdit1.EditValue.ToString(); 
                this.Close();
            }                
        }
    }
}
