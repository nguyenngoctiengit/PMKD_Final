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
    public class ThanhLyHDController : Controller
    {
        public TradingsystemContext _context = new TradingsystemContext();
        public IActionResult ThanhLyHD()
        {
            return View("ThanhLyHD");
        }
        [HttpGet]
        public object LoadHDMB(DataSourceLoadOptions loadOptions)
        {
            DateTime date = DateTime.Now;
            var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            var Sp = "exec GetContract2SetStatus1 @macn = '" + "INX" + "'," +
                            "@datefrom = '"+ firstDayOfMonth +"',"+
                            "@dateto = '" + lastDayOfMonth + "',"+
                            "@mua_ban = '" + "MUA" + "',"+
                            "@ContractNumber = '" + "" + "',"+
                            "@TrangThai = '" + "1" + "'";
            var Sp_Hdmb_FinishHDMBs = _context.Sp_Hdmb_FinishHDMBs.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(Sp_Hdmb_FinishHDMBs, loadOptions);
        }
        [HttpPost]
        public JsonResult FilterDataGrid_FinishHDMB(string datefrom, string dateto, string ContractType,int IsFinish)
        {
            var Sp = "exec GetContract2SetStatus1 @macn = '" + "INX" + "'," +
                "@datefrom = '" + datefrom + "'," +
                "@dateto = '" + dateto + "'," +
                "@mua_ban = '" + ContractType + "'," +
                "@ContractNumber = '" + "" + "'," +
                "@TrangThai = '" + IsFinish + "'";
            var Sp_Hdmb_FinishHDMBs = _context.Sp_Hdmb_FinishHDMBs.FromSqlRaw(Sp).ToList();
            return Json(Sp_Hdmb_FinishHDMBs);
        }
        [HttpGet]
        public object LoadCtHDMB_FinishHDMB(string id,DataSourceLoadOptions loadOptions)
        {
            var MuaBan = _context.Hdmbs.Where(a => a.Systemref == id).Select(a => a.MuaBan).FirstOrDefault();
            var Sp = "";
            if (MuaBan == "MUA")
            {
                Sp = "exec GetContract2SetStatus1;2 @ContractId = '" + id + "'";
            }
            else
            {
                Sp = "exec GetContract2SetStatus1;3 @ContractId = '" + id + "'";
            }
            var Sp_CtHDMB_FinishHDMBs = _context.Sp_CtHDMB_FinishHDMBs.FromSqlRaw(Sp).ToList();
            return DataSourceLoader.Load(Sp_CtHDMB_FinishHDMBs, loadOptions);
        }
        [HttpPost]
        public IActionResult FinishHDMB(string systemref,string DK,int trangthai)
        {
            try
            {
                _context.Database.ExecuteSqlRawAsync("exec GetContract2SetStatus;4 @SystemId = '" + systemref + "',@status = '"+ trangthai +"',@IsDKHDMB = '"+ DK + "'");
                return Json("Hoàn thành hợp đồng mua bán thành công");
            }
            catch(Exception e)
            {
                return Json(e);
            }
            
            
        }
    }
}
