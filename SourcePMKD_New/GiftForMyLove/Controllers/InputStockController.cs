using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using GiftForMyLove.Models;
using GiftForMyLove.Models.ClassFunction;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForMyLove.Controllers
{
    public class InputStockController : Controller
    {
        TradingsystemContext _context = new TradingsystemContext();
        public IActionResult InputStock()
        {
            ViewBag.BagType = _context.BagTypes.ToList();
            ViewBag.Stock = (from a in _context.Stocks where a.Macn == "INX" select new Stock{ StockCode = a.StockCode, StockName = a.StockName }).ToList();
            return View("InputStock");
        }
        [HttpGet]
        public object LoadInputStock(DataSourceLoadOptions options)
        {
            var item = (from a in _context.InputStocks
                        where a.Macn == "INX" && a.StatusDestroy == false && a.InputNumber != "SystemAutoCreate" && a.InputNumber != "ChangeStock"
                        select new 
                        {
                            a.InputStockId,
                            a.InputNumber,
                            a.ContractNumber,
                            a.EntDate
                        }).ToList();
            
            return DataSourceLoader.Load(item, options);
        }
        
       [HttpPost]
        public IActionResult Fill_Data_InputStock(string InputStockId)
        {
            var data = (from ins in _context.InputStocks
                        join ind in _context.InputDetails on ins.InputStockId equals ind.InputStockId
                        where ins.InputStockId == InputStockId
                        select new
                        {
                            ins.InputStockId,
                            ins.InputNumber,
                            ins.InputTypeName,
                            ins.IsProduce,
                            ins.StockCode,
                            ins.ContractNumber,
                            ins.Collate,
                            EntDate = ins.EntDate.ToString("yyyy-MM-dd"),
                            ins.PersonName,
                            ins.LenhNhap,
                            ins.XeVc,
                            ins.DvGiao,
                            ins.Note,
                            ind.Kcsid,
                            ind.ItemCode,
                            ind.ItemName,
                            ind.Unit,   
                            ind.Price,
                            ind.SoBao,
                            ind.LoaiBao,
                            TLBaoBi = ind.Gw - ind.Quantity,
                            GW = ind.Gw,
                            NW = ind.Quantity,
                        }).FirstOrDefault();
            return Json(data);
        }
        [HttpGet]
        public object LoadInputDetail(string id, DataSourceLoadOptions options)
        {
            var item = (from a in _context.InputDetails
                        where a.InputStockId == id
                        select new
                        {
                            a.ItemCode,
                            a.ItemName,
                            a.Unit,
                            a.Quantity,
                            a.SoBao,
                            a.InputDetailId,
                            a.InputStockId,
                            a.Price,
                            a.LoaiBao,
                            a.Gw,
                        }).ToList();
            return DataSourceLoader.Load(item, options);
        }
        [HttpPost]
        public IActionResult AddInputStock(string InputNumber, int InputTypeId, string InputTypeName, int IsProduce, string StockCode, string ContractNumber,
            string Collate, string EntDate, string PersonName, string LenhNhap,
            string XeVc, string DvGiao, string Note, string Kcsid,
            string ItemCode, string ItemName, string Unit, string NW,
            string SoBao, string LoaiBao, string TLBaoBi, string GW)
        {
            InputStock inputStock = new InputStock();
            inputStock.InputStockId = AutoId.AutoIdFileStored("InputStock");
            inputStock.Macn = "INX";
            inputStock.InputTypeId = InputTypeId;
            inputStock.InputTypeName = InputTypeName;
            inputStock.StockCode = StockCode;
            inputStock.Stock = _context.Stocks.Where(a => a.StockCode == StockCode).Select(a => a.StockName).FirstOrDefault();
            inputStock.ContractId = _context.Hdmbs.Where(a => a.Sohd == ContractNumber).Select(a => a.Systemref).FirstOrDefault();
            inputStock.ContractNumber = ContractNumber;
            inputStock.Collate = Collate;
            inputStock.CollateId = _context.Hdmbs.Where(a => a.Sohd == Collate).Select(a => a.Systemref).FirstOrDefault();
            inputStock.InputNumber = InputNumber;
            inputStock.EntDate = DateTime.Parse(EntDate);
            inputStock.PersonName = PersonName;
            inputStock.Note = Note; 
            inputStock.CreateBy = "TEST";
            inputStock.ContractIdSource = _context.Hdmbs.Where(a => a.Sohd == ContractNumber).Select(a => a.Systemref).FirstOrDefault();
            inputStock.IsProduce = IsProduce;
            inputStock.XeVc = XeVc;
            inputStock.LenhNhap = LenhNhap;
            inputStock.DvGiao = DvGiao;
            inputStock.CanId = "";





            return Json("Lưu nhập kho thành công");
        }
    }
}
