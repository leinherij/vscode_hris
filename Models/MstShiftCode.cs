using System;

namespace HRISVSC.Models
{
    public class MstShiftCode
    {
        public Int32 id { get; set; }
        public String shiftCode { get; set; }
        public String remarks { get; set; }
        public Int32 entryUserId { get; set; }
        public DateTime entryDateTime { get; set; }
        public Int32 updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public Boolean isLocked { get; set; }
    }
}
