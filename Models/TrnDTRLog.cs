using System;

namespace HRISVSC.Models
{
    public class TrnDTRLog
    {
        public Int32 id { get; set; }
        public Int32 employeeId { get; set; }
        public DateTime date { get; set; }
        public String logType { get; set; }
        public DateTime time { get; set; }
    }
}
