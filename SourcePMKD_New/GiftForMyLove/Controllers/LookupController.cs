using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using GiftForMyLove.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForMyLove.Controllers
{
    public class LookupController : Controller
    {
        public TradingsystemContext _context = new TradingsystemContext(); 
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public object GetDataNhomHangHoa(DataSourceLoadOptions loadOptions)
        {
            var item = _context.NhomHangHoas.ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetDataQuocGia(DataSourceLoadOptions loadOptions)
        {
            var item = _context.Quocgia.ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
       [HttpGet]
        public object GetDataKhuVuc(DataSourceLoadOptions loadOptions)
        {
            var item = _context.Khuvucs.ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetDataDonVi(DataSourceLoadOptions loadOptions)
        {
            var item = _context.Branches.ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object GetTienTe(DataSourceLoadOptions options)
        {
            var item_money = from a in _context.Money
                             select new
                             {
                                 Ma = a.Ma,
                                 Ten = a.Ten
                             };
            return DataSourceLoader.Load(item_money, options);
        }
        [HttpGet]
        public object LoadKHForHopDong(DataSourceLoadOptions loadOptions)
        {
            var khachhang = (from a in _context.KhachHangs
                             where a.GiaoDich == 1
                             select new
                             {
                                 a.MaKhach,
                                 a.TenKhach,
                                 checkitem = _context.CustomerNorms.Where(m => m.Makhach == a.MaKhach && m.Macn == a.MaCn).Select(a => a.ValueNorm).Count() > 0 ? 1 : 0,
                                 ValueNorm = _context.CustomerNorms.Where(m => m.Makhach == a.MaKhach && m.Macn == a.MaCn).Select(a => a.ValueNorm).FirstOrDefault(),
                                 a.Vanchuyen,
                                 a.MaHd
                             }).ToList();
            return DataSourceLoader.Load(khachhang, loadOptions);
        }
        [HttpGet]
        public object LoadClientKyForHopDong(string id, DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Signers
                        where a.MaKhach == id
                        select new
                        {
                            Makhach = a.MaKhach + a.Stt,
                            Nguoiky = a.Nguoiky.Trim() + " chức vụ " + a.Chucvu,
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object LoadIntKyForHopDong(DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.Signers
                        where a.MaKhach == "INX"
                        select new
                        {
                            Makhach = a.MaKhach + a.Stt,
                            Nguoiky = a.Nguoiky.Trim() + " chức vụ " + a.Chucvu,
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object LoadThanhToanForHopDong(string id, DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.PortfolioPayments
                        where a.LoaiHd == id && a.HinhThucGia == 0
                        select new
                        {
                            a.Matt,
                            a.TenTt,
                            a.Mucung,
                            a.ReportName,
                            a.Id
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object LoadMaHangForCtHDMB(string id, DataSourceLoadOptions loadOptions)
        {
            if (id == null)
            {
                return new List<string>();
            }
            else
            {
                var MaKhach = id;
                var Sp = "exec [Sp_hanghoa1] @mahang = ''," +
                "@makhach = '" + id + "'," +
                "@macn = '" + "INX" + "'";
                var item = _context.Sp_GetHangHoa_CtHDmbs.FromSqlRaw(Sp).ToList();
                return DataSourceLoader.Load(item, loadOptions);
            }
            
        }
        [HttpGet]
        public object LoadAnnex_HDMB(string id, DataSourceLoadOptions loadOptions)
        {
            var item = (from a in _context.HdmbAnnices
                        where a.Systemref == id
                        select new
                        {
                            a.Id,
                            a.Number,
                            a.NoiDung,
                            a.NgayTao,
                            a.Path,
                        }).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public JsonResult GetList_Annex_HDMB(string Systemref)
        {
            var MaHang_CtHDMB = _context.CtHdmbs.Where(a => a.Systemref == Systemref).Select(a => a.Mahang).FirstOrDefault();
            var MaNhom_Hanghoa = _context.Hanghoas.Where(a => a.Mahang == MaHang_CtHDMB).Select(a => a.MaNhom).FirstOrDefault();
            var listAnnex = _context.Annices.Where(a => a.MaNhom == MaNhom_Hanghoa).Select(a => a.NoiDung).ToList();
            return Json(listAnnex);
        }
        [HttpPost]
        public JsonResult GetHistory_HDMB(string Systemref)
        {
            var SoHD = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.Sohd).FirstOrDefault();
            var MuaBan = _context.Hdmbs.Where(a => a.Systemref == Systemref).Select(a => a.MuaBan).FirstOrDefault();
            var Sp = "exec udsHdmb;9 @mua_ban = '" + MuaBan + "'," +
            "@sohd = '" + SoHD + "'," +
            "@macn = '" + "INX" + "'," +
            "@Ref = ''";
            var Sp_Hdmb_HistoryHDMBs = _context.Sp_Hdmb_HistoryHDMBs.FromSqlRaw(Sp).ToList();
            return Json(Sp_Hdmb_HistoryHDMBs);
        }
        [HttpGet]
        public object LoadHangHoa_HistoryHDMB(string id, DataSourceLoadOptions loadOptions)
        {
            if (id == null)
            {
                return new List<string>();
            }
            else
            {
                var SoHD = _context.Hdmbs.Where(a => a.Systemref == id).Select(a => a.Sohd).FirstOrDefault();
                var MuaBan = _context.Hdmbs.Where(a => a.Systemref == id).Select(a => a.MuaBan).FirstOrDefault();
                var Sp = "exec udsHdmb;9 @mua_ban = '" + MuaBan + "'," +
                "@sohd = '" + SoHD + "'," +
                "@macn = '" + "INX" + "'," +
                "@Ref = ''";
                var Sp_Hdmb_HistoryHDMBs = _context.Sp_Hdmb_HistoryHDMBs.FromSqlRaw(Sp).ToList();
                return DataSourceLoader.Load(Sp_Hdmb_HistoryHDMBs, loadOptions);
            }
        }

        [HttpGet]
        public object LoadDoiTacMua_Plans(DataSourceLoadOptions loadOptions)
        {

            var Sp = (from a in _context.KhachHangs
                      where a.MaCn == "INX" && a.GiaoDich == 1
                      select new
                      {
                          MaKhach = a.MaKhach,
                          TenKhach = a.TenKhach,
                          CheckItem = a.CheckItem,
                          ValueNorm = a.CheckItem == true ? (_context.CustomerNorms.Where(b => b.Makhach == a.MaKhach && b.Macn == "INX").Sum(a => a.ValueNorm) == 0 ? 0 : (_context.CustomerNorms.Where(b => b.Makhach == a.MaKhach && b.Macn == "INX").Sum(a => a.ValueNorm))) : 0,
                          Vanchuyen = a.Vanchuyen,
                          MaHd = a.MaHd
                      });
            return DataSourceLoader.Load(Sp, loadOptions);
        }
        [HttpGet]
        public object LoadHangHoa_Plans(DataSourceLoadOptions loadOptions)
        {
            var Sp = (from a in _context.Hanghoas
                      select new
                      {
                          a.Mahang,
                          a.Tenhang,
                          a.Vat,
                          a.Dvt
                      }).ToList();
            return DataSourceLoader.Load(Sp, loadOptions);
        }
        [HttpGet]
        public object LoadThanhToan_Plans(DataSourceLoadOptions loadOptions)
        {
            var Sp = (from a in _context.PortfolioPayments
                      select new
                      {

                          a.Matt,
                          a.TenTt,
                          a.Mucung,
                          a.ReportName
                      }).ToList();
            return DataSourceLoader.Load(Sp, loadOptions);
        }
        [HttpGet]
        public object LoadChungtu_HDBan_HistoryHDMB(string id, DataSourceLoadOptions loadOptions)
        {
            var mahang = _context.CtHdmbs.Where(a => a.Systemref == id).Select(a => a.Mahang).FirstOrDefault();
            var Sp = "exec UdscVoucher;30 @Systemref = '" + id + "'," +
                        "@mahang = '" + mahang + "'";
            var item = _context.Sp_GetChungtu_HDBan_HistoryHDMBs.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        public object LoadGiaoNhan_HistoryHDMB(string id, DataSourceLoadOptions loadOptions)
        {
            if (id == null)
            {
                return new List<string>();
            }
            else
            {
                var hdmb = _context.Hdmbs.Where(a => a.Systemref == id).FirstOrDefault();
                var mahang = _context.CtHdmbs.Where(a => a.Systemref == id).Select(a => a.Mahang).FirstOrDefault();
                var muaban = hdmb.MuaBan;
                var Sp = "";
                if (muaban == "BAN" || muaban == "CMUON")
                {
                    Sp = "exec [dbo].[UdscCt_hdmb];7 @macn = '" + "INX" + "'," +
                            "@Systemref = '" + id + "'," +
                            "@mahang = '" + mahang + "'," +
                            "@TheoHD = '1'," +
                            "@ngaygiaofrom = ''," +
                            "@ngaygiaoto = ''";
                }
                else if (muaban == "MUA" || muaban == "MUON" || muaban == "KTRA")
                {
                    Sp = "exec [dbo].[UdscCt_hdmb];6 @macn = '" + "INX" + "'," +
                            "@Systemref = '" + id + "'," +
                            "@mahang = '" + mahang + "'," +
                            "@TheoHD = '1'," +
                            "@ngaygiaofrom = ''," +
                            "@ngaygiaoto = ''";
                }
                var item = _context.Sp_GiaoNhan_HistoryHDMBs.FromSqlRaw(Sp).ToList();
                return DataSourceLoader.Load(item, loadOptions);
            }
        }
    }
}
