using Lotus;
using Lotus.Base;
using Lotus.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Lotus.Base.Systems;

namespace VSDiDoc.Report
{
    public partial class FrmInSoVBDen : FrmBase
    {
        LoaiSo _loaiso;
        string _loaivb;
        public string LoaiVB
        {
            get { return _loaivb; }
            set { _loaivb = value; }
        }
        public FrmInSoVBDen(LoaiSo loaiso)
        {
            InitializeComponent();
            barEditReport.Visibility = HeThong.NguoiDungDangNhap.QuanTri ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            _loaiso = loaiso;
            dtFrom.DateTime = dtTo.DateTime = DateTime.Now;
            dtRPDate.DateTime = DateTime.Today;

            switch (_loaiso)
            {
                case LoaiSo.CONGVANDEN:
                    layFrom.Visibility = layTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layDate.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;                    
                    Height = Height - 60;
                    break;
                case LoaiSo.CTNVPHONGDK:
                    layFrom.Visibility = layTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layDate.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Height = Height - 60;
                    break;
                case LoaiSo.CTNV:
                    layFrom.Visibility = layTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layDate.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case LoaiSo.CTNV_MAIL:
                    layFrom.Visibility = layTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layDate.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;
                case LoaiSo.SOGIAOTVLK:
                    layFrom.Visibility = layTo.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layDate.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    Height = Height - 80;
                    break;
                case LoaiSo.VBDI:
                    layFrom.Visibility = layTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layDate.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Height = Height - 60;
                    break;
                default:
                    layFrom.Visibility = layTo.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layDate.Visibility = layBuoi.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Height = Height - 60;
                    break;
            }
            
            this.Text = string.Format("In {0}", Data.GetDescription(_loaiso));
        }

        private void barPrints_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var r = new RPVanBan();

            switch (_loaiso)
            {
                case LoaiSo.CONGVANDEN:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\CongVanDen.repx");
                    DataSet dsSoCVD = SQLHelper.ExecuteDataset("VBD_SOVBDEN"
                                                            , new SqlParameter("@LoaiVB","CVDE")
                                                            , new SqlParameter("@FromDate", dtFrom.DateTime)
                                                            , new SqlParameter("@ToDate", dtTo.DateTime));

                    if (dsSoCVD.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsSoCVD;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();                    
                    break;
                case LoaiSo.CTNVPHONGDK:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\VBD_DKCK.repx");
                    DataSet dsSoCVDDK = SQLHelper.ExecuteDataset("VBD_SOVBDEN"
                                                            , new SqlParameter("@LoaiVB","VTNV")
                                                            , new SqlParameter("@FromDate", dtFrom.DateTime)
                                                            , new SqlParameter("@ToDate", dtTo.DateTime));

                    if (dsSoCVDDK.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsSoCVDDK;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();        
                    break;
                //case LoaiSo.TBXN:
                //    MsgBox.ShowWaitForm();
                //    xpcVBD.Criteria = CriteriaOperator.Parse("LoaiVB.MaLoaiVB=? and ChungTu.MaCT=? and NgayNhan>=? and NgayNhan<=?", "VTNV", "TBXN", dtFrom.DateTime, dtTo.DateTime);
                //    xpcVBD.Reload();
                //    if (xpcVBD.Count == 0)
                //    {
                //        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                //        return;
                //    }
                //    r.DataSource = xpcVBD;
                //    r.LoadLayout(Application.StartupPath + "\\Reports\\TBXN.repx");
                //    r.ShowPreview();
                //    MsgBox.CloseWaitForm();
                //    break;
                case LoaiSo.CTNV:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\VBD_CTNV.repx");
                    DataSet dsCTNV = SQLHelper.ExecuteDataset("[CTNV_CREATEREPORT01]"
                                                            , new SqlParameter("@NGAYNHAN", dtRPDate.DateTime)
                                                            , new SqlParameter("@BUOI", rgBuoi.EditValue));

                    if (dsCTNV.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsCTNV;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();
                    break;
                case LoaiSo.CTNV_MAIL:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\VBD_LKCK_MAIL.repx");
                    DataSet dsCTNVMail = SQLHelper.ExecuteDataset("[CTNV_CREATEREPORT03]"
                                                            , new SqlParameter("@NGAYNHAN", dtRPDate.DateTime)
                                                            , new SqlParameter("@BUOI", rgBuoi.EditValue));

                    if (dsCTNVMail.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsCTNVMail;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();
                    break;
                case LoaiSo.SOGIAOTVLK:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\SoGiaoCTNV.repx");
                    DataSet dsSoGiao = SQLHelper.ExecuteDataset("[CTNV_SOGIAOTVLK]"
                                                            , new SqlParameter("@NGAYGIAO", dtRPDate.DateTime));

                    if (dsSoGiao.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsSoGiao;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();
                    break;
                case LoaiSo.VBDI:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\CongVanDi.repx");
                    DataSet dsSoCVDi = SQLHelper.ExecuteDataset("VBDI_SOVBDI"
                                                            , new SqlParameter("@LoaiVB",_loaivb)
                                                            , new SqlParameter("@FromDate", dtFrom.DateTime)
                                                            , new SqlParameter("@ToDate", dtTo.DateTime));

                    if (dsSoCVDi.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsSoCVDi;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();
                    break;
                case LoaiSo.SOGIAOVBNOIBO:
                    MsgBox.ShowWaitForm();
                    r.LoadLayout(Application.StartupPath + "\\Reports\\SoChuyenGiaoVBNB.repx");
                    DataSet dsVBNB = SQLHelper.ExecuteDataset("VBDI_SoChuyenGiaoNoiBo"                                                            
                                                            , new SqlParameter("@FromDate", dtFrom.DateTime)
                                                            , new SqlParameter("@ToDate", dtTo.DateTime));

                    if (dsVBNB.Tables[0].Rows.Count == 0)
                    {
                        MsgBox.ShowWarningDialog("Không có dữ liệu để tạo báo cáo");
                        return;
                    }
                    r.DataSource = dsVBNB;
                    if ((bool)barEditReport.EditValue)
                        r.ShowDesigner();
                    else
                        r.ShowPreview();
                    MsgBox.CloseWaitForm();
                    break;
            }
        }
    }
}
