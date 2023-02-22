using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GiftForMyLove.Models.ClassFunction
{
    public class AutoId
    {
        public static string AutoIdFileStored(string tableName)
        {
            TradingsystemContext _context = new TradingsystemContext();
            var PrefixOfDefaultValueForId = _context.AutomaticValues.Where(a => a.ObjectName == tableName).Select(a => a.PrefixOfDefaultValueForId).FirstOrDefault();
            var LengthOfDefaultValueForId = _context.AutomaticValues.Where(a => a.ObjectName == tableName).Select(a => a.LengthOfDefaultValueForId).FirstOrDefault();
            var LastValueOfColumnId = _context.AutomaticValues.Where(a => a.ObjectName == tableName).Select(a => a.LastValueOfColumnId).FirstOrDefault();
            var oldValue = LastValueOfColumnId.Substring(PrefixOfDefaultValueForId.Count());
            var chuoi = "000000000000000000" + (int.Parse(oldValue) + 1);
            var aaaa = chuoi.Count();
            var aaaaa = chuoi.Count() + PrefixOfDefaultValueForId.Count() - (int)LengthOfDefaultValueForId;
            var ParameterOut = PrefixOfDefaultValueForId + chuoi.Substring(chuoi.Count() + PrefixOfDefaultValueForId.Count() - (int)LengthOfDefaultValueForId);
            var AutomaticValues = _context.AutomaticValues.Where(a => a.ObjectName == tableName).FirstOrDefault();
            AutomaticValues.LastValueOfColumnId = ParameterOut;
            _context.AutomaticValues.Update(AutomaticValues);
            _context.SaveChanges();
            return ParameterOut;
        }
    }
}
