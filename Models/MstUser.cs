using System;

namespace HRISVSC.Models
{
    public class MstUser
    {
        public Int32 id { get; set; }           
        public String userName { get; set; }
        public String password { get; set; }
        public String fullName { get; set; }
        public Int32 entryUserId { get; set; }
        public DateTime entryDateTime { get; set; }
        public Int32 updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public Boolean isLocked { get; set; }
    }
}
