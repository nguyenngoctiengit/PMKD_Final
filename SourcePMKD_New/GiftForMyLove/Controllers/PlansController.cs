using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using GiftForMyLove.Models;
using GiftForMyLove.Models.ClassFunction;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForMyLove.Controllers
{
    public class PlansController : Controller
    {
        IWebHostEnvironment _hostingEnvironment;
        public TradingsystemContext _context = new TradingsystemContext();
        public PlansController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Plans()
        {
            return View("Plans");
        }
        [HttpGet]
        public object GetPAKD(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Plans
                        where a.IsNew == true && a.Macn == "INX"
                        select new
                        {
                            SystemId = a.SystemId.Trim(),
                            SoPa = a.SoPa.Trim(),
                            LaiRong = a.LaiRong,
                            NgayPa = a.NgayPa,
                            Trangthai = a.Trangthai
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public IActionResult Fill_Form_Plans(string Systemref)
        {

            var data = (from a in _context.Plans
                        where a.SystemId == Systemref
                        select new
                        {
                            a.SystemId,
                            a.SoPa,
                            a.NgayPa,
                            a.DoiTacMua,
                            a.DoiTacBan,
                            a.DanhGiaMua,
                            a.DanhGiaBan,
                            a.HangHoa,
                            Trongluong = Convert.ToDecimal(a.Trongluong).ToString("#,###.##"),
                            a.Isfix,
                            TyGia = Convert.ToDecimal(a.TyGia).ToString("#,###.##"),
                            a.NguonVon,
                            a.LaiSuat,
                            a.Songay,
                            a.Dieukiengiao,
                            a.ThanhToanMua,
                            a.ThanhToanBan,
                            a.GhiChu,
                            a.Dvt,
                            a.HdBan,
                            a.HdMua,
                            a.CtTinhLaiVay,
                            a.DienGiaiNguonVon,
                            a.CangGiaoHang,
                            a.NoiNhanHang,
                            a.Ngaygiao,
                            a.Tientechenhlech,
                            TriGiaBanU = string.Format("{0:N4}", a.TriGiaBanU),
                            a.Chenhlechmuaban,
                            TriGiaMua = string.Format("{0:N0}", a.TriGiaMua),
                            a.Tienteban,
                            a.Tientemua,
                            a.GiaMuaU,
                            a.GiaBanU,
                            a.TienTeGn,
                            a.TienTeHh,
                            a.TienTeVc,
                            a.TienTeCuocTau,
                            a.TienTeBaoHiem,
                            a.TienTeQly,
                            a.TienTeThc,
                            a.TienTeKhuTrung,
                            a.TienTeLaiVay,
                            a.TienTeKhac,
                            a.DvtBh,
                            a.DvtCt,
                            a.DvtGd,
                            a.DvtGn,
                            a.DvtHh,
                            a.DvtKhac,
                            a.DvtKt,
                            a.DvtLv,
                            a.DvtThc,
                            a.DvtVcnd,
                            a.SoCont,
                            TriGiaBan = string.Format("{0:N0}", a.TriGiaBan),
                            GiaBan = string.Format("{0:N0}", a.GiaBan),
                            TriGiaMuaU = string.Format("{0:N0}", a.TriGiaMuaU),
                            GiaMua = string.Format("{0:N0}", a.GiaMua),
                            LaiGop = string.Format("{0:N0}", a.LaiGop),
                            CpCuocTau = string.Format("{0:N" + (a.TienTeCuocTau == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpCuocTau))),
                            CpVanTai = string.Format("{0:N" + (a.TienTeVc == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpVanTai))),
                            CpBaoHiem = string.Format("{0:N" + (a.TienTeBaoHiem == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpBaoHiem))),
                            CpHoaHong = string.Format("{0:N" + (a.TienTeHh == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpHoaHong))),
                            CpGiaoNhan = string.Format("{0:N" + (a.TienTeGn == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpGiaoNhan))),
                            CpQuanLy = string.Format("{0:N" + (a.TienTeQly == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpQuanLy))),
                            CpThc = string.Format("{0:N" + (a.TienTeThc == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpThc))),
                            CpKhuTrung = string.Format("{0:N" + (a.TienTeKhuTrung == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpKhuTrung))),
                            CpLaiVay = string.Format("{0:N" + (a.TienTeLaiVay == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpLaiVay))),
                            CpKhac = string.Format("{0:N" + (a.TienTeKhac == "VND" ? "0}" : "4}"), (Convert.ToDecimal(a.CpKhac))),
                            Tongchiphi = string.Format("{0:N0}", a.Tongchiphi),
                            LaiRong = string.Format("{0:N0}", a.LaiRong),
                            a.Songay1,
                            CuocTau_U = a.TienTeCuocTau == "VND" ? "0" : string.Format("{0:N4}", (a.CpCuocTau * a.SoCont)),
                            CuocTau_V = a.TienTeCuocTau == "VND" ? string.Format("{0:N0}", (a.CpCuocTau * a.SoCont)) : string.Format("{0:N0}", ((decimal)a.CpCuocTau * a.SoCont * a.TyGia)),
                            VanTai_U = a.TienTeVc == "VND" ? "0" : string.Format("{0:N4}", ((decimal)a.CpVanTai * a.Trongluong / (a.DvtVcnd == "KG" ? 1 : 1000))),
                            VanTai_V = a.TienTeVc == "VND" ? string.Format("{0:N0}", (decimal)a.CpVanTai * a.Trongluong / (a.DvtVcnd == "KG" ? 1 : 1000)) : string.Format("{0:N0}", ((decimal)a.CpVanTai * a.Trongluong / (a.DvtVcnd == "KG" ? 1 : 1000) * a.TyGia)),
                            BaoHiem_U = a.Tienteban == "VND" ? "0" : string.Format("{0:N4}", ((decimal)a.CpBaoHiem * a.Trongluong * (decimal)a.GiaBanU / (a.DvtBh == "KG" ? 1 : 1000) / 100)),
                            BaoHiem_V = a.Tienteban == "VND" ? string.Format("{0:N0}", ((decimal)a.CpBaoHiem * a.Trongluong * (decimal)a.GiaBanU / (a.DvtBh == "KG" ? 1 : 1000) / 100)) : string.Format("{0:N0}", ((decimal)a.CpBaoHiem * a.Trongluong * (decimal)a.GiaBanU / (a.DvtBh == "KG" ? 1 : 1000) * a.TyGia / 100)),
                            HoaHong_U = a.TienTeHh == "VND" ? "0" : string.Format("{0:N4}", ((decimal)a.CpHoaHong * a.Trongluong / (a.DvtHh == "KG" ? 1 : 1000))),
                            HoaHong_V = a.TienTeHh == "VND" ? string.Format("{0:N0}", ((decimal)a.CpHoaHong * a.Trongluong / (a.DvtHh == "KG" ? 1 : 1000))) : string.Format("{0:N0}", ((decimal)a.CpHoaHong * a.Trongluong / (a.DvtHh == "KG" ? 1 : 1000) * a.TyGia)),
                            GiaoNhan_U = a.TienTeGn == "VND" ? "0" : (a.DvtGn == "CONT" ? string.Format("{0:N4}", (a.CpGiaoNhan * a.SoCont)) : string.Format("{0:N4}", (decimal)a.CpGiaoNhan * a.Trongluong / (a.DvtGn == "KG" ? 1 : 1000))),
                            GiaoNhan_V = a.TienTeGn == "VND" ? (a.TienTeGn == "CONT" ? string.Format("{0:N0}", a.CpGiaoNhan * a.SoCont) : string.Format("{0:N0}", ((decimal)a.CpGiaoNhan * a.Trongluong / (a.DvtGn == "KG" ? 1 : 1000)))) : (a.DvtGn == "CONT" ? string.Format("{0:N0}", ((decimal)a.CpGiaoNhan * a.SoCont * a.TyGia)) : string.Format("{0:N0}", ((decimal)a.CpGiaoNhan * a.Trongluong / (a.DvtGn == "KG" ? 1 : 1000) * a.TyGia))),
                            GiamDinh_U = a.TienTeQly == "VND" ? "0" : (a.DvtGd == "CONT" ? string.Format("{0:N4}", (a.CpQuanLy * a.SoCont)) : string.Format("{0:N4}", ((decimal)a.CpQuanLy * a.Trongluong / (a.DvtGd == "KG" ? 1 : 1000)))),
                            GiamDinh_V = a.TienTeQly == "VND" ? (a.DvtGd == "CONT" ? string.Format("{0:N0}", (a.CpQuanLy * a.SoCont)) : string.Format("{0:N0}", ((decimal)a.CpQuanLy * a.Trongluong / (a.DvtGd == "KG" ? 1 : 1000)))) : (a.DvtGd == "CONT" ? string.Format("{0:N0}", (decimal)a.CpQuanLy * a.SoCont * (decimal)a.TyGia) : string.Format("{0:N0}", (decimal)a.CpQuanLy * a.Trongluong / (a.DvtGd == "KG" ? 1 : 1000) * a.TyGia)),
                            THC_U = a.TienTeThc == "VND" ? "0" : (a.DvtThc == "CONT" ? string.Format("{0:N4}", a.CpThc * a.SoCont) : string.Format("0:N4", ((decimal)a.CpThc * a.Trongluong / (a.DvtThc == "KG" ? 1 : 1000)))),
                            THC_V = a.TienTeThc == "VND" ? (a.DvtThc == "CONT" ? string.Format("{0:N0}", (a.CpThc * a.SoCont)) : string.Format("{0:N0}", ((decimal)a.CpThc * a.Trongluong / (a.DvtThc == "KG" ? 1 : 1000)))) : (a.DvtThc == "CONT" ? string.Format("{0:N0}", ((decimal)a.CpThc * a.SoCont * a.TyGia)) : string.Format("{0:N0}", ((decimal)a.CpThc * a.Trongluong / (a.DvtThc == "KG" ? 1 : 1000) * a.TyGia))),
                            KhuTrung_U = a.TienTeKhuTrung == "VND" ? "0" : (a.DvtKt == "CONT" ? string.Format("{0:N4}", (a.CpKhuTrung * a.SoCont)) : string.Format("{0:N0}", ((decimal)a.CpKhuTrung * a.Trongluong / (a.DvtKt == "KG" ? 1 : 1000)))),
                            KhuTrung_V = a.TienTeKhuTrung == "VND" ? (a.DvtKt == "CONT" ? string.Format("{0:N0}", (a.CpKhuTrung * a.SoCont)) : string.Format("{0:N0}", ((decimal)a.CpKhuTrung * a.Trongluong / (a.DvtKt == "KG" ? 1 : 1000)))) : (a.DvtKt == "CONT" ? string.Format("{0:N0}", (decimal)a.CpKhuTrung * a.SoCont * a.TyGia) : string.Format("{0:N0}", ((decimal)a.CpKhuTrung * a.Trongluong / (a.DvtKt == "KG" ? 1 : 1000) * a.TyGia))),
                            LaiVay_U = a.TienTeLaiVay == "VND" ? "0" : string.Format("{0:N4}", ((decimal)a.CpLaiVay * a.Trongluong / (a.DvtLv == "KG" ? 1 : 1000))),
                            LaiVay_V = a.TienTeLaiVay == "VND" ? string.Format("{0:N0}", ((decimal)a.CpLaiVay * a.Trongluong / (a.DvtLv == "KG" ? 1 : 1000))) : string.Format("{0:N0}", ((decimal)a.CpLaiVay * a.Trongluong / (a.DvtLv == "KG" ? 1 : 1000) * a.TyGia)),
                            Khac_U = a.TienTeKhac == "VND" ? "0" : string.Format("{0:N0}", ((decimal)a.CpKhac * a.Trongluong / (a.DvtKhac == "KG" ? 1 : 1000))),
                            Khac_V = a.TienTeKhac == "VND" ? string.Format("{0:N0}", ((decimal)a.CpKhac * a.Trongluong / (a.DvtKhac == "KG" ? 1 : 1000))) : string.Format("{0:N0}", ((decimal)a.CpKhac * a.Trongluong / (a.DvtKhac == "KG" ? 1 : 1000) * a.TyGia)),
                        }).FirstOrDefault();
            return Json(data);
        }
        [HttpPost]
        public IActionResult AddPakd(Plan plan)
        {
            var plans = new Plan();
            plans.SystemId = AutoId.AutoIdFileStored("Plans");
            plans.SoPa = plan.SoPa;
            plans.NgayPa = plan.NgayPa;
            plans.DoiTacBan = plan.DoiTacBan;
            plans.DanhGiaBan = plan.DanhGiaBan;
            plans.DoiTacMua = plan.DoiTacMua;
            plans.DanhGiaMua = plan.DanhGiaMua;
            plans.HangHoa = plan.HangHoa;
            plans.Trongluong = plan.Trongluong;
            plans.TyGia = plan.TyGia;
            plans.NguonVon = plan.NguonVon;
            plans.LaiSuat = plan.LaiSuat;
            plans.Songay = plan.Songay;
            plans.Dieukiengiao = plan.Dieukiengiao;
            plans.Ngaygiao = plan.Ngaygiao;
            plans.ThanhToanMua = plan.ThanhToanMua;
            plans.ThanhToanBan = plan.ThanhToanBan;
            plans.GiaBan = plan.GiaBan;
            plans.GiaMua = plan.GiaMua;
            plans.LaiGop = plan.LaiGop;
            plans.CpVanTai = plan.CpVanTai;
            plans.CpHoaHong = plan.CpHoaHong;
            plans.CpGiaoNhan = plan.CpGiaoNhan;
            plans.CpLaiVay = plan.CpLaiVay;
            plans.CpQuanLy = plan.CpQuanLy;
            plans.CpKhac = plan.CpKhac;
            plans.LaiRong = plan.LaiRong;
            plans.Duyet = true;
            plans.Macn = "INX";
            plans.Tongchiphi = plan.Tongchiphi;
            plans.Tientemua = plan.Tientemua;
            plans.Tienteban = plan.Tienteban;
            plans.GiaMuaU = plan.GiaMuaU;
            plans.GiaBanU = plan.GiaBanU;
            plans.TriGiaMua = plan.TriGiaMua;
            plans.TriGiaBan = plan.TriGiaBan;
            plans.TriGiaMuaU = plan.TriGiaMuaU;
            plans.TriGiaBanU = plan.TriGiaBanU;
            plans.Dvt = plan.Dvt;
            plans.Chenhlechmuaban = Convert.ToDecimal(plan.GiaBanU) - Convert.ToDecimal(plan.GiaMuaU);
            plans.Tientechenhlech = plan.Isfix == false ? "Null" : plans.Tientechenhlech;
            plans.Isfix = plan.Isfix;
            plans.GhiChu = plan.GhiChu;
            plans.HdMua = plan.HdMua;
            plans.HdBan = plan.HdBan;
            plans.DienGiaiNguonVon = plan.DienGiaiNguonVon;
            plans.CtTinhLaiVay = plan.CtTinhLaiVay;
            plans.TienTeVc = plan.TienTeVc;
            plans.TienTeHh = plan.TienTeHh;
            plans.TienTeGn = plan.TienTeGn;
            plans.CangGiaoHang = plan.CangGiaoHang;
            plans.NoiNhanHang = plan.NoiNhanHang;
            plans.CpCuocTau = plan.CpCuocTau;
            plans.CpBaoHiem = plan.CpBaoHiem;
            plans.CpThc = plan.CpThc;
            plans.CpKhuTrung = plan.CpKhuTrung;
            plans.TienTeQly = plan.TienTeQly;
            plans.TienTeCuocTau = plan.TienTeCuocTau;
            plans.TienTeBaoHiem = plan.TienTeBaoHiem;
            plans.TienTeThc = plan.TienTeThc;
            plans.TienTeKhuTrung = plan.TienTeKhuTrung;
            plans.TienTeLaiVay = plan.TienTeLaiVay;
            plans.TienTeKhac = plan.TienTeKhac;
            plans.SoCont = plan.SoCont;
            plans.DvtCt = plan.DvtCt;
            plans.DvtVcnd = plan.DvtVcnd;
            plans.DvtBh = plan.DvtBh;
            plans.DvtHh = plan.DvtHh;
            plans.DvtGn = plan.DvtGn;
            plans.DvtGd = plan.DvtGd;
            plans.DvtThc = plan.DvtThc;
            plans.DvtKt = plan.DvtKt;
            plans.DvtLv = plan.DvtLv;
            plans.DvtKhac = plan.DvtKhac;
            plans.IsNew = true;
            _context.Plans.Add(plans);
            _context.SaveChanges();
            TempData["alertMessage"] = "Thêm phương án kinh doanh thành công";
            return RedirectToAction("Plans");
        }
        [HttpPost]
        public IActionResult EditPakd(Plan plan, string id)
        {
            var plans = (from a in _context.Plans where a.SystemId == id select a).FirstOrDefault();
            plans.SoPa = plan.SoPa;
            plans.NgayPa = plan.NgayPa;
            plans.DoiTacBan = plan.DoiTacBan;
            plans.DanhGiaBan = plan.DanhGiaBan;
            plans.DoiTacMua = plan.DoiTacMua;
            plans.DanhGiaMua = plan.DanhGiaMua;
            plans.HangHoa = plan.HangHoa;
            plans.Trongluong = plan.Trongluong;
            plans.TyGia = plan.TyGia;
            plans.NguonVon = plan.NguonVon;
            plans.LaiSuat = plan.LaiSuat;
            plans.Songay = plan.Songay;
            plans.Dieukiengiao = plan.Dieukiengiao;
            plans.Ngaygiao = plan.Ngaygiao;
            plans.ThanhToanMua = plan.ThanhToanMua;
            plans.ThanhToanBan = plan.ThanhToanBan;
            plans.GiaBan = plan.GiaBan;
            plans.GiaMua = plan.GiaMua;
            plans.LaiGop = plan.LaiGop;
            plans.CpVanTai = plan.CpVanTai;
            plans.CpHoaHong = plan.CpHoaHong;
            plans.CpGiaoNhan = plan.CpGiaoNhan;
            plans.CpLaiVay = plan.CpLaiVay;
            plans.CpQuanLy = plan.CpQuanLy;
            plans.CpKhac = plan.CpKhac;
            plans.LaiRong = plan.LaiRong;
            plans.Duyet = true;
            plans.Macn = plans.Macn;
            plans.Tongchiphi = plan.Tongchiphi;
            plans.Tientemua = plan.Tientemua;
            plans.Tienteban = plan.Tienteban;
            plans.GiaMuaU = plan.GiaMuaU;
            plans.GiaBanU = plan.GiaBanU;
            plans.TriGiaMua = plan.TriGiaMua;
            plans.TriGiaBan = plan.TriGiaBan;
            plans.TriGiaMuaU = plan.TriGiaMuaU;
            plans.TriGiaBanU = plan.TriGiaBanU;
            plans.Dvt = plan.Dvt;
            plans.Chenhlechmuaban = Convert.ToDecimal(plan.GiaBanU) - Convert.ToDecimal(plan.GiaMuaU);
            plans.Tientechenhlech = plan.Isfix == false ? "Null" : plans.Tientechenhlech;
            plans.Isfix = plan.Isfix;
            plans.GhiChu = plan.GhiChu == null ? "" : plan.GhiChu;
            plans.HdMua = plan.HdMua;
            plans.HdBan = plan.HdBan;
            plans.DienGiaiNguonVon = plan.DienGiaiNguonVon;
            plans.CtTinhLaiVay = plan.CtTinhLaiVay;
            plans.TienTeVc = plan.TienTeVc;
            plans.TienTeHh = plan.TienTeHh;
            plans.TienTeGn = plan.TienTeGn;
            plans.CangGiaoHang = plan.CangGiaoHang;
            plans.NoiNhanHang = plan.NoiNhanHang;
            plans.CpCuocTau = plan.CpCuocTau;
            plans.CpBaoHiem = plan.CpBaoHiem;
            plans.CpThc = plan.CpThc;
            plans.CpKhuTrung = plan.CpKhuTrung;
            plans.TienTeQly = plan.TienTeQly;
            plans.TienTeCuocTau = plan.TienTeCuocTau;
            plans.TienTeBaoHiem = plan.TienTeBaoHiem;
            plans.TienTeThc = plan.TienTeThc;
            plans.TienTeKhuTrung = plan.TienTeKhuTrung;
            plans.TienTeLaiVay = plan.TienTeLaiVay;
            plans.TienTeKhac = plan.TienTeKhac;
            plans.SoCont = plan.SoCont;
            plans.DvtCt = plan.DvtCt;
            plans.DvtVcnd = plan.DvtVcnd;
            plans.DvtBh = plan.DvtBh;
            plans.DvtHh = plan.DvtHh;
            plans.DvtGn = plan.DvtGn;
            plans.DvtGd = plan.DvtGd;
            plans.DvtThc = plan.DvtThc;
            plans.DvtKt = plan.DvtKt;
            plans.DvtLv = plan.DvtLv;
            plans.DvtKhac = plan.DvtKhac;
            plans.IsNew = true;
            _context.Plans.Update(plans);
            _context.SaveChanges();
            TempData["alertMessage"] = "Cập nhật phương án kinh doanh thành công";
            return RedirectToAction("Plans");
        }
        [HttpPost]
        public IActionResult DeletePAKD(string id)
        {
            if (_context.PairedPlans.Any(a => a.PlansId == id))
            {
                TempData["alertMessage"] = "Phương án kinh doanh đã có ghép hợp đồng nên không thể xóa";
                return RedirectToAction("pakd");
            }
            else
            {
                var Plans = _context.Plans.Where(a => a.SystemId == id).FirstOrDefault();
                Plans.Trangthai = 1;
                _context.Plans.Update(Plans);
                _context.SaveChanges();
                TempData["alertMessage"] = "Xóa phương án kinh doanh thành công";
                return RedirectToAction("Plans");
            }

        }
        public IActionResult PrintPAKD(string id)
        {
            var CurrentPath = "";
            var Sp = "exec [dbo].[UdscPAKD];10 @SystemId = '" + id + "'";
            var Pakd = _context.Sp_GetInfoPlans_PrintReports.FromSqlRaw(Sp).ToList();
            CurrentPath = _hostingEnvironment.WebRootPath + "\\Template\\PAKD\\" + "MauPA11" + ".doc";
            Stream docStream = new FileStream(CurrentPath, FileMode.Open);
            using (WordDocument wordDocument = new WordDocument())
            {
                wordDocument.Open(docStream, FormatType.Doc);
                docStream.Dispose();
                wordDocument.Replace("«soPA»", Pakd[0].soPA, true, true);
                wordDocument.Replace("«NgayPA»", Pakd[0].NgayPA, true, true);
                wordDocument.Replace("«DoiTacMua»", Pakd[0].DoiTacMua, true, true);
                wordDocument.Replace("«HD_Mua»", Pakd[0].HD_Mua, true, true);
                wordDocument.Replace("«DanhGiaMua»", Pakd[0].DanhGiaMua, true, true);
                wordDocument.Replace("«DoiTacBan»", Pakd[0].DoiTacBan, true, true);
                wordDocument.Replace("«HD_Ban»", Pakd[0].HD_Ban, true, true);
                wordDocument.Replace("«DanhGiaBan»", Pakd[0].DanhGiaBan, true, true);
                wordDocument.Replace("«HangHoa»", Pakd[0].HangHoa, true, true);
                wordDocument.Replace("«Trongluong»", Pakd[0].Trongluong, true, true);
                wordDocument.Replace("«dvt»", Pakd[0].dvt, true, true);
                wordDocument.Replace("«TyGia»", Pakd[0].TyGia, true, true);
                wordDocument.Replace("«LaiSuat»", Pakd[0].LaiSuat, true, true);
                wordDocument.Replace("«DienGiai_NguonVon»", Pakd[0].DienGiai_NguonVon == null ? "" : Pakd[0].DienGiai_NguonVon, true, true);
                wordDocument.Replace("«dieukiengiao»", Pakd[0].dieukiengiao, true, true);
                wordDocument.Replace("«CangGiaoHang»", Pakd[0].CangGiaoHang, true, true);
                wordDocument.Replace("«NoiNhanHang»", Pakd[0].NoiNhanHang, true, true);
                wordDocument.Replace("«ngaygiao»", Pakd[0].ngaygiao, true, true);
                wordDocument.Replace("«ThanhToanBan»", Pakd[0].ThanhToanBan, true, true);
                wordDocument.Replace("«ThanhToanMua»", Pakd[0].ThanhToanMua, true, true);
                wordDocument.Replace("«tienteban»", Pakd[0].tienteban, true, true);
                wordDocument.Replace("«GiaBanU»", Pakd[0].GiaBanU, true, true);
                wordDocument.Replace("«TriGiaBanU»", Pakd[0].TriGiaBanU, true, true);
                wordDocument.Replace("«TriGiaBanV»", Pakd[0].TriGiaBanV, true, true);
                wordDocument.Replace("«tientemua»", Pakd[0].tientemua, true, true);
                wordDocument.Replace("«GiaMuaU»", Pakd[0].GiaMuaU, true, true);
                wordDocument.Replace("«TriGiaMuaV»", Pakd[0].TriGiaMuaV, true, true);
                wordDocument.Replace("«LaiGop»", Pakd[0].LaiGop, true, true);
                wordDocument.Replace("«TienTe_CuocTau»", Pakd[0].TienTe_CuocTau, true, true);
                wordDocument.Replace("«Dvt_CT»", Pakd[0].Dvt_CT, true, true);
                wordDocument.Replace("«CpCuocTau»", Pakd[0].CpCuocTau, true, true);
                wordDocument.Replace("«CpCuocTau_U»", Pakd[0].CpCuocTau_U, true, true);
                wordDocument.Replace("«CpCuocTau_V»", Pakd[0].CpCuocTau_V, true, true);
                wordDocument.Replace("«TienTe_Vc»", Pakd[0].TienTe_Vc, true, true);
                wordDocument.Replace("«Dvt_Vcnd»", Pakd[0].Dvt_Vcnd, true, true);
                wordDocument.Replace("«CpVanTai»", Pakd[0].CpVanTai, true, true);
                wordDocument.Replace("«CpVanTai_U»", Pakd[0].CpVanTai_U, true, true);
                wordDocument.Replace("«CpVanTai_V»", Pakd[0].CpVanTai_V, true, true);
                wordDocument.Replace("«TienTe_BaoHiem»", Pakd[0].TienTe_BaoHiem, true, true);
                wordDocument.Replace("«Dvt_BH»", Pakd[0].Dvt_BH, true, true);
                wordDocument.Replace("«CpBaoHiem»", Pakd[0].CpBaoHiem, true, true);
                wordDocument.Replace("«CpBaoHiem_U»", Pakd[0].CpBaoHiem_U, true, true);
                wordDocument.Replace("«CpBaoHiem_V»", Pakd[0].CpBaoHiem_V, true, true);
                wordDocument.Replace("«TienTe_Hh»", Pakd[0].TienTe_Hh, true, true);
                wordDocument.Replace("«Dvt_HH»", Pakd[0].Dvt_HH, true, true);
                wordDocument.Replace("«CpHoaHong»", Pakd[0].CpHoaHong, true, true);
                wordDocument.Replace("«CpHoaHong_U»", Pakd[0].CpHoaHong_U, true, true);
                wordDocument.Replace("«CpHoaHong_V»", Pakd[0].CpHoaHong_V, true, true);
                wordDocument.Replace("«TienTe_Gn»", Pakd[0].TienTe_Gn, true, true);
                wordDocument.Replace("«Dvt_GN»", Pakd[0].Dvt_GN, true, true);
                wordDocument.Replace("«CpGiaoNhan»", Pakd[0].CpGiaoNhan, true, true);
                wordDocument.Replace("«CpGiaoNhan_U»", Pakd[0].CpGiaoNhan_U, true, true);
                wordDocument.Replace("«CpGiaoNhan_V»", Pakd[0].CpGiaoNhan_V, true, true);
                wordDocument.Replace("«TienTe_Qly»", Pakd[0].TienTe_Qly, true, true);
                wordDocument.Replace("«Dvt_GD»", Pakd[0].Dvt_GD, true, true);
                wordDocument.Replace("«CpQuanLy»", Pakd[0].CpQuanLy, true, true);
                wordDocument.Replace("«CpQuanLy_U»", Pakd[0].CpQuanLy_U, true, true);
                wordDocument.Replace("«CpQuanLy_V»", Pakd[0].CpQuanLy_V, true, true);
                wordDocument.Replace("«TienTe_THC»", Pakd[0].TienTe_THC, true, true);
                wordDocument.Replace("«Dvt_THC»", Pakd[0].Dvt_THC, true, true);
                wordDocument.Replace("«CpTHC»", Pakd[0].CpTHC, true, true);
                wordDocument.Replace("«CpTHC_U»", Pakd[0].CpTHC_U, true, true);
                wordDocument.Replace("«CpTHC_V»", Pakd[0].CpTHC_V, true, true);
                wordDocument.Replace("«TienTe_KhuTrung»", Pakd[0].TienTe_KhuTrung, true, true);
                wordDocument.Replace("«Dvt_KT»", Pakd[0].Dvt_KT, true, true);
                wordDocument.Replace("«CpKhuTrung»", Pakd[0].CpKhuTrung, true, true);
                wordDocument.Replace("«CpKhuTrung_U»", Pakd[0].CpKhuTrung_U, true, true);
                wordDocument.Replace("«CpKhuTrung_V»", Pakd[0].CpKhuTrung_V, true, true);
                wordDocument.Replace("«TienTe_LaiVay»", Pakd[0].TienTe_LaiVay, true, true);
                wordDocument.Replace("«Dvt_LV»", Pakd[0].Dvt_LV, true, true);
                wordDocument.Replace("«CpLaiVay»", Pakd[0].CpLaiVay, true, true);
                wordDocument.Replace("«CpLaiVay_U»", Pakd[0].CpLaiVay_U, true, true);
                wordDocument.Replace("«CpLaiVay_V»", Pakd[0].CpLaiVay_V, true, true);
                wordDocument.Replace("«TienTe_Khac»", Pakd[0].TienTe_Khac, true, true);
                wordDocument.Replace("«Dvt_Khac»", Pakd[0].Dvt_Khac, true, true);
                wordDocument.Replace("«CpKhac»", Pakd[0].CpKhac, true, true);
                wordDocument.Replace("«CpKhac_U»", Pakd[0].CpKhac_U, true, true);
                wordDocument.Replace("«CpKhac_V»", Pakd[0].CpKhac_V, true, true);
                wordDocument.Replace("«TongChiPhi»", Pakd[0].TongChiPhi, true, true);
                wordDocument.Replace("«ChiPhi_SX»", Pakd[0].ChiPhi_SX.ToString(), true, true);
                wordDocument.Replace("«LoiNhuan_SX»", Pakd[0].LoiNhuan_SX.ToString(), true, true);
                wordDocument.Replace("«LaiRong»", Pakd[0].LaiRong, true, true);
                wordDocument.Replace("«TL_LoiNhuan»", Pakd[0].TL_LoiNhuan, true, true);
                wordDocument.Replace("«GhiChu»", Pakd[0].GhiChu, true, true);
                MemoryStream stream = new MemoryStream();
                wordDocument.Save(stream, FormatType.Docx);
                stream.Position = 0;
                return File(stream, "application/msword", Pakd[0].soPA + ".docx");
            }
        }
    }
}
