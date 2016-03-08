using System;

namespace HRISVSC.Models
{
    public class TrnChangeShiftLine
    {
        public Int32 id { get; set; }
        public Int32 changeShiftId { get; set; }
        public Int32 employeeId { get; set; }
        public DateTime date { get; set; }
        public Int32 shiftCodeId { get; set; }
        public String remarks { get; set; }
    }
}
