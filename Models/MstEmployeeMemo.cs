using System;

namespace HRISVSC.Models
{
    public class MstEmployeeMemo
    {
        public Int32 id { get; set; }
        public Int32 employeeId { get; set; }
        public DateTime memoDate { get; set; }
        public String memoSubject { get; set; }
        public String memoContent { get; set; }
        public Int32 preparedBy { get; set; }
        public Int32 approvedby { get; set; }

    }
}
