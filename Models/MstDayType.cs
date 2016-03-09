using System;

namespace HRISVSC.Models
{
    public class MstDayType
    {
        public Int32 id { get; set; }
        public String dayType { get; set; }
        public Decimal workingDays { get; set; }
        public Decimal restdayDays { get; set; }
        public Int32 entryUserId { get; set; }
        public DateTime entryDateTime { get; set; }
        public Int32 updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public Boolean isLocked { get; set; }

    }
}
