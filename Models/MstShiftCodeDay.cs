using System;

namespace HRISVSC.Models
{
    public class MstShiftCodeDay
    {
        public Int32 id { get; set; }
        public Int32 shiftCodeId { get; set; }
        public Boolean restDay { get; set; }
        public String day { get; set; }
        public DateTime timeIn1 { get; set; }  
        public DateTime timeOut1 { get; set; }
        public DateTime timeIn2 { get; set; }  
        public DateTime timeOut2 { get; set; }
        public Decimal numberOfHours { get; set; }
        public Decimal lateFlexibility { get; set; }
        public Decimal lateGraceMinute { get; set; }
        public Decimal nightHours { get; set; }
    }
}
