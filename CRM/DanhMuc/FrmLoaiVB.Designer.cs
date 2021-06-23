namespace VSDiDoc.DanhMuc
{
    partial class FrmLoaiVB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiVB));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.customGridControl1 = new Lotus.Libraries.CustomGridControl();
            this.loaiVanBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSDiDocData = new VSDiDoc.VSDiDocData();
            this.customGridView1 = new Lotus.Libraries.CustomGridView();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiVB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiVB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCVD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.loaiVanBanTableAdapter = new VSDiDoc.VSDiDocDataTableAdapters.LoaiVanBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSDiDocData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // bm
            // 
            this.bm.MaxItemId = 12;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.ImageOptions.Image")));
            this.btnPrintPreview.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.ImageOptions.LargeImage")));
            // 
            // rgCollection
            // 
            this.rgCollection.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rgCalc,
            this.rgDate,
            this.rgSpin});
            // 
            // rgCalc
            // 
            this.rgCalc.DisplayFormat.FormatString = "#,#0.##;(#,#0.##);-";
            this.rgCalc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.rgCalc.EditFormat.FormatString = "#,#0.##;(#,#0.##);-";
            this.rgCalc.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            // 
            // rgDate
            // 
            // 
            // bar1
            // 
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintPreview)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            // 
            // rgSpin
            // 
            this.rgSpin.DisplayFormat.FormatString = "#,#0.##;(#,#0.##);-";
            this.rgSpin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.rgSpin.EditFormat.FormatString = "#,#0.##;(#,#0.##);-";
            this.rgSpin.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.customGridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 47);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(876, 570);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // customGridControl1
            // 
            this.customGridControl1.DataSource = this.loaiVanBanBindingSource;
            this.customGridControl1.Location = new System.Drawing.Point(9, 33);
            this.customGridControl1.MainView = this.customGridView1;
            this.customGridControl1.MenuManager = this.bm;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.Size = new System.Drawing.Size(858, 528);
            this.customGridControl1.TabIndex = 4;
            this.customGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // loaiVanBanBindingSource
            // 
            this.loaiVanBanBindingSource.DataMember = "LoaiVanBan";
            this.loaiVanBanBindingSource.DataSource = this.vSDiDocData;
            // 
            // vSDiDocData
            // 
            this.vSDiDocData.DataSetName = "VSDiDocData";
            this.vSDiDocData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customGridView1
            // 
            this.customGridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.customGridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customGridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.customGridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.customGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.customGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customGridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customGridView1.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.customGridView1.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.customGridView1.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.customGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGhiChu,
            this.colMaLoaiVB,
            this.colTenLoaiVB,
            this.colSTT,
            this.colIsCVD,
            this.colNam});
            this.customGridView1.FixedLineWidth = 1;
            this.customGridView1.FormatCode = null;
            this.customGridView1.GridControl = this.customGridControl1;
            this.customGridView1.GroupFormat = "[#image]{1} {2}";
            this.customGridView1.IndicatorWidth = -1;
            this.customGridView1.KeyColumn = "MaLoaiVB";
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.NotNullColumns = "TenLoaiVB;STT;Nam";
            this.customGridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.customGridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.customGridView1.OptionsView.ShowDetailButtons = false;
            this.customGridView1.ShowIndexIndicator = false;
            this.customGridView1.UseAutoCode = false;
            this.customGridView1.UseAutoLog = false;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 5;
            this.colGhiChu.Width = 172;
            // 
            // colMaLoaiVB
            // 
            this.colMaLoaiVB.AppearanceCell.Options.UseTextOptions = true;
            this.colMaLoaiVB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaLoaiVB.FieldName = "MaLoaiVB";
            this.colMaLoaiVB.Name = "colMaLoaiVB";
            this.colMaLoaiVB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colMaLoaiVB.Visible = true;
            this.colMaLoaiVB.VisibleIndex = 0;
            this.colMaLoaiVB.Width = 110;
            // 
            // colTenLoaiVB
            // 
            this.colTenLoaiVB.FieldName = "TenLoaiVB";
            this.colTenLoaiVB.Name = "colTenLoaiVB";
            this.colTenLoaiVB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTenLoaiVB.Visible = true;
            this.colTenLoaiVB.VisibleIndex = 1;
            this.colTenLoaiVB.Width = 177;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            this.colSTT.Width = 81;
            // 
            // colIsCVD
            // 
            this.colIsCVD.FieldName = "IsCVD";
            this.colIsCVD.Name = "colIsCVD";
            this.colIsCVD.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colIsCVD.Visible = true;
            this.colIsCVD.VisibleIndex = 3;
            // 
            // colNam
            // 
            this.colNam.FieldName = "Nam";
            this.colNam.Name = "colNam";
            this.colNam.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(876, 570);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup2.CaptionImage")));
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup2.Size = new System.Drawing.Size(872, 566);
            this.layoutControlGroup2.Text = "Danh sách Loại văn bản";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.customGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(862, 532);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // loaiVanBanTableAdapter
            // 
            this.loaiVanBanTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLoaiVB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 617);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmLoaiVB";
            this.Text = "Loại văn bản";
            this.Load += new System.EventHandler(this.FrmLoaiVB_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiVanBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSDiDocData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private Lotus.Libraries.CustomGridControl customGridControl1;
        private Lotus.Libraries.CustomGridView customGridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private VSDiDocData vSDiDocData;
        private System.Windows.Forms.BindingSource loaiVanBanBindingSource;
        private VSDiDocDataTableAdapters.LoaiVanBanTableAdapter loaiVanBanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiVB;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiVB;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCVD;
        private DevExpress.XtraGrid.Columns.GridColumn colNam;
    }
}