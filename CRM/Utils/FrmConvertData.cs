using DevExpress.XtraEditors;
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

namespace VSDiDoc.Utils
{
    public partial class FrmConvertData : Form
    {
        public FrmConvertData()
        {
            InitializeComponent();            
        }


        void InitProgress(ProgressBarControl pgbar, int lMax)
        {
            pgbar.EditValue = 0;
            pgbar.Properties.Maximum = lMax;
            Application.DoEvents();
        }



        private void barConvert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SQLHelper.Connectionstring = string.Format("Data Source={0};Initial Catalog={1};User ID=sa;Password={2}",textEdit1.Text,textEdit3.Text,textEdit2.Text);
            //ConvertPhongBan();
            ConvertNguoiDung();
            //ConvertGoiY();
            ConvertFileLuu();
            ConvertDonVi();
            ConvertTVLK();
            ConvertPhanQuyenTVLK();

            ConvertLoaiVB();
            ConvertChungTu();
            ConvertVanBanParam();
            ConvertVanBanDen();
            ConvertVanBanDi();
            ConvertNoiNhanVBDi();
            ConvertDVLuuVBDi();
        }

        void ConvertPhongBan()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarPhongBan.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM PhongBan Where MaPhong <>'KTQTCN'");

            InitProgress(progressBarPhongBan, ds.Tables[0].Rows.Count);
            int iCount = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.PhongBan.NewPhongBanRow();
                a.MaPhong = r["MaPhong"].ToString();
                a.TenPhong = r["TenPhong"].ToString();
                a.KyHieu = r["KyHieu"].ToString();
                vsDiDocData1.PhongBan.AddPhongBanRow(a);

