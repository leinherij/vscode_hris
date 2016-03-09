using System;

namespace HRISVSC.Models
{
    public class MstDayTypeDay
    {
        public Int32 id { get; set; }
        public Int32 dayTypeId { get; set; }
        public Int32 branchId { get; set; }
        public DateTime date { get; set; }
        public DateTime dateAfter { get; set; }
        public DateTime dateBefore { get; set; }
        public Boolean excludedInFixed { get; set; }
        public String remarks { get; set; }

    }
}
