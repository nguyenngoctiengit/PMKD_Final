using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using GiftForMyLove.Models;
using GiftForMyLove.Models.ClassFunction;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForMyLove.Controllers
{
    public class KhachHangController : Controller
    {
        private static string CustomerId = "";

        public TradingsystemContext _context = new TradingsystemContext();
        public IActionResult KhachHang()
        {
            return View("KhachHang");
        }
        [HttpGet]
        public object LoadKhachHang(DataSourceLoadOptions loadOptions)
        {
            var item = _context.KhachHangs.ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object LoadCustomerNorm(string MaKhach, DataSourceLoadOptions loadOptions)
        {
            CustomerId = MaKhach;
            var item = _context.CustomerNorms.Where(a => a.Makhach == MaKhach).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpGet]
        public object LoadSigner(string MaKhach, DataSourceLoadOptions loadOptions)
        {
            var item = _context.Signers.Where(a => a.Visible != false && a.MaKhach == MaKhach).ToList();
            return DataSourceLoader.Load(item, loadOptions);
        }
        [HttpPost]
        public IActionResult InsertKhachHang(string values)
        {
            var Khachhang = new KhachHang();
            JsonConvert.PopulateObject(values, Khachhang);

            Khachhang.Idkhach = AutoId.AutoIdFileStored("khachhang");

            Khachhang.Visible = true;

            Khachhang.CreatedBy = "TEST";

            Khachhang.CreatedDate = DateTime.Now;

            Khachhang.MaHd = Khachhang.MaKhach;

            if (!TryValidateModel(Khachhang))
                return BadRequest("Something went wrong!!");

            if (_context.KhachHangs.Any(a => a.MaKhach == Khachhang.MaKhach))
                return BadRequest("Mã khách bị trùng");


            _context.KhachHangs.Add(Khachhang);
            _context.SaveChanges();
            return Ok(Khachhang);
        }

        [HttpPut]
        public IActionResult UpdateKhachHang(string key, string values)
        {
            var Khachhang = _context.KhachHangs.First(a => a.Idkhach == key);

            JsonConvert.PopulateObject(values, Khachhang);

            if (!TryValidateModel(Khachhang))
                return BadRequest("Something went wrong");

            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteKhachHang(string key)
        {
            var Khachhang = _context.KhachHangs.First(a => a.Idkhach == key);

            Khachhang.Visible = false;

            if (!TryValidateModel(Khachhang))
                return BadRequest("Something went wrong");

            _context.SaveChanges();

            return Ok();
        }
        [HttpPost]
        public IActionResult InsertCustomerNorm(string values)
        {
            var CustomerNorm = new CustomerNorm();
            JsonConvert.PopulateObject(values, CustomerNorm);

            if (!TryValidateModel(CustomerNorm))
                return BadRequest("Something went wrong!!");

            CustomerNorm.Makhach = CustomerId;
            CustomerNorm.ValueDmgh = CustomerNorm.ValueNorm;
            CustomerNorm.GdMua = true;
            CustomerNorm.GdBan = true;
            CustomerNorm.UserCreate = "TEST";
            CustomerNorm.DateCreate = DateTime.Now;

            _context.CustomerNorms.Add(CustomerNorm);
            _context.SaveChanges();

            return Ok(CustomerNorm);
        }

        [HttpPut]
        public IActionResult UpdateCustomerNorm(string key, string values)
        {
            dynamic data = JObject.Parse(key);
            string Makhach = data.Makhach;
            string Nhomhang = data.Nhomhang;
            string Macn = data.Macn;
            var CustomerNorm = _context.CustomerNorms.Where(a => a.Makhach == Convert.ToString(Makhach) && a.Nhomhang == Convert.ToString(Nhomhang) && a.Macn == Convert.ToString(Macn)).FirstOrDefault();

            JsonConvert.PopulateObject(values, CustomerNorm);

            if (!TryValidateModel(CustomerNorm))
                return BadRequest("Something went wrong");

            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public void DeleteCustomerNorm(string key)
        {
            dynamic data = JObject.Parse(key);
            string Makhach = data.Makhach;
            string Nhomhang = data.Nhomhang;
            string Macn = data.Macn;
            var CustomerNorm = _context.CustomerNorms.Where(a => a.Makhach == Convert.ToString(Makhach) && a.Nhomhang == Convert.ToString(Nhomhang) && a.Macn == Convert.ToString(Macn)).FirstOrDefault();
            _context.CustomerNorms.Remove(CustomerNorm);
            _context.SaveChanges();
        }
        private int GetSTT(string CustomerId)
        {
            var STT = 0;
            if (_context.Signers.Where(a => a.MaKhach == CustomerId).FirstOrDefault() == null)
            {
                STT = 0;
            }
            else
            {
                STT = _context.Signers.Where(a => a.MaKhach == CustomerId).Max(a => a.Stt) + 1;
            }
            return STT;
        }
        [HttpPost]
        public IActionResult InsertSigner(string values)
        {

            var Signer = new Signer();
            JsonConvert.PopulateObject(values, Signer);

            if (!TryValidateModel(Signer))
                return BadRequest("Something went wrong!!");

            Signer.Stt = GetSTT(CustomerId);
            Signer.MaKhach = CustomerId;
            Signer.Visible = true;

            _context.Signers.Add(Signer);
            _context.SaveChanges();

            return Ok(Signer);
        }
        [HttpPut]
        public IActionResult UpdateSigner(long key, string values)
        {
            var Signer = _context.Signers.Where(a => a.Id == key).FirstOrDefault();

            JsonConvert.PopulateObject(values, Signer);

            if (!TryValidateModel(Signer))
                return BadRequest("Something went wrong");

            _context.SaveChanges();

            return Ok();
        }
        [HttpDelete]
        public void DeleteSigner(long key)
        {
            var Signer = _context.Signers.Where(a => a.Id == key).FirstOrDefault();
            _context.Signers.Remove(Signer);
            _context.SaveChanges();
        }
    }
}
