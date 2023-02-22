using System;
using System.Collections.Generic;

#nullable disable

namespace GiftForMyLove.Models
{
    public partial class T05machine
    {
        public int Id { get; set; }
        public int? MachineId { get; set; }
        public string MachineName { get; set; }
        public int? CommType { get; set; }
        public int? Comport { get; set; }
        public int? BaudRate { get; set; }
        public string Ipaddress { get; set; }
        public int? Port { get; set; }
        public string DomainName { get; set; }
        public bool IsDomain { get; set; }
        public string ActiveKey { get; set; }
        public int? CommKey { get; set; }
        public DateTime? LastRecordDate { get; set; }
        public string SerialNumber { get; set; }
        public string ColorCode { get; set; }
        public DateTime? LastEventTime { get; set; }
        public string Stamp { get; set; }
        public string OpStamp { get; set; }
        public string PhotoStamp { get; set; }
        public int? ErrorDelay { get; set; }
        public int? Delay { get; set; }
        public string TransTimes { get; set; }
        public int? TransInterval { get; set; }
        public string TransFlag { get; set; }
        public int? RealTime { get; set; }
        public int? Encrypt { get; set; }
        public int? TimeZone { get; set; }
        public int? Status { get; set; }
        public int? CycleReLoad { get; set; }
        public string MaData { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}
