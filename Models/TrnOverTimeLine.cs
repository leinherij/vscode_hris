using System;

namespace HRISVSC.Models
{
    public class TrnOverTimeLine
    {
        public Int32 id { get; set; }
        public Int32 overtimeId { get; set; }
        public Int32 employeeId { get; set; }
        public DateTime date { get; set; }
        public Decimal overtimeHours { get; set; }
        public Decimal overtimeNightHours { get; set; }
        public Decimal overtimeLimitHours { get; set; }
        public String  remarks { get; set; }
    }
}