                progressBarPhongBan.EditValue = (int)progressBarPhongBan.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.PhongBan.GetChanges() as VSDiDocData.PhongBanDataTable;
            if (dt != null)
            {
                phongBanTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertNguoiDung()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;

            progressBarNguoiDung.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM NguoiDung Where TenDangNhap<>'admin'");

            InitProgress(progressBarNguoiDung, ds.Tables[0].Rows.Count);
            int iCount = 0;
            


            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.NguoiDung.NewNguoiDungRow();
                a.TenDangNhap = r["TenDangNhap"].ToString();
                a.HoTen = r["HoTen"].ToString();
                a.MatKhau = r["MatKhau"].ToString();
                a.Loai = (int)ChucDanh.CHUYENVIEN;
                a.Phong = r["Phong"].ToString();
                a.QuanTri = false;
                vsDiDocData1.NguoiDung.AddNguoiDungRow(a);

                progressBarNguoiDung.EditValue = (int)progressBarNguoiDung.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.NguoiDung.GetChanges() as VSDiDocData.NguoiDungDataTable;
            if (dt != null)
            {
                nguoiDungTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertDonVi()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarDonVi.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM DonVi");

            InitProgress(progressBarDonVi, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.DonVi.NewDonViRow();
                
                a.MaDonVi = r["MaDonVi"].ToString();
                a.Id = string.Format("{0}.{1}", (int)r["Id"], a.MaDonVi);
                a.TenDonVi = r["TenDonVi"].ToString();
                a.DiaChi = r["DiaChi"].ToString();
                a.DienThoai = r["DienThoai"].ToString();
                a.Fax = r["Fax"].ToString();
                a.MaTVLK = r["MaTVLK"].ToString();
                a.IsTVLK = (bool)r["IsTVLK"];
                a.QuanLy = (int)r["QuanLy"];
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.DonVi.AddDonViRow(a);

                progressBarDonVi.EditValue = (int)progressBarDonVi.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.DonVi.GetChanges() as VSDiDocData.DonViDataTable;
            if (dt != null)
            {
                donViTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertTVLK()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;

            progressBarTVLK.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM TVLK");

            InitProgress(progressBarTVLK, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.TVLK.NewTVLKRow();
                a.MaTVLK = r["MaTVLK"].ToString();
                a.TenTVLK = r["TenTVLK"].ToString();
                a.MaGD = r["MaGD"].ToString();                
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.TVLK.AddTVLKRow(a);

                progressBarTVLK.EditValue = (int)progressBarTVLK.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.TVLK.GetChanges() as VSDiDocData.TVLKDataTable;
            if (dt != null)
            {
                tvlkTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertFileLuu()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarFileLuu.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM FileLuu");

            InitProgress(progressBarFileLuu, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.FileLuu.NewFileLuuRow();
                a.Id = Guid.NewGuid().ToString();
                a.MSHS = r["MSHS"].ToString();
                a.TenHS = r["TenHS"].ToString();
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.FileLuu.AddFileLuuRow(a);

                progressBarFileLuu.EditValue = (int)progressBarFileLuu.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.FileLuu.GetChanges() as VSDiDocData.FileLuuDataTable;
            if (dt != null)
            {
                fileLuuTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }


        void ConvertGoiY()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarGoiY.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM AUTOCOMPLETE");

            InitProgress(progressBarGoiY, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count;i++ )
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.AutoComplete.NewAutoCompleteRow();
                a.GoiY = r["GoiY"].ToString();
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.AutoComplete.AddAutoCompleteRow(a);

                progressBarGoiY.EditValue = (int)progressBarGoiY.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.AutoComplete.GetChanges() as VSDiDocData.AutoCompleteDataTable;
            if(dt!=null)
            {
                autoCompleteTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertLoaiVB()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarLoaiVB.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM LoaiVanBan");

            InitProgress(progressBarLoaiVB, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.LoaiVanBan.NewLoaiVanBanRow();
                a.MaLoaiVB = r["MaLoaiVB"].ToString();
                a.TenLoaiVB = r["TenLoaiVB"].ToString();
                a.STT = (int)r["STT"];
                a.IsCVD = (bool)r["IsCVD"];
                a.Nam = (int)r["Nam"];
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.LoaiVanBan.AddLoaiVanBanRow(a);

                progressBarLoaiVB.EditValue = (int)progressBarLoaiVB.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.LoaiVanBan.GetChanges() as VSDiDocData.LoaiVanBanDataTable;
            if (dt != null)
            {
                loaiVanBanTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertChungTu()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarChungTu.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM ChungTu");

            InitProgress(progressBarChungTu, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.ChungTu.NewChungTuRow();
                a.MaCT = r["MaCT"].ToString();
                a.TenCT = r["TenCT"].ToString();
                a.IsYCCK = (bool)r["IsYCCK"];
                a.LoaiVB = r["LoaiVB"].ToString();
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.ChungTu.AddChungTuRow(a);

                progressBarChungTu.EditValue = (int)progressBarChungTu.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.ChungTu.GetChanges() as VSDiDocData.ChungTuDataTable;
            if (dt != null)
            {
                chungTuTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertVanBanParam()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarVanBanPR.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("SELECT * FROM VanBanParam");

            InitProgress(progressBarVanBanPR, ds.Tables[0].Rows.Count);
            int iCount = 0;
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.VanBanParam.NewVanBanParamRow();
                a.Phong = r["Phong"].ToString();
                a.LoaiVB = r["LoaiVB"].ToString();
                a.KyHieu = r["KyHieu"].ToString();
                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.VanBanParam.AddVanBanParamRow(a);

                progressBarVanBanPR.EditValue = (int)progressBarVanBanPR.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.VanBanParam.GetChanges() as VSDiDocData.VanBanParamDataTable;
            if (dt != null)
            {
                vanBanParamTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertVanBanDen()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            donViTableAdapter1.Fill(vsDiDocData1.DonVi);
            progressBarVBDen.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("select vb.*, convert(varchar,vb.NoiGui) + '.' + dv.MaDonVi as NewNoiGui from VanBanDen vb left join DonVi dv on vb.NoiGui=dv.Id");

            InitProgress(progressBarVBDen, ds.Tables[0].Rows.Count);
            int iCount = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.VanBanDen.NewVanBanDenRow();
                a.NgayNhap = (DateTime)r["NgayNhap"];
                a.Nam = (int)r["Nam"];
                a.NgayNhan = (DateTime)r["NgayNhan"];
                if (!string.IsNullOrEmpty(r["NgayHieuLuc"].ToString()))
                    a.NgayHieuLuc = Convert.ToDateTime(r["NgayHieuLuc"].ToString());
                if (!string.IsNullOrEmpty(r["NgayGiao"].ToString()))
                    a.NgayGiao = (DateTime)r["NgayGiao"];
                a.SoVB = r["SoVB"].ToString();
                a.KyHieu = r["KyHieu"].ToString();
                a.ChungTu = r["ChungTu"].ToString();
                a.LoaiVB = r["LoaiVB"].ToString();

                a.Id = string.Format("{0}.{1}.{2}", a.LoaiVB, a.SoVB, a.NgayNhap.ToString("yyyyMMddHHmmss"));

                if (!string.IsNullOrEmpty(r["TrichYeu"].ToString()))
                    a.TrichYeu = r["TrichYeu"].ToString();
                if (!string.IsNullOrEmpty(r["NgayVB"].ToString()))
                    a.NgayVB = (DateTime)r["NgayVB"];

                a.NguoiNhap = r["NguoiNhap"].ToString();
                a.Status = (int)r["Status"];
                a.SoLuong = (int)r["SoLuong"];

                if (!string.IsNullOrEmpty(r["NgayChuyen"].ToString()))
                    a.NgayChuyen = (DateTime)r["NgayChuyen"];

                if (!string.IsNullOrEmpty(r["NewNoiGui"].ToString()))
                {
                    a.NoiGui = r["NewNoiGui"].ToString();
                }

                if (!string.IsNullOrEmpty(r["Buoi"].ToString()))
                    a.Buoi = (int)r["Buoi"];
                if (!string.IsNullOrEmpty(r["IsMail"].ToString()))
                    a.IsMail = (bool)r["IsMail"];
                if (!string.IsNullOrEmpty(r["ChungKhoan"].ToString()))
                    a.ChungKhoan = r["ChungKhoan"].ToString();
                if (!string.IsNullOrEmpty(r["TVLKGui"].ToString()))
                    a.TVLKGui = r["TVLKGui"].ToString(); ;
                if (!string.IsNullOrEmpty(r["TVLKNhan"].ToString()))
                    a.TVLKNhan = r["TVLKNhan"].ToString(); ;

                a.GhiChu = r["GhiChu"].ToString();
                vsDiDocData1.VanBanDen.AddVanBanDenRow(a);

                progressBarVBDen.EditValue = (int)progressBarVBDen.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.VanBanDen.GetChanges() as VSDiDocData.VanBanDenDataTable;
            if (dt != null)
            {
                vanBanDenTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertVanBanDi()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            donViTableAdapter1.Fill(vsDiDocData1.DonVi);
            fileLuuTableAdapter1.Fill(vsDiDocData1.FileLuu);
            progressBarVBDi.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("select  vb.*, MSHS from VanBanDi vb inner join FileLuu fl on fl.Id=NoiLuu");

            InitProgress(progressBarVBDi, ds.Tables[0].Rows.Count);
            int iCount = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.VanBanDi.NewVanBanDiRow();
                a.NgayNhap = (DateTime)r["NgayNhap"];
                a.Nam = (int)r["Nam"];
                a.SoVB = r["SoVB"].ToString();
                a.SoLuong = (int)r["SoLuong"];
                a.TrichYeu = r["TrichYeu"].ToString();
                a.NoiBH = r["NoiBH"].ToString();
                a.LoaiVB = r["LoaiVB"].ToString();
                a.NgayVB = (DateTime)r["NgayVB"];
                a.NguoiKy = r["NguoiKy"].ToString();
                a.NguoiLuu = r["NguoiLuu"].ToString();
                a.NguoiNhap = r["NguoiNhap"].ToString();
                a.NoiNhan = r["NoiNhan"].ToString();
                a.DViLuu = r["DViLuu"].ToString();
                a.NoiLuu = (vsDiDocData1.FileLuu.Where(x => x.MSHS == r["MSHS"].ToString()).FirstOrDefault() as VSDiDocData.FileLuuRow).Id;


                a.Id = string.Format("{0}.{1}.{2}", a.LoaiVB, a.SoVB, a.NgayNhap.ToString("yyyyMMddHHmmss"));

                
                vsDiDocData1.VanBanDi.AddVanBanDiRow(a);                


                progressBarVBDi.EditValue = (int)progressBarVBDi.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.VanBanDi.GetChanges() as VSDiDocData.VanBanDiDataTable;
            if (dt != null)
            {
                vanBanDiTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertNoiNhanVBDi()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarNoiNhanVBDi.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("with listNN as ( select distinct VBDi, NoiNhan from NoiNhanVBDi where VBDi is not null and NoiNhan is not null) select NgayNhap,LoaiVB,SoVB, nn.NoiNhan as NoiNhan,MaDonVi from VanBanDi vb join listNN nn on nn.VBDi=vb.Id join DonVi dv on dv.Id=nn.NoiNhan");

            InitProgress(progressBarNoiNhanVBDi, ds.Tables[0].Rows.Count);
            int iCount = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.NoiNhanVBDi.NewNoiNhanVBDiRow();
                a.Id = Guid.NewGuid().ToString();
                a.VBDi = string.Format("{0}.{1}.{2}", r["LoaiVB"].ToString(), r["SoVB"].ToString(), ((DateTime)r["NgayNhap"]).ToString("yyyyMMddHHmmss"));
                a.NoiNhan = string.Format("{0}.{1}", r["NoiNhan"].ToString(), r["MaDonVi"].ToString());
                
                vsDiDocData1.NoiNhanVBDi.AddNoiNhanVBDiRow(a);


                progressBarNoiNhanVBDi.EditValue = (int)progressBarNoiNhanVBDi.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.NoiNhanVBDi.GetChanges() as VSDiDocData.NoiNhanVBDiDataTable;
            if (dt != null)
            {
                noiNhanVBDiTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertDVLuuVBDi()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarDonViLuuVBDi.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("with listNN as ( select distinct VBDi, DonViLuu from DonViLuuVBDi where VBDi is not null and DonViLuu is not null) select NgayNhap,LoaiVB,SoVB, DonViLuu from VanBanDi vb join listNN nn on nn.VBDi=vb.Id");

            InitProgress(progressBarDonViLuuVBDi, ds.Tables[0].Rows.Count);
            int iCount = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.DonViLuuVBDi.NewDonViLuuVBDiRow();
                a.Id = Guid.NewGuid().ToString();
                a.VBDi = string.Format("{0}.{1}.{2}", r["LoaiVB"].ToString(), r["SoVB"].ToString(), ((DateTime)r["NgayNhap"]).ToString("yyyyMMddHHmmss"));
                a.DonViLuu = r["DonViLuu"].ToString();

                vsDiDocData1.DonViLuuVBDi.AddDonViLuuVBDiRow(a);


                progressBarDonViLuuVBDi.EditValue = (int)progressBarDonViLuuVBDi.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.DonViLuuVBDi.GetChanges() as VSDiDocData.DonViLuuVBDiDataTable;
            if (dt != null)
            {
                donViLuuVBDiTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        void ConvertPhanQuyenTVLK()
        {
            if (string.IsNullOrEmpty(textEdit1.Text)) return;
            progressBarPhanQuyenTVLK.Properties.ShowTitle = true;
            Application.DoEvents();
            var ds = SQLHelper.ExecuteDataset("select * from PhanQuyenTVLK");

            InitProgress(progressBarPhanQuyenTVLK, ds.Tables[0].Rows.Count);
            int iCount = 0;

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                var r = ds.Tables[0].Rows[i];
                var a = vsDiDocData1.PhanQuyenTVLK.NewPhanQuyenTVLKRow();
                a.Id = Guid.NewGuid().ToString();
                a.ChuyenVien = r["ChuyenVien"].ToString();
                a.ThanhVienLuuKy = r["ThanhVienLuuKy"].ToString();

                vsDiDocData1.PhanQuyenTVLK.AddPhanQuyenTVLKRow(a);


                progressBarPhanQuyenTVLK.EditValue = (int)progressBarPhanQuyenTVLK.EditValue + 1;
                iCount++;
                Application.DoEvents();
            }
            var dt = vsDiDocData1.PhanQuyenTVLK.GetChanges() as VSDiDocData.PhanQuyenTVLKDataTable;
            if (dt != null)
            {
                phanQuyenTVLKTableAdapter1.Update(dt);
                vsDiDocData1.AcceptChanges();
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
