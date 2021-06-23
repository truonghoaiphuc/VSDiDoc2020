using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
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
using VSDiDoc.DanhMuc;
using VSDiDoc.NghiepVu;
using VSDiDoc.NghiepVu.Utils;
using VSDiDoc.Report;
using VSDiDoc.Utils;

namespace VSDiDoc
{
    public partial class FrmVSDiDocMain : FrmMain
    {
        public FrmVSDiDocMain()
        {
            InitializeComponent();
            ribbon.Pages.Clear();
            ribbon.Pages.Add(pageHeThong);
            ribbon.Pages.Add(ribVBDen);
            ribbon.Pages.Add(ribVBDi);
            ribbon.Pages.Add(ribDanhMuc);
            ribbon.Pages.Add(pageTroGiup);

        }

        public void OpenForm<T>(string chucnang, string LoaiVB, string fName)
        {

            MsgBox.ShowWaitForm();
            var f = MdiChildren.FirstOrDefault(i => i.Text == fName);
            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                f.MdiParent = this;
                
                if (f is FrmBase)
                {
                    if(f is FrmVanBanDen)
                        (f as FrmVanBanDen).LoaiVB = LoaiVB;
                    if (f is FrmDSVanBanDi)
                        (f as FrmDSVanBanDi).LoaiVB = LoaiVB;
                    if (f is FrmTimKiemVBDen)
                        (f as FrmTimKiemVBDen).LoaiVB = LoaiVB;
                    (f as FrmBase).ChucNang = chucnang;
                    f.Text = fName;
                }

                f.Show();
            }
            else f.Activate();
            MsgBox.CloseWaitForm();
        }


        private void barTVLK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmTVLK>(HeThong.ChucNangDangChon);
        }

        private void barVanBanParam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmVanBanParam>(HeThong.ChucNangDangChon);
        }

        private void barPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmPhongBan>(HeThong.ChucNangDangChon);
        }

        private void barLoaiHS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmLoaiVB>(HeThong.ChucNangDangChon);
        }

        private void barChungTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmChungTu>(HeThong.ChucNangDangChon);
        }

        private void barGoiY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmGoiY>(HeThong.ChucNangDangChon);
        }

        private void barDonVi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSDonVi>(HeThong.ChucNangDangChon);
        }

        private void FrmVSDiDocMain_Load(object sender, EventArgs e)
        {
            InitMenu();
            if (DangNhap() == false)
                this.Close();     
            else
            {
                bool isConvert = Param.GetValue<bool>("Convert dữ liệu", "Hệ thống", false, false);
                if(isConvert)
                {
                    var f = new FrmConvertData();
                    f.ShowDialog();
                }
            }
        }
         
        private void barVBDHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmVanBanDen>(HeThong.ChucNangDangChon,"CVDE", barVBDHC.Caption);
        }

        private void barCTNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmCTNghiepVu>(HeThong.ChucNangDangChon);
        }

        private void barDuyetCTNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDuyetCTNV>(HeThong.ChucNangDangChon);
        }

        private void barCongVanDi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSVanBanDi>(HeThong.ChucNangDangChon,"CVDI", barCongVanDi.Caption);
        }

        private void barNoiLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmNoiLuu>(HeThong.ChucNangDangChon);
        }

        private void barThongBao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSVanBanDi>(HeThong.ChucNangDangChon, "TBAO", barThongBao.Caption);
        }

        private void barVBDNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmVanBanDen>(HeThong.ChucNangDangChon, "VTNV", barVBDNV.Caption);
        }

        private void barToTrinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSVanBanDi>(HeThong.ChucNangDangChon, "TTRI", barToTrinh.Caption);
        }

        private void barBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSVanBanDi>(HeThong.ChucNangDangChon, "BCAO", barBaoCao.Caption);
        }

        private void barQuyetDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSVanBanDi>(HeThong.ChucNangDangChon, "QDIN", barQuyetDinh.Caption);
        }

        private void barCongVanKhac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmDSVanBanDi>(HeThong.ChucNangDangChon, "KHAC", barCongVanKhac.Caption);
        }

        private void barSoVBDHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmInSoVBDen>(LoaiSo.CONGVANDEN);
        }

        private void barSoVBPDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmInSoVBDen>(LoaiSo.CTNVPHONGDK);
        }

        private void barSoLaySoVBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmInSoVBDen>(LoaiSo.CTNV);
        }

        private void barSoCTQuaMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmInSoVBDen>(LoaiSo.CTNV_MAIL);
        }

        private void barSoGiaoTVLK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmInSoVBDen>(LoaiSo.SOGIAOTVLK);
        }

        private void barInBiThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmInBiaThu>(HeThong.ChucNangDangChon);
        }

        private void barPhanQuyenTVLK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmPhanQuyenTVLK>(HeThong.ChucNangDangChon);
        }

        private void barThongKeCTNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmThongKeCTNV>();
        }

        private void barHuyDuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmHuyDuyetCTNV>(HeThong.ChucNangDangChon);
        }

        private void barTimKiemCTNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmTimKiemCTDen>(HeThong.ChucNangDangChon, "CTNV", barTimKiemCTNV.Caption);
        }

        private void barSoChuyenGiaoNB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            MsgBox.OpenDialog<FrmInSoVBDen>(LoaiSo.SOGIAOVBNOIBO);
        }

        private void barTimKiemVBHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmTimKiemVBDen>(HeThong.ChucNangDangChon, "CVDE", barTimKiemVBHC.Caption);
        }

        private void barTimKiemVBNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmTimKiemVBDen>(HeThong.ChucNangDangChon, "VTNV", barTimKiemVBNV.Caption);
        }

        private void barTimKiemVBDi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HeThong.ChucNangDangChon = e.Item.Tag == null ? string.Empty : e.Item.Tag.ToString();
            OpenForm<FrmTimKiemVBDi>(HeThong.ChucNangDangChon);
        }
    }
}
