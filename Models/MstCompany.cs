using System;

namespace HRISVSC.Models
{
    public class MstCompany
    {
        public Int32 id { get; set; }
        public String company { get; set; }
        public String address { get; set; }
        public String sssNumber { get; set; }
        public String phicNumber { get; set; }
        public String hdmfNumber { get; set; }
        public String tin { get; set; }
        public Int32 entryUserId { get; set; }
        public DateTime entrydatetime { get; set; }
        public Int32 updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public Boolean isLocked { get; set; }

    }
}
