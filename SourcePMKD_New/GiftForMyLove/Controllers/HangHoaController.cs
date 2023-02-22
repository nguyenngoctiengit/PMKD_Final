using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftForMyLove.Models;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using GiftForMyLove.Models.ClassFunction;
using Newtonsoft.Json.Linq;

namespace GiftForMyLove.Controllers
{
    public class HangHoaController : Controller
    {
        public TradingsystemContext _context = new TradingsystemContext(); 
        public IActionResult HangHoa()
        {
            return View("HangHoa");
        }
        [HttpGet]
        public object LoadHangHoa(DataSourceLoadOptions loadOptions)
        {
            var item = _context.Hanghoas.Where(a => a.Visible != false).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public IActionResult InsertHangHoa(string values)
        {
            var Hanghoa = new Hanghoa();
            JsonConvert.PopulateObject(values, Hanghoa);
            Hanghoa.Idhanghoa = AutoId.AutoIdFileStored("Hanghoa");
            Hanghoa.Visible = true;
            Hanghoa.Sudung = 1;
            Hanghoa.OrderNhom = Convert.ToInt16(_context.NhomHangHoas.Where(a => a.TenNhom == Hanghoa.MaNhom).Select(a => a.Order_Nhom).FirstOrDefault());
            if (_context.Hanghoas.Any(a => a.Mahang == Hanghoa.Mahang))
                return BadRequest("Trùng mã hàng");
            if (!TryValidateModel(Hanghoa))
                return BadRequest("Something went wrong!!");
            _context.Hanghoas.Add(Hanghoa);
            _context.SaveChanges();
            return Ok(Hanghoa);
        }

        [HttpPut]
        public IActionResult UpdateHangHoa(string key, string values)
        {
            var Hanghoa = _context.Hanghoas.First(a => a.Idhanghoa == key);

            dynamic data = JObject.Parse(values);

            JsonConvert.PopulateObject(values, Hanghoa);

            if (!TryValidateModel(Hanghoa))
                return BadRequest("Something went wrong");

            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public void DeleteHangHoa(string key)
        {
            var Hanghoa = _context.Hanghoas.First(a => a.Idhanghoa == key);
            _context.Hanghoas.Remove(Hanghoa);
            _context.SaveChanges();
        }
    }
}
