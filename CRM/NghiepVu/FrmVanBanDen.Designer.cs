namespace VSDiDoc.NghiepVu
{
    partial class FrmVanBanDen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVanBanDen));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.customGridControl1 = new Lotus.Libraries.CustomGridControl();
            this.vanBanDenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSDiDocData = new VSDiDoc.VSDiDocData();
            this.customGridView1 = new Lotus.Libraries.CustomGridView();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoVB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.chungTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNoiGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.donViBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTrichYeu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayVB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayChuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.vanBanDenTableAdapter = new VSDiDoc.VSDiDocDataTableAdapters.VanBanDenTableAdapter();
            this.donViTableAdapter = new VSDiDoc.VSDiDocDataTableAdapters.DonViTableAdapter();
            this.chungTuTableAdapter = new VSDiDoc.VSDiDocDataTableAdapters.ChungTuTableAdapter();
            this.barNewAB = new DevExpress.XtraBars.BarLargeButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSDiDocData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.SuspendLayout();
            // 
            // bm
            // 
            this.bm.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barNewAB});
            this.bm.MaxItemId = 30;
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
            this.btnAdd.Caption = "Lấy số";
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
            this.btnSave.Caption = "Lấy số AB";
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barNewAB),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintPreview),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint)});
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
            this.layoutControl1.Location = new System.Drawing.Point(0, 94);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(980, 611);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // customGridControl1
            // 
            this.customGridControl1.DataSource = this.vanBanDenBindingSource;
            this.customGridControl1.Location = new System.Drawing.Point(8, 32);
            this.customGridControl1.MainView = this.customGridView1;
            this.customGridControl1.MenuManager = this.bm;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.customGridControl1.Size = new System.Drawing.Size(964, 571);
            this.customGridControl1.TabIndex = 15;
            this.customGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // vanBanDenBindingSource
            // 
            this.vanBanDenBindingSource.DataMember = "VanBanDen";
            this.vanBanDenBindingSource.DataSource = this.vSDiDocData;
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
            this.colNgayNhap,
            this.colNam,
            this.colNgayNhan,
            this.colSoVB,
            this.colKyHieu,
            this.colChungTu,
            this.colNoiGui,
            this.colTrichYeu,
            this.colNgayVB,
            this.colNguoiNhap,
            this.colSoLuong,
            this.colNgayChuyen,
            this.colNgayGiao});
            this.customGridView1.FixedLineWidth = 1;
            this.customGridView1.FormatCode = null;
            this.customGridView1.GridControl = this.customGridControl1;
            this.customGridView1.GroupFormat = "[#image]{1} {2}";
            this.customGridView1.IndicatorWidth = -1;
            this.customGridView1.KeyColumn = null;
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.NotNullColumns = null;
            this.customGridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.customGridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.customGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.customGridView1.ShowIndexIndicator = false;
            this.customGridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSoVB, DevExpress.Data.ColumnSortOrder.Descending)});
            this.customGridView1.UseAutoCode = false;
            this.customGridView1.UseAutoLog = false;
            this.customGridView1.DoubleClick += new System.EventHandler(this.customGridView1_DoubleClick);
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.OptionsColumn.AllowFocus = false;
            this.colGhiChu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            this.colGhiChu.Width = 182;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayNhap.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayNhap.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colNgayNhap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayNhap.FieldName = "NgayNhap";
            this.colNgayNhap.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.OptionsColumn.AllowEdit = false;
            this.colNgayNhap.OptionsColumn.AllowFocus = false;
            this.colNgayNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgayNhap.Visible = true;
            this.colNgayNhap.VisibleIndex = 0;
            this.colNgayNhap.Width = 106;
            // 
            // colNam
            // 
            this.colNam.FieldName = "Nam";
            this.colNam.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNam.Name = "colNam";
            this.colNam.OptionsColumn.AllowEdit = false;
            this.colNam.OptionsColumn.AllowFocus = false;
            this.colNam.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 2;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayNhan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayNhan.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.colNgayNhan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayNhan.FieldName = "NgayNhan";
            this.colNgayNhan.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.OptionsColumn.AllowEdit = false;
            this.colNgayNhan.OptionsColumn.AllowFocus = false;
            this.colNgayNhan.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgayNhan.Visible = true;
            this.colNgayNhan.VisibleIndex = 3;
            this.colNgayNhan.Width = 113;
            // 
            // colSoVB
            // 
            this.colSoVB.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colSoVB.AppearanceCell.ForeColor = System.Drawing.Color.Navy;
            this.colSoVB.AppearanceCell.Options.UseFont = true;
            this.colSoVB.AppearanceCell.Options.UseForeColor = true;
            this.colSoVB.AppearanceCell.Options.UseTextOptions = true;
            this.colSoVB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoVB.FieldName = "SoVB";
            this.colSoVB.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colSoVB.Name = "colSoVB";
            this.colSoVB.OptionsColumn.AllowEdit = false;
            this.colSoVB.OptionsColumn.AllowFocus = false;
            this.colSoVB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSoVB.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colSoVB.Visible = true;
            this.colSoVB.VisibleIndex = 1;
            this.colSoVB.Width = 81;
            // 
            // colKyHieu
            // 
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.OptionsColumn.AllowEdit = false;
            this.colKyHieu.OptionsColumn.AllowFocus = false;
            this.colKyHieu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colKyHieu.Visible = true;
            this.colKyHieu.VisibleIndex = 4;
            this.colKyHieu.Width = 103;
            // 
            // colChungTu
            // 
            this.colChungTu.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colChungTu.FieldName = "ChungTu";
            this.colChungTu.Name = "colChungTu";
            this.colChungTu.OptionsColumn.AllowEdit = false;
            this.colChungTu.OptionsColumn.AllowFocus = false;
            this.colChungTu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colChungTu.Visible = true;
            this.colChungTu.VisibleIndex = 8;
            this.colChungTu.Width = 160;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenCT", "Tên chứng từ", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.chungTuBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "TenCT";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "MaCT";
            // 
            // chungTuBindingSource
            // 
            this.chungTuBindingSource.DataMember = "ChungTu";
            this.chungTuBindingSource.DataSource = this.vSDiDocData;
            // 
            // colNoiGui
            // 
            this.colNoiGui.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colNoiGui.FieldName = "NoiGui";
            this.colNoiGui.Name = "colNoiGui";
            this.colNoiGui.OptionsColumn.AllowEdit = false;
            this.colNoiGui.OptionsColumn.AllowFocus = false;
            this.colNoiGui.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNoiGui.Visible = true;
            this.colNoiGui.VisibleIndex = 5;
            this.colNoiGui.Width = 270;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDonVi", "Tên đơn vị", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.donViBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "FullDonVi";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "Id";
            // 
            // donViBindingSource
            // 
            this.donViBindingSource.DataMember = "DonVi";
            this.donViBindingSource.DataSource = this.vSDiDocData;
            // 
            // colTrichYeu
            // 
            this.colTrichYeu.FieldName = "TrichYeu";
            this.colTrichYeu.Name = "colTrichYeu";
            this.colTrichYeu.OptionsColumn.AllowEdit = false;
            this.colTrichYeu.OptionsColumn.AllowFocus = false;
            this.colTrichYeu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTrichYeu.Visible = true;
            this.colTrichYeu.VisibleIndex = 6;
            this.colTrichYeu.Width = 275;
            // 
            // colNgayVB
            // 
            this.colNgayVB.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayVB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayVB.FieldName = "NgayVB";
            this.colNgayVB.Name = "colNgayVB";
            this.colNgayVB.OptionsColumn.AllowEdit = false;
            this.colNgayVB.OptionsColumn.AllowFocus = false;
            this.colNgayVB.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgayVB.Visible = true;
            this.colNgayVB.VisibleIndex = 7;
            this.colNgayVB.Width = 99;
            // 
            // colNguoiNhap
            // 
            this.colNguoiNhap.FieldName = "NguoiNhap";
            this.colNguoiNhap.Name = "colNguoiNhap";
            this.colNguoiNhap.OptionsColumn.AllowEdit = false;
            this.colNguoiNhap.OptionsColumn.AllowFocus = false;
            this.colNguoiNhap.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNguoiNhap.Visible = true;
            this.colNguoiNhap.VisibleIndex = 10;
            this.colNguoiNhap.Width = 140;
            // 
            // colSoLuong
            // 
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowEdit = false;
            this.colSoLuong.OptionsColumn.AllowFocus = false;
            this.colSoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 11;
            // 
            // colNgayChuyen
            // 
            this.colNgayChuyen.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayChuyen.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayChuyen.FieldName = "NgayChuyen";
            this.colNgayChuyen.Name = "colNgayChuyen";
            this.colNgayChuyen.OptionsColumn.AllowEdit = false;
            this.colNgayChuyen.OptionsColumn.AllowFocus = false;
            this.colNgayChuyen.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgayChuyen.Visible = true;
            this.colNgayChuyen.VisibleIndex = 12;
            this.colNgayChuyen.Width = 114;
            // 
            // colNgayGiao
            // 
            this.colNgayGiao.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayGiao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayGiao.FieldName = "NgayGiao";
            this.colNgayGiao.Name = "colNgayGiao";
            this.colNgayGiao.OptionsColumn.AllowEdit = false;
            this.colNgayGiao.OptionsColumn.AllowFocus = false;
            this.colNgayGiao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colNgayGiao.Visible = true;
            this.colNgayGiao.VisibleIndex = 13;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(980, 611);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup3.CaptionImage")));
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutControlGroup3.Size = new System.Drawing.Size(976, 607);
            this.layoutControlGroup3.Text = "Danh sách văn bản";
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.customGridControl1;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(968, 575);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // vanBanDenTableAdapter
            // 
            this.vanBanDenTableAdapter.ClearBeforeFill = true;
            // 
            // donViTableAdapter
            // 
            this.donViTableAdapter.ClearBeforeFill = true;
            // 
            // chungTuTableAdapter
            // 
            this.chungTuTableAdapter.ClearBeforeFill = true;
            // 
            // barNewAB
            // 
            this.barNewAB.Caption = "Lấy số AB";
            this.barNewAB.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barNewAB.Id = 28;
            this.barNewAB.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barNewAB.ImageOptions.Image")));
            this.barNewAB.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barNewAB.ImageOptions.LargeImage")));
            this.barNewAB.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.N));
            this.barNewAB.Name = "barNewAB";
            this.barNewAB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNewAB_ItemClick);
            // 
            // FrmVanBanDen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 705);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmVanBanDen";
            this.Text = "Văn bản đến";
            this.Load += new System.EventHandler(this.FrmVanBanDen_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vanBanDenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSDiDocData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chungTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private Lotus.Libraries.CustomGridControl customGridControl1;
        private Lotus.Libraries.CustomGridView customGridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private VSDiDocData vSDiDocData;
        private System.Windows.Forms.BindingSource vanBanDenBindingSource;
        private VSDiDocDataTableAdapters.VanBanDenTableAdapter vanBanDenTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colNam;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoVB;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiGui;
        private DevExpress.XtraGrid.Columns.GridColumn colTrichYeu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayVB;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGiao;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource donViBindingSource;
        private VSDiDocDataTableAdapters.DonViTableAdapter donViTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource chungTuBindingSource;
        private VSDiDocDataTableAdapters.ChungTuTableAdapter chungTuTableAdapter;
        private DevExpress.XtraBars.BarLargeButtonItem barNewAB;
    }
}