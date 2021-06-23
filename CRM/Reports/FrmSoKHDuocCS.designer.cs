﻿namespace CRM.Reports
{
    partial class FrmSoKHDuocCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoKHDuocCS));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.customGridControl1 = new Lotus.Libraries.CustomGridControl();
            this.soKHCSTheoNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataReport = new CRM.DataReport();
            this.customGridView1 = new Lotus.Libraries.CustomGridView();
            this.colSoKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoKHCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTiLeCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTiLeKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.rsearchNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTrangThai = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repHinhThuc = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.repKhachHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.soKHCSTheoNhanVienTableAdapter = new CRM.DataReportTableAdapters.SoKHCSTheoNhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soKHCSTheoNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsearchNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHinhThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDateFrom
            // 
            this.itemDateFrom.EditValue = new System.DateTime(2018, 9, 1, 0, 0, 0, 0);
            this.itemDateFrom.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // itemDateTo
            // 
            this.itemDateTo.EditValue = new System.DateTime(2018, 9, 30, 23, 59, 59, 0);
            // 
            // itemMonth
            // 
            this.itemMonth.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            // 
            // itemYear
            // 
            this.itemYear.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            // 
            // itemType
            // 
            this.itemType.EditValue = 2;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.ImageOptions.Image")));
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintPreview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.layoutControl1.Location = new System.Drawing.Point(0, 62);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(316, 136, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(990, 525);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // customGridControl1
            // 
            this.customGridControl1.DataSource = this.soKHCSTheoNhanVienBindingSource;
            this.customGridControl1.ExternalRepository = this.rgCollection;
            this.customGridControl1.Location = new System.Drawing.Point(2, 2);
            this.customGridControl1.MainView = this.customGridView1;
            this.customGridControl1.MenuManager = this.bm;
            this.customGridControl1.Name = "customGridControl1";
            this.customGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rsearchNhanVien,
            this.repTrangThai,
            this.repHinhThuc,
            this.repKhachHang,
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.customGridControl1.Size = new System.Drawing.Size(986, 497);
            this.customGridControl1.TabIndex = 4;
            this.customGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customGridView1});
            // 
            // soKHCSTheoNhanVienBindingSource
            // 
            this.soKHCSTheoNhanVienBindingSource.DataMember = "SoKHCSTheoNhanVien";
            this.soKHCSTheoNhanVienBindingSource.DataSource = this.dataReport;
            // 
            // dataReport
            // 
            this.dataReport.DataSetName = "DataReport";
            this.dataReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colSoKH,
            this.colTenNhom,
            this.colSLCS,
            this.colSoKHCS,
            this.colTiLeCS,
            this.colTiLeKH});
            this.customGridView1.FixedLineWidth = 1;
            this.customGridView1.FormatCode = null;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Blue";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            this.customGridView1.FormatRules.Add(gridFormatRule1);
            this.customGridView1.GridControl = this.customGridControl1;
            this.customGridView1.GroupFormat = "[#image]{1} {2}";
            this.customGridView1.IndicatorWidth = 31;
            this.customGridView1.KeyColumn = "TenBL";
            this.customGridView1.Name = "customGridView1";
            this.customGridView1.NotNullColumns = "TenPhapLy";
            this.customGridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.customGridView1.OptionsDetail.EnableMasterViewMode = false;
            this.customGridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.customGridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            this.customGridView1.OptionsView.ShowFooter = true;
            this.customGridView1.ShowIndexIndicator = true;
            this.customGridView1.UseAutoCode = false;
            this.customGridView1.UseAutoLog = true;
            this.customGridView1.DoubleClick += new System.EventHandler(this.customGridView1_DoubleClick);
            // 
            // colSoKH
            // 
            this.colSoKH.DisplayFormat.FormatString = "#,#0";
            this.colSoKH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoKH.FieldName = "SoKH";
            this.colSoKH.Name = "colSoKH";
            this.colSoKH.OptionsColumn.AllowEdit = false;
            this.colSoKH.OptionsColumn.AllowFocus = false;
            this.colSoKH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSoKH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoKH", "{0:0.##}")});
            this.colSoKH.Visible = true;
            this.colSoKH.VisibleIndex = 1;
            this.colSoKH.Width = 123;
            // 
            // colTenNhom
            // 
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.OptionsColumn.AllowEdit = false;
            this.colTenNhom.OptionsColumn.AllowFocus = false;
            this.colTenNhom.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            this.colTenNhom.Width = 206;
            // 
            // colSLCS
            // 
            this.colSLCS.DisplayFormat.FormatString = "#,#0";
            this.colSLCS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSLCS.FieldName = "SLCS";
            this.colSLCS.Name = "colSLCS";
            this.colSLCS.OptionsColumn.AllowEdit = false;
            this.colSLCS.OptionsColumn.AllowFocus = false;
            this.colSLCS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSLCS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SLCS", "{0:#,#0}")});
            this.colSLCS.Visible = true;
            this.colSLCS.VisibleIndex = 4;
            this.colSLCS.Width = 132;
            // 
            // colSoKHCS
            // 
            this.colSoKHCS.DisplayFormat.FormatString = "#,#0";
            this.colSoKHCS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoKHCS.FieldName = "SoKHCS";
            this.colSoKHCS.Name = "colSoKHCS";
            this.colSoKHCS.OptionsColumn.AllowEdit = false;
            this.colSoKHCS.OptionsColumn.AllowFocus = false;
            this.colSoKHCS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSoKHCS.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoKHCS", "{0:#,#0}")});
            this.colSoKHCS.Visible = true;
            this.colSoKHCS.VisibleIndex = 2;
            this.colSoKHCS.Width = 123;
            // 
            // colTiLeCS
            // 
            this.colTiLeCS.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colTiLeCS.DisplayFormat.FormatString = "#,#0.##";
            this.colTiLeCS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiLeCS.FieldName = "TiLeCS";
            this.colTiLeCS.Name = "colTiLeCS";
            this.colTiLeCS.OptionsColumn.AllowEdit = false;
            this.colTiLeCS.OptionsColumn.AllowFocus = false;
            this.colTiLeCS.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTiLeCS.Visible = true;
            this.colTiLeCS.VisibleIndex = 3;
            this.colTiLeCS.Width = 84;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.Mask.EditMask = "P2";
            this.repositoryItemSpinEdit2.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // colTiLeKH
            // 
            this.colTiLeKH.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colTiLeKH.DisplayFormat.FormatString = "#,#0.##";
            this.colTiLeKH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTiLeKH.FieldName = "TiLeKH";
            this.colTiLeKH.Name = "colTiLeKH";
            this.colTiLeKH.OptionsColumn.AllowEdit = false;
            this.colTiLeKH.OptionsColumn.AllowFocus = false;
            this.colTiLeKH.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colTiLeKH.Visible = true;
            this.colTiLeKH.VisibleIndex = 5;
            this.colTiLeKH.Width = 110;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Mask.EditMask = "P2";
            this.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // rsearchNhanVien
            // 
            this.rsearchNhanVien.AutoHeight = false;
            this.rsearchNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsearchNhanVien.DisplayMember = "HoTen";
            this.rsearchNhanVien.Name = "rsearchNhanVien";
            this.rsearchNhanVien.ValueMember = "MaNV";
            this.rsearchNhanVien.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colDiaChi1,
            this.colCMND1,
            this.colDienThoai1});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 185;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 288;
            // 
            // colDiaChi1
            // 
            this.colDiaChi1.FieldName = "DiaChi";
            this.colDiaChi1.Name = "colDiaChi1";
            this.colDiaChi1.Visible = true;
            this.colDiaChi1.VisibleIndex = 4;
            this.colDiaChi1.Width = 708;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 2;
            this.colCMND1.Width = 194;
            // 
            // colDienThoai1
            // 
            this.colDienThoai1.FieldName = "DienThoai";
            this.colDienThoai1.Name = "colDienThoai1";
            this.colDienThoai1.Visible = true;
            this.colDienThoai1.VisibleIndex = 3;
            this.colDienThoai1.Width = 247;
            // 
            // repTrangThai
            // 
            this.repTrangThai.AutoHeight = false;
            this.repTrangThai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repTrangThai.Name = "repTrangThai";
            // 
            // repHinhThuc
            // 
            this.repHinhThuc.AutoHeight = false;
            this.repHinhThuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repHinhThuc.Name = "repHinhThuc";
            // 
            // repKhachHang
            // 
            this.repKhachHang.AutoHeight = false;
            this.repKhachHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repKhachHang.DisplayMember = "TenKH";
            this.repKhachHang.Name = "repKhachHang";
            this.repKhachHang.ValueMember = "MaKH";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(990, 525);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.customGridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(990, 501);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 501);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(990, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // soKHCSTheoNhanVienTableAdapter
            // 
            this.soKHCSTheoNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSoKHDuocCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 587);
            this.Controls.Add(this.layoutControl1);
            this.DateFrom = new System.DateTime(2018, 9, 1, 0, 0, 0, 0);
            this.DateTo = new System.DateTime(2018, 9, 30, 23, 59, 59, 0);
            this.Name = "FrmSoKHDuocCS";
            this.ReportType = Lotus.Base.ReportType.Month;
            this.ReportTypeShowAll = false;
            this.ShowAllChiNhanh = false;
            this.Text = "Số lượt chăm sóc khách hàng";
            this.Load += new System.EventHandler(this.FrmPhapLy_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.soKHCSTheoNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsearchNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repHinhThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private Lotus.Libraries.CustomGridControl customGridControl1;
        private Lotus.Libraries.CustomGridView customGridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit rsearchNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repTrangThai;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repHinhThuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repKhachHang;
        private DataReport dataReport;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource soKHCSTheoNhanVienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSoKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colSLCS;
        private DevExpress.XtraGrid.Columns.GridColumn colSoKHCS;
        private DevExpress.XtraGrid.Columns.GridColumn colTiLeCS;
        private DevExpress.XtraGrid.Columns.GridColumn colTiLeKH;
        private DataReportTableAdapters.SoKHCSTheoNhanVienTableAdapter soKHCSTheoNhanVienTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
    }
}