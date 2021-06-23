﻿namespace Lotus.Base.Systems
{
    partial class FrmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lkePhong = new DevExpress.XtraEditors.LookUpEdit();
            this.phongBanBindingSource = new System.Windows.Forms.BindingSource();
            this.dATA = new Lotus.Base.DATA();
            this.cboChucDanh = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.txtXacNhan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            this.nguoiDungAD = new Lotus.Base.DATATableAdapters.NguoiDungTableAdapter();
            this.phongBanTableAdapter = new Lotus.Base.DATATableAdapters.PhongBanTableAdapter();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkePhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
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
            this.btnSave.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
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
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DrawBorder = false;
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
            this.layoutControl1.Controls.Add(this.txtHoTen);
            this.layoutControl1.Controls.Add(this.lkePhong);
            this.layoutControl1.Controls.Add(this.cboChucDanh);
            this.layoutControl1.Controls.Add(this.txtXacNhan);
            this.layoutControl1.Controls.Add(this.txtMatKhau);
            this.layoutControl1.Controls.Add(this.txtTenDangNhap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(472, 83, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(382, 179);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lkePhong
            // 
            this.lkePhong.Location = new System.Drawing.Point(106, 132);
            this.lkePhong.MenuManager = this.bm;
            this.lkePhong.Name = "lkePhong";
            this.lkePhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkePhong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhong", "Tên Phòng", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lkePhong.Properties.DataSource = this.phongBanBindingSource;
            this.lkePhong.Properties.DisplayMember = "TenPhong";
            this.lkePhong.Properties.ShowFooter = false;
            this.lkePhong.Properties.ShowHeader = false;
            this.lkePhong.Properties.ValueMember = "MaPhong";
            this.lkePhong.Size = new System.Drawing.Size(264, 20);
            this.lkePhong.StyleController = this.layoutControl1;
            this.lkePhong.TabIndex = 9;
            // 
            // phongBanBindingSource
            // 
            this.phongBanBindingSource.DataMember = "PhongBan";
            this.phongBanBindingSource.DataSource = this.dATA;
            // 
            // dATA
            // 
            this.dATA.DataSetName = "DATA";
            this.dATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.Location = new System.Drawing.Point(106, 108);
            this.cboChucDanh.MenuManager = this.bm;
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboChucDanh.Size = new System.Drawing.Size(264, 20);
            this.cboChucDanh.StyleController = this.layoutControl1;
            this.cboChucDanh.TabIndex = 8;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(106, 60);
            this.txtXacNhan.MenuManager = this.bm;
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Properties.PasswordChar = '*';
            this.txtXacNhan.Size = new System.Drawing.Size(264, 20);
            this.txtXacNhan.StyleController = this.layoutControl1;
            this.txtXacNhan.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(106, 36);
            this.txtMatKhau.MenuManager = this.bm;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(264, 20);
            this.txtMatKhau.StyleController = this.layoutControl1;
            this.txtMatKhau.TabIndex = 6;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(106, 12);
            this.txtTenDangNhap.MenuManager = this.bm;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(264, 20);
            this.txtTenDangNhap.StyleController = this.layoutControl1;
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.simpleSeparator1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(382, 179);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenDangNhap;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem1.Text = "Tên đăng nhập";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMatKhau;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem3.Text = "Mật khẩu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtXacNhan;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem4.Text = "Xác nhận mật khẩu";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(91, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 157);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(362, 2);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboChucDanh;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem2.Text = "Chức danh";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(91, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lkePhong;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem5.Text = "Phòng";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(91, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 144);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(362, 13);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // nguoiDungAD
            // 
            this.nguoiDungAD.ClearBeforeFill = true;
            // 
            // phongBanTableAdapter
            // 
            this.phongBanTableAdapter.ClearBeforeFill = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(106, 84);
            this.txtHoTen.MenuManager = this.bm;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(264, 20);
            this.txtHoTen.StyleController = this.layoutControl1;
            this.txtHoTen.TabIndex = 10;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtHoTen;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItem6.Text = "Họ tên";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(91, 13);
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 226);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNguoiDung";
            this.Text = "Thông tin người dùng";
            this.Load += new System.EventHandler(this.FrmNguoiDung_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this._dtNhatKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgSpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkePhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtXacNhan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DATATableAdapters.NguoiDungTableAdapter nguoiDungAD;
        private DevExpress.XtraEditors.LookUpEdit lkePhong;
        private DevExpress.XtraEditors.ImageComboBoxEdit cboChucDanh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DATA dATA;
        private System.Windows.Forms.BindingSource phongBanBindingSource;
        private DATATableAdapters.PhongBanTableAdapter phongBanTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}