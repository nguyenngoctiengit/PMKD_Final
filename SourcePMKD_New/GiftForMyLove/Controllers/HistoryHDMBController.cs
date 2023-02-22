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
    public class HistoryHDMBController : Controller
    {
        public TradingsystemContext _context = new TradingsystemContext();
        public IActionResult HistoryHDMB()
        {
            return View("HistoryHDMB");
        }
        [HttpPost]
        public JsonResult GetDataHistoryHDMB(string sohd_History_HDMB, string Fill_Type_HDMB, string Ref_History_HDMB)
        {
            var sohd_History_HDMB1 = sohd_History_HDMB == null ? "" : sohd_History_HDMB;
            var Ref_History_HDMB1 = Ref_History_HDMB == null ? "" : Ref_History_HDMB;
            var Sp = "exec udsHdmb1 @mua_ban = '" + Fill_Type_HDMB + "'," +
            "@sohd = '" + sohd_History_HDMB1 + "'," +
            "@macn = '" + "INX" + "'," +
            "@Ref = '"+ Ref_History_HDMB1 + "'";
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
                    Sp = "exec [dbo].[UdscCt_hdmb1] @macn = '" + "INX" + "'," +
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
        public JsonResult GetDataGiaoNhan_AfterSelected(string mahang,string systemref)
        {
            var muaban = _context.Hdmbs.Where(a => a.Systemref == systemref).Select(a => a.MuaBan).FirstOrDefault();
            var Sp = "";
            if (muaban == "BAN" || muaban == "CMUON")
            {
                Sp = "exec [dbo].[UdscCt_hdmb];7 @macn = '" + "INX" + "'," +
                        "@Systemref = '" + systemref + "'," +
                        "@mahang = '" + mahang + "'," +
                        "@TheoHD = '1'," +
                        "@ngaygiaofrom = ''," +
                        "@ngaygiaoto = ''";
            }
            else if (muaban == "MUA" || muaban == "MUON" || muaban == "KTRA")
            {
                Sp = "exec [dbo].[UdscCt_hdmb1] @macn = '" + "INX" + "'," +
                        "@Systemref = '" + systemref + "'," +
                        "@mahang = '" + mahang + "'," +
                        "@TheoHD = '1'," +
                        "@ngaygiaofrom = ''," +
                        "@ngaygiaoto = ''";
            }
            var item = _context.Sp_GiaoNhan_HistoryHDMBs.FromSqlRaw(Sp).ToList();
            return Json(item);

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
    }
}
