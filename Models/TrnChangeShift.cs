using System;

namespace HRISVSC.Models
{
    public class TrnChangeShift
    {
        public Int32 id { get; set; }
        public Int32 periodId { get; set; }
        public String csNumber { get; set; }
        public DateTime csDate { get; set; }
        public Int32 payrollGroupId { get; set; }
        // public String remarks { get; set; }
        // public Int32 preparedBy { get; set; }
        // public Int32 checkedBy { get; set; }
        // public Int32 approvedBy { get; set; }
        // public Int32 entryUserId { get; set; }
        // public DateTime entryDateTime { get; set; }
        // public Int32 updateUserId { get; set; }
        // public DateTime updateDateTime { get; set; }
        // public Boolean isLocked { get; set; }
        
    }
}
