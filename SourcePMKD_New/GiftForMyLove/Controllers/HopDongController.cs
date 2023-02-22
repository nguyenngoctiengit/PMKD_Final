using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using GiftForMyLove.Models;
using GiftForMyLove.Models.ClassFunction;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForMyLove.Controllers
{
    public class HopDongController : Controller
    {
        IWebHostEnvironment _hostingEnvironment;
        public TradingsystemContext _context = new TradingsystemContext();
        public static string SystemrefHDMB = "";
        public HopDongController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult HopDong()
        {
            return View("HopDong");
        }
        [HttpGet]
        public object LoadHopDong(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Hdmbs
                        where (a.MuaBan == "MUA" || a.MuaBan == "BAN") && a.Macn == "INX"
                        select new
                        {
                            a.Systemref,
                            a.Ngaylam,
                            a.Sohd,
                            Trangthai = a.Trangthai == 2 ? "Hủy" : a.Trangthai == 1 ? "TH" : "TL",
                            a.MuaBan
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object LoadCtHDMB(string id, DataSourceLoadOptions loadOptions)
        {

            SystemrefHDMB = id;
            var item = (from a in _context.CtHdmbs
                        join b in _context.Hanghoas on a.Mahang equals b.Mahang
                        where a.Systemref == id
                        select new
                        {
                            a.IdRow,
                            a.Systemref,
                            a.Mahang,
                            mahang1 = a.Mahang,
                            Tenhang = b.Tenhang,
                            a.Soluong,
                            a.Trongluong,
                            a.Dvt,
                            a.Vat,
                            a.Giact,
                            a.Giatt,
                            a.Solot,
                            a.Giathang,
                            a.Gianam,
                            a.Sig,
                            a.Diff,
                            a.FNgayfix,
                            a.Stoploss,
                            MaNhom = b.MaNhom,
                            a.Giathitruong,
                            a.Mucthuong,
                            a.GiaTheoHd,
                            a.DvtTheoHd
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public IActionResult Fill_Form_HDMB(string Systemref)
        {
            var Name_IntKy = "";
            var IntKy = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.IntKy).FirstOrDefault().Trim();
            var Name_ClientKy = "";
            if (IntKy == null || IntKy == "")
            {
                Name_IntKy = "";
            }
            else
            {
                Name_IntKy = (from a in _context.Signers where a.MaKhach == IntKy.Substring(0, IntKy.Length - 1) && a.Stt == int.Parse(IntKy.Substring(IntKy.Length - 1)) select a.Nguoiky).FirstOrDefault().Trim() + " chức vụ " + (from a in _context.Signers where a.MaKhach == IntKy.Substring(0, IntKy.Length - 1) && a.Stt == int.Parse(IntKy.Substring(IntKy.Length - 1)) select a.Chucvu).FirstOrDefault();
            }
            if (_context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.ClientKy).FirstOrDefault().Trim() == "")
            {
                Name_ClientKy = "";
            }
            else
            {
                var Client_Ky = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.ClientKy).FirstOrDefault().Trim();
                Name_ClientKy = (from a in _context.Signers where a.MaKhach == Client_Ky.Substring(0, Client_Ky.Length - 1) && a.Stt == int.Parse(Client_Ky.Substring(Client_Ky.Length - 1)) select a.Nguoiky).FirstOrDefault().Trim() + " chức vụ " + (from a in _context.Signers where a.MaKhach == Client_Ky.Substring(0, Client_Ky.Length - 1) && a.Stt == int.Parse(Client_Ky.Substring(Client_Ky.Length - 1)) select a.Chucvu).FirstOrDefault();
            }
            var data = (from a in _context.Hdmbs
                        where a.Systemref == Systemref
                        select new
                        {
                            Systemref = a.Systemref,
                            Ref = a.Ref,
                            Makhach = a.Makhach,
                            Sohd = a.Sohd,
                            Tiente = a.Tiente,
                            IntKy = a.IntKy,
                            ClientKy = a.ClientKy,
                            Thanhtoan = a.Thanhtoan,
                            Tenfull = a.Tenfull,
                            DiaDiemGiaoHang = a.DiaDiemGiaoHang,
                            Ghichu = a.Ghichu,
                            Ngayky = a.Ngayky,
                            Ngaygiao = a.Ngaygiao,
                            Ngayhl = a.Ngayhl,
                            NgayTraPhaitra = a.NgayTraPhaitra,
                            TienUngHd = Convert.ToDecimal(a.TienUngHd),
                            TienUngTt = a.TienUngTt,
                            Nguoilam = a.Nguoilam,
                            Ngaylam = a.Ngaylam,
                            Macn = a.Macn,
                            VanChuyen = a.VanChuyen,
                            Money = _context.Money.Where(m => m.Ma == a.Tiente).Select(m => m.Ten).FirstOrDefault(),
                            TenTT = _context.PortfolioPayments.Where(m => m.Id == a.ThanhtoanId).Select(a => a.TenTt).FirstOrDefault(),
                            Mucung = _context.PortfolioPayments.Where(m => m.Id == a.ThanhtoanId).Select(a => a.Mucung).FirstOrDefault() + "%",
                            Name_IntKy = Name_IntKy,
                            Name_ClientKy = Name_ClientKy,
                            MuaBan = a.MuaBan,
                            IsFix = a.IsFix,
                            TypeKd = a.TypeKd,
                            Pakd = a.Pakd,
                            IsNoKhoDoi = a.IsNoKhoDoi,
                        }).FirstOrDefault();
            return Json(data);
        }
        [HttpPost]
        public IActionResult AddHopDong(string id, Hdmb hdmb)
        {
            if (id == "" || id == null)
            {
                Hdmb item = new Hdmb();
                var datetime = DateTime.Now;
                if (_context.Hdmbs.Any(a => a.Ref == hdmb.Ref + "/" + datetime.ToString("yy")))
                {
                    TempData["alertMessage"] = "Số Ref này đã tồn tại!";
                    return RedirectToAction("hdmb");
                }
                else if (hdmb.Ngaygiao.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngaygiao.Value.Date)
                {
                    TempData["alertMessage"] = "Chọn ngày Hợp đồng, ngày giao hàng, ngày hiệu lực chưa đúng!\n Ngày hợp đồng <= ngày giao hàng <= ngày hiệu lực";
                    return RedirectToAction("hdmb");
                }
                else
                {
                    item.TienUngHd = hdmb.TienUngHd;
                    item.TienUngTt = hdmb.TienUngTt;
                    item.Tenfull = hdmb.Tenfull;
                    item.Ngaylam = DateTime.Now;
                    item.Macn = "INX";
                    item.Systemref = AutoId.AutoIdFileStored("hdmb");
                    item.Ref = hdmb.Ref.Trim() + "/" + hdmb.Ngayky.Value.ToString("yy");
                    item.Sohd = hdmb.Sohd.Trim();
                    item.Trangthai = 1;
                    item.MuaBan = hdmb.MuaBan;
                    item.Makhach = hdmb.Makhach;
                    item.Ngayky = hdmb.Ngayky;
                    item.Ngaygiao = hdmb.Ngaygiao;
                    item.Ngayhl = hdmb.Ngayhl;
                    item.Nguoilam = "TEST";
                    item.Ghichu = hdmb.Ghichu;
                    item.Pakd = hdmb.Pakd;
                    item.Thanhtoan = hdmb.Thanhtoan;
                    item.IntKy = hdmb.IntKy == null ? "" : hdmb.IntKy;
                    item.ClientKy = hdmb.ClientKy == null ? "" : hdmb.ClientKy;
                    item.Docstatus = false;
                    item.Tiente = hdmb.Tiente;
                    item.IsFix = hdmb.IsFix;
                    item.DiaDiemGiaoHang = hdmb.DiaDiemGiaoHang;
                    item.ThanhtoanId = _context.PortfolioPayments.Where(a => a.Matt == hdmb.Thanhtoan).Select(a => a.Id).FirstOrDefault();
                    item.IsNoKhoDoi = hdmb.IsNoKhoDoi;
                    item.TypeKd = hdmb.TypeKd;
                    item.VanChuyen = hdmb.VanChuyen;
                    _context.Hdmbs.Add(item);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Thêm hợp đồng thành công";
                    return RedirectToAction("HopDong");
                }
            }
            else
            {
                Hdmb item = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
                var datetime = DateTime.Now;
                if (_context.Hdmbs.Any(a => a.Ref == hdmb.Ref + "/" + datetime.ToString("yy")))
                {
                    TempData["alertMessage"] = "Số Ref này đã tồn tại!";
                    return RedirectToAction("hdmb");
                }
                else if (hdmb.Ngaygiao.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngayky.Value.Date || hdmb.Ngayhl.Value.Date < hdmb.Ngaygiao.Value.Date)
                {
                    TempData["alertMessage"] = "Chọn ngày Hợp đồng, ngày giao hàng, ngày hiệu lực chưa đúng!\n Ngày hợp đồng <= ngày giao hàng <= ngày hiệu lực";
                    return RedirectToAction("hdmb");
                }
                else
                {
                    item.TienUngHd = hdmb.TienUngHd;
                    item.TienUngTt = hdmb.TienUngTt;
                    item.Tenfull = hdmb.Tenfull;
                    item.Ref = hdmb.Ref.Trim();
                    item.Sohd = hdmb.Sohd.Trim();
                    item.Trangthai = 1;
                    item.MuaBan = hdmb.MuaBan;
                    item.Makhach = hdmb.Makhach;
                    item.Ngayky = hdmb.Ngayky;
                    item.Ngaygiao = hdmb.Ngaygiao;
                    item.Ngayhl = hdmb.Ngayhl;
                    item.Ghichu = hdmb.Ghichu;
                    item.Pakd = hdmb.Pakd;
                    item.Thanhtoan = hdmb.Thanhtoan;
                    item.IntKy = hdmb.IntKy == null ? "" : hdmb.IntKy;
                    item.ClientKy = hdmb.ClientKy == null ? "" : hdmb.ClientKy;
                    item.Docstatus = false;
                    item.Tiente = hdmb.Tiente;
                    item.IsFix = hdmb.IsFix;
                    item.DiaDiemGiaoHang = hdmb.DiaDiemGiaoHang;
                    item.ThanhtoanId = _context.PortfolioPayments.Where(a => a.Matt == hdmb.Thanhtoan).Select(a => a.Id).FirstOrDefault();
                    item.IsNoKhoDoi = hdmb.IsNoKhoDoi;
                    item.TypeKd = hdmb.TypeKd;
                    item.VanChuyen = hdmb.VanChuyen;
                    _context.Hdmbs.Update(item);
                    _context.SaveChanges();
                    TempData["alertMessage"] = "Chỉnh sửa hợp đồng thành công";
                    return RedirectToAction("hopdong");

                }
            }
        }
        public IActionResult CancelContract(string id)
        {
            var item = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            if (_context.InputStocks.Any(a => a.ContractId == item.Systemref && a.StatusDestroy == false) || _context.OutputStocks.Any(a => a.ContractId == item.Systemref && a.StatusDestroy == false))
            {
                TempData["alertMessage"] = "Hợp đồng đã giao hàng không hủy được";
                return RedirectToAction("hdmb");
            }
            else
            if (_context.Fixgia.Any(a => a.Systemref == item.Systemref))
            {
                TempData["alertMessage"] = "Hợp đồng đã fix giá không hủy được";
                return RedirectToAction("hdmb");
            }
            else
            {
                item.Trangthai = 2;
                item.Ngaytl = DateTime.Now;
                item.Nguoilam = "TEST";
                var PairedPlans = _context.PairedPlans.Where(a => a.ContracId == id).FirstOrDefault();
                _context.PairedPlans.Remove(PairedPlans);
                _context.Hdmbs.Update(item);
                _context.SaveChanges();
                TempData["alertMessage"] = "Hủy hợp đồng thành công";
                return RedirectToAction("hdmb");
            }

        }
        [HttpPost]
        public IActionResult InsertCtHDMB(string values)
        {
            var ctHdmb = new CtHdmb();
            if (SystemrefHDMB == null)
            {
                return BadRequest("Vui lòng chọn hợp đồng !!");
            }
            JsonConvert.PopulateObject(values, ctHdmb);
            ctHdmb.IdRow = AutoId.AutoIdFileStored("ct_hdmb");
            ctHdmb.Systemref = SystemrefHDMB;
            ctHdmb.Ref = _context.Hdmbs.Where(a => a.Systemref == SystemrefHDMB).Select(a => a.Ref).FirstOrDefault().Trim();
            ctHdmb.Giatt = 0;
            ctHdmb.Giathang = "";
            ctHdmb.Gianam = "";
            ctHdmb.Sig = "";
            ctHdmb.Diff = 0;
            ctHdmb.Stoploss = 0;
            ctHdmb.Solot = 0;
            ctHdmb.FNgayfix = new DateTime(1900, 01, 01);
            ctHdmb.Status = false;
            ctHdmb.Dvt = "KGS";
            if (!TryValidateModel(ctHdmb))
                return BadRequest("Something went wrong!!");
            _context.CtHdmbs.Add(ctHdmb);
            _context.SaveChanges();
            return Ok(ctHdmb);
        }
        [HttpPut]
        public IActionResult UpdateCtHDMB(string key, string values)
        {
            var CtHDMB = _context.CtHdmbs.First(a => a.IdRow == key);

            JsonConvert.PopulateObject(values, CtHDMB);

            if (!TryValidateModel(CtHDMB))
                return BadRequest("Something went wrong");

            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCtHDMB(string key)
        {
            var CtHDMB = _context.CtHdmbs.First(a => a.IdRow == key);
            if (_context.Fixgia.Any(a => a.Systemref == CtHDMB.Systemref))
            {
                return BadRequest("Hợp đồng đã fix giá không xóa được");
            }
            else
            {
                _context.CtHdmbs.Remove(CtHDMB);
                _context.SaveChanges();
                return Ok();
            }
            
        }
        public IActionResult Save_Annex_HDMB(string id, string SoPhuKien_Annex_HDMB, string[] CheckBox_AnnexHDMB)
        {
            var MaHang_CtHDMB = _context.CtHdmbs.Where(a => a.Systemref == id).Select(a => a.Mahang).FirstOrDefault();
            var MaNhom_Hanghoa = _context.Hanghoas.Where(a => a.Mahang == MaHang_CtHDMB).Select(a => a.MaNhom).FirstOrDefault();
            var listAnnex = _context.Annices.Where(a => a.MaNhom == MaNhom_Hanghoa).Select(a => a.NoiDung).ToList();
            var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            var content = "";
            List<int> Annex = new List<int>();
            for (var i = 0; i < CheckBox_AnnexHDMB.Length; i++)
            {
                if (CheckBox_AnnexHDMB.Length == 1)
                {
                    content = CheckBox_AnnexHDMB[i];
                }
                else
                {
                    if (i == CheckBox_AnnexHDMB.Length - 1)
                    {
                        content += CheckBox_AnnexHDMB[i];
                    }
                    else
                    {
                        content += CheckBox_AnnexHDMB[i] + " - ";
                    }
                    
                }
                for (var j = 0; j < listAnnex.Count; j++)
                {
                    if (CheckBox_AnnexHDMB[i] == listAnnex[j])
                    {
                        Annex.Add(j);
                    }
                }
            }
            if (_context.HdmbAnnices.Any(a => a.Systemref == id && a.Number == SoPhuKien_Annex_HDMB))
            {
                HdmbAnnex hdmbAnnex = _context.HdmbAnnices.Where(a => a.Systemref == id && a.Number == SoPhuKien_Annex_HDMB).FirstOrDefault();
                hdmbAnnex.NoiDung = content;
                hdmbAnnex.NgayTao = DateTime.Now;
                hdmbAnnex.Path = hdmb.Sohd + "_PK" + SoPhuKien_Annex_HDMB + ".doc";
                _context.HdmbAnnices.Update(hdmbAnnex);
                _context.SaveChanges();
            }
            else
            {
                HdmbAnnex hdmbAnnex = new HdmbAnnex();
                hdmbAnnex.Systemref = id;
                hdmbAnnex.Number = SoPhuKien_Annex_HDMB;
                hdmbAnnex.NoiDung = content;
                hdmbAnnex.Path = hdmb.Sohd + "_PK" + SoPhuKien_Annex_HDMB + ".doc";
                hdmbAnnex.NgayTao = DateTime.Now;
                _context.HdmbAnnices.Add(hdmbAnnex);
                _context.SaveChanges();
            }
            ExportWord_Annex(id, hdmb.Sohd + "_PK" + SoPhuKien_Annex_HDMB + ".doc", hdmb.MuaBan, SoPhuKien_Annex_HDMB, Annex);
            TempData["alertMessage"] = "Thêm chi tiết hợp đồng thành công";
            return RedirectToAction("HopDong");
        }
        public void ExportWord_Annex(string id, string fileName, string TypeKD, string Number, List<int> Annex)
        {
            CultureInfo ci = new CultureInfo("en-us");
            var Sp = "";
            if (TypeKD == "MUA")
            {
                Sp = "exec sp_hdmb_annex;2 @Systemref = '" + id + "'," +
                        "@SoPK = '" + Number + "'";
            }
            else
            {
                Sp = "exec sp_hdmb_annex;4 @systemref = '" + id + "'," +
                        "@SoPK = '" + Number + "'";
            } 
            var Annex_HDMB = _context.Sp_HDMB_Annices.FromSqlRaw(Sp).ToList();
            var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
            using (WordDocument document = new WordDocument())
            {
                Stream docStream = System.IO.File.OpenRead(_hostingEnvironment.WebRootPath + "\\Template\\PhuKienHopDong\\MauPKHD_MUA.docx");
                document.Open(docStream, FormatType.Docx);
                docStream.Dispose();
                document.Replace("«sophukien»", Number, true, true);
                document.Replace("«Ngay»", DateTime.Now.Day.ToString(), true, true);
                document.Replace("«Thang»", DateTime.Now.Month.ToString(), true, true);
                document.Replace("«Nam»", DateTime.Now.Year.ToString(), true, true);
                document.Replace("«sohd»", Annex_HDMB[0].sohd, true, true);
                document.Replace("«ngayky»", Annex_HDMB[0].ngayky, true, true);
                document.Replace("«TenA»", Annex_HDMB[0].TenA, true, true);
                document.Replace("«DiachiA»", Annex_HDMB[0].DiachiA, true, true);
                document.Replace("«DienthoaiA»", Annex_HDMB[0].DienthoaiA, true, true);
                document.Replace("«FaxA»", Annex_HDMB[0].FaxA, true, true);
                document.Replace("«TaikhoanA»", Annex_HDMB[0].TaikhoanA, true, true);
                document.Replace("«NganhangA»", Annex_HDMB[0].NganhangA, true, true);
                document.Replace("«MasothueA»", Annex_HDMB[0].MasothueA, true, true);
                document.Replace("«nguoikyA»", Annex_HDMB[0].nguoikyA, true, true);
                document.Replace("«chucvuA»", Annex_HDMB[0].chucvuA, true, true);
                document.Replace("«TenB»", Annex_HDMB[0].TenB, true, true);
                document.Replace("«DiachiB»", Annex_HDMB[0].DiachiB, true, true);
                document.Replace("«DienthoaiB»", Annex_HDMB[0].DienthoaiB, true, true);
                document.Replace("«FaxB»", Annex_HDMB[0].FaxB, true, true);
                document.Replace("«TaikhoanB»", Annex_HDMB[0].TaikhoanB, true, true);
                document.Replace("«NganhangB»", Annex_HDMB[0].NganhangB, true, true);
                document.Replace("«MasothueB»", Annex_HDMB[0].MasothueB, true, true);
                document.Replace("«nguoikyB»", Annex_HDMB[0].nguoikyB, true, true);
                document.Replace("«chucvuB»", Annex_HDMB[0].chucvuB, true, true);
                foreach (var item in Annex)
                {
                    if (item == 0)
                    {
                        document.Replace("«DieuKhoan1»", "ĐIỀU I CỦA HỢP ĐỒNG ĐƯỢC THAY ĐỔI NHƯ SAU:", true, true);
                    }

                    if (item == 1)
                    {
                        document.Replace("«DieuKhoan2»", "ĐIỀU II CỦA HỢP ĐỒNG ĐƯỢC THAY ĐỔI NHƯ SAU:", true, true);
                        document.Replace("«quycach»", "1. Quy cách phẩm chất:", true, true);
                        document.Replace("«noidungquycach»", Annex_HDMB[0].quycach, true, true);
                        document.Replace("«BaoBi»", "2. Bao bì: ", true, true);
                        document.Replace("«noidungbaobi»", Annex_HDMB[0].BaoBi, true, true);
                        document.Replace("«KiemDinh»", "3. Kiểm định: ", true, true);
                        document.Replace("«noidungkiemdinh»", Annex_HDMB[0].KiemDinh, true, true);
                    }
                    if (item == 2)
                    {
                        document.Replace("«DieuKhoan3»", "ĐIỀU III CỦA HỢP ĐỒNG ĐƯỢC THAY ĐỔI NHƯ SAU:", true, true);
                        document.Replace("«noidungdieukhoan3»", "Bên A ứng cho bên B tối đa giá trị tạm tính lô hàng trong vòng " +
                            Annex_HDMB[0].MucUng + "trị giá tạm tính lô hàng trong vòng 07 ngày giao hàng, với lãi xuất tính theo lãi suất ngân hàng. " +
                            "Số tiền còn lại thanh toán sau khi bên B hoàn tất nghĩa vụ giao hàng và chốt giá xong.", true, true);
                    }
                    if (item == 3)
                    {
                        document.Replace("«DieuKhoan4»", "ĐIỀU IV CỦA HỢP ĐỒNG ĐƯỢC THAY ĐỔI NHƯ SAU:", true, true);
                        document.Replace("«DiaDiemGiaoHang»", "Địa điểm giao hàng: " + Annex_HDMB[0].DiaDiemGiaoHang, true, true);
                        document.Replace("«ThoiGianGiaoHang»", "Thời gian giao hàng : chậm nhất " + Annex_HDMB[0].ngaygiaohang +
                            "(Ngày giao hàng chính thức theo hướng dẫn giao hàng cụ thể của bên A qua Fax).", true, true);
                        document.Replace("«phivanchuyen»", "Phí Vận chuyển: " + Annex_HDMB[0].phivanchuyen, true, true);
                        document.Replace("«phibocxep»", "Phí bốc xếp: " + Annex_HDMB[0].phibocxep, true, true);
                    }
                    if (item == 4)
                    {
                        document.Replace("«DieuKhoan5»", "ĐIỀU V CỦA HỢP ĐỒNG ĐƯỢC THAY ĐỔI NHƯ SAU:", true, true);  
                        document.Replace("«DieuKhoanPhat»", "Điều khoản phạt: ", true, true);
                        document.Replace("«NoiDungDieuKhoanPhat»", "Hai bên cam kết thực hiện đầy đủ các điều khoản đã " +
                            "ghi trong hợp đồng. Nếu bên nào vi phạm hợp đồng, bên đó phải chịu phạt 10% trên trị " +
                            "giá hợp đồng và hoàn toàn chịu trách nhiệm bồi thường toàn bộ giá trị thiệt hại thực tế phát " +
                            "sinh gây ra cho bên kia. Không được đơn phương hủy bỏ hợp đồng, nếu có khó khăn trở ngại các " +
                            "bên phải báo trước 07 (bảy) ngày để hai bên bàn bạc cùng nhau giải quyết. Bên A có quyền cấn trừ" +
                            " bất cứ các khoản nợ nào mà bên B còn thiếu vào thời điểm thanh toán.", true, true);
                        document.Replace("«DieuKhoanTrongTai»", "Điều khoản trọng tài: ", true, true);
                        document.Replace("«NoiDungDieuKhoanTrongTai»", "Nếu có tranh chấp  xảy ra thì phán quyết của Tòa Kinh tế tại " + Annex_HDMB[0].ToaKinhTe +
                            "có hiệu lực cuối cùng buộc hai bên thi hành.", true, true);
                        document.Replace("«DieuKhoanHieuLucHopDong»", "Điều khoản hiệu lực hợp đồng: ", true, true);
                        document.Replace("«NoiDungDieuKhoanHieuLucHopDong»", "Hợp đồng có giá trị từ ngày ký đến ngày" + Annex_HDMB[0].ngaygiaohang +
                            " .Sau khi đã thực hiện xong hợp đồng, hai bên có nghĩa vụ chiếu thanh lý hợp đồng, chậm nhất là " +
                            "15 ngày kể từ ngày 2 bên hoàn tất thực hiện hợp đồng. Quá thời hạn hiệu lực hợp đồng mà hai bên " +
                            "không còn nợ nần hoặc không có tranh chấp gì thì hợp đồng này mặc nhiên được thanh lý.", true, true);
                    }

                }
                foreach (var item1 in Annex)
                {
                    if (item1 != 0)
                    {
                        document.Replace("«DieuKhoan1»", "", false, true);
                        document.Replace("«[TABLE_PRICE]»", "", false, true);
                    }
                    if (item1 != 1)
                    {
                        document.Replace("«DieuKhoan2»", "", false, true);
                        document.Replace("«quycach»", "", false, true);
                        document.Replace("«noidungquycach»", "", false, true);
                        document.Replace("«BaoBi»", "", false, true);
                        document.Replace("«noidungbaobi»", "", false, true);
                        document.Replace("«KiemDinh»", "", false, true);
                        document.Replace("«noidungkiemdinh»", "", false, true);
                    }
                    if (item1 != 2)
                    {
                        document.Replace("«DieuKhoan3»", "", false, true);
                        document.Replace("«noidungdieukhoan3»", "", false, true);
                    }
                    if (item1 != 3)
                    {
                        document.Replace("«DieuKhoan4»", "", false, true);
                        document.Replace("«DiaDiemGiaoHang»", "", false, true);
                        document.Replace("«ThoiGianGiaoHang»", "", false, true);
                        document.Replace("«phivanchuyen»", "", false, true);
                        document.Replace("«phibocxep»", "", false, true);
                    }
                    if (item1 != 4)
                    {
                        document.Replace("«DieuKhoan5»", "", false, true);
                        document.Replace("«DieuKhoanPhat»", "", false, true);
                        document.Replace("«NoiDungDieuKhoanPhat»", "", false, true);
                        document.Replace("«DieuKhoanTrongTai»", "", false, true);
                        document.Replace("«NoiDungDieuKhoanTrongTai»", "", false, true);
                        document.Replace("«DieuKhoanHieuLucHopDong»", "", false, true);
                        document.Replace("«NoiDungDieuKhoanHieuLucHopDong»", "", false, true);
                    }
                }
                WTable wTable = new WTable(document);
                var ctHDMB = (from a in _context.CtHdmbs
                              where a.Systemref == id
                              select new
                              {
                                  Tenhang = _context.Hanghoas.Where(b => b.Mahang == a.Mahang).Select(b => b.Fullname).FirstOrDefault(),
                                  a.Dvt,
                                  a.Soluong,
                                  a.Giact,
                                  Thanhtien = a.Giact * a.Trongluong

                              }).ToList();

                wTable.ResetCells(ctHDMB.Count + 2, 5);
                wTable.TableFormat.Borders.BorderType = BorderStyle.Single;
                wTable.TableFormat.IsAutoResized = true;
                wTable[0, 0].AddParagraph().AppendText("TÊN HÀNG");
                wTable[0, 0].Width = 200;
                wTable[0, 1].AddParagraph().AppendText("SỐ LƯỢNG");
                wTable[0, 2].AddParagraph().AppendText("ĐVT");
                wTable[0, 3].AddParagraph().AppendText("ĐƠN GIÁ (VNĐ)");
                wTable[0, 4].AddParagraph().AppendText("THÀNH TIỀN (VNĐ)");
                wTable[ctHDMB.Count + 1, 0].AddParagraph().AppendText("Tổng cộng");
                wTable[ctHDMB.Count + 1, 0].Width = 200;
                decimal TongCong = 0;
                for (var i = 0;i < ctHDMB.Count; i++)
                {
                    wTable[i + 1, 0].AddParagraph().AppendText(ctHDMB[i].Tenhang);
                    wTable[i + 1, 0].Width = 200;
                    wTable[i + 1, 1].AddParagraph().AppendText(ctHDMB[i].Soluong.ToString("N1", ci));
                    wTable[i + 1, 2].AddParagraph().AppendText(ctHDMB[i].Dvt);
                    wTable[i + 1, 3].AddParagraph().AppendText(ctHDMB[i].Giact.ToString("N1", ci));
                    wTable[i + 1, 4].AddParagraph().AppendText(ctHDMB[i].Thanhtien.ToString("N1", ci));
                    TongCong = TongCong + ctHDMB[i].Thanhtien;
                }
                wTable[Annex_HDMB.Count + 1, 4].AddParagraph().AppendText(TongCong.ToString("N1", ci));
                TextBodyPart textBody = new TextBodyPart(document);
                textBody.BodyItems.Add(wTable);
                document.Replace("[TABLE_PRICE]", textBody, true, true, true);
                if (Directory.Exists(_hostingEnvironment.WebRootPath + "\\Export\\PhuKienHopDong\\" + id))
                {
                    docStream = System.IO.File.Create(_hostingEnvironment.WebRootPath + "\\Export\\PhuKienHopDong\\" + id + "\\PK" + Number + ".doc");
                    document.Save(docStream, FormatType.Docx);
                    docStream.Dispose();
                }
                else
                {
                    string pathString = _hostingEnvironment.WebRootPath + "\\Export\\PhuKienHopDong\\" + id;
                    System.IO.Directory.CreateDirectory(pathString);
                    docStream = System.IO.File.Create(_hostingEnvironment.WebRootPath + "\\Export\\PhuKienHopDong\\" + id + "\\PK" + Number + ".doc");
                    document.Save(docStream, FormatType.Docx);
                    docStream.Dispose();
                }

            }
        }
        public IActionResult ExportWord_Annex_HDMB(int id)
        {
            var Annex = _context.HdmbAnnices.Where(a => a.Id == id).FirstOrDefault();
            var PathAnnex = _hostingEnvironment.WebRootPath + "\\Export\\PhuKienHopDong\\" + Annex.Systemref + "\\PK" + Annex.Number + ".doc";
            if (System.IO.File.Exists(PathAnnex))
            {
                var filePath = _hostingEnvironment.WebRootPath + "\\Export\\PhuKienHopDong\\" + Annex.Systemref;
                var path = Path.Combine(filePath, "PK" + Annex.Number + ".doc");
                var fs = new FileStream(path, FileMode.Open);
                return File(fs, "application/force-download", Annex.Path);
            }
            else
            {
                TempData["alertMessage"] = "File không tồn tại";
                return RedirectToAction("hdmb");
            }
        }
        [HttpGet]
        public object LoadGiaoNhan_HistoryHDMB(string id, DataSourceLoadOptions loadOptions)
        {
            var Sp = "";
            if (id == null)
            {
                return new List<string>();
            }
            else
            {
                var MaHang = id;
                var SystemrefHDMB1 = SystemrefHDMB;
                if (SystemrefHDMB1 != string.Empty || SystemrefHDMB1 != null)
                {
                    var hdmb = _context.Hdmbs.Where(a => a.Systemref == SystemrefHDMB1).FirstOrDefault();
                    var muaban = hdmb.MuaBan;
                    if (muaban == "BAN" || muaban == "CMUON")
                    {
                        Sp = "exec [dbo].[UdscCt_hdmb];7 @macn = '" + "INX" + "'," +
                               "@Systemref = '" + SystemrefHDMB + "'," +
                               "@mahang = '" + MaHang + "'," +
                               "@TheoHD = '1'," +
                               "@ngaygiaofrom = ''," +
                               "@ngaygiaoto = ''";
                    }
                    else if (muaban == "MUA" || muaban == "MUON" || muaban == "KTRA")
                    {
                        Sp = "exec [dbo].[UdscCt_hdmb1] @macn = '" + "INX" + "'," +
                                "@Systemref = '" + SystemrefHDMB + "'," +
                                "@mahang = '" + MaHang + "'," +
                                "@TheoHD = '1'," +
                                "@ngaygiaofrom = ''," +
                                "@ngaygiaoto = ''";
                    }

                }
            }
            var item = _context.Sp_GiaoNhan_HistoryHDMBs.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
    }
}
