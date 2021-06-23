using Lotus;
using Lotus.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSD.Storage.DanhMuc;

namespace VSD.Storage
{
    public partial class FrmStorageMain : FrmMain
    {
        public FrmStorageMain()
        {
            InitializeComponent();
        }

        private void barListChungKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmChungKhoan>(HeThong.ChucNangDangChon);
        }

        private void barListLoaiHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmLoaiHS>(HeThong.ChucNangDangChon);
        }

        private void barListPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmPhongBan>(HeThong.ChucNangDangChon);
        }

        private void barListTVLK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmTVLK>(HeThong.ChucNangDangChon);
        }

        private void FrmStorageMain_Load(object sender, EventArgs e)
        {
            if (DangNhap() == false)
                this.Close();
        }
    }
}
