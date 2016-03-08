using System;

namespace HRISVSC.Models
{
    public class MstUserForm
    {
        public Int32 id { get; set; }           
        public Int32 userId { get; set; }           
        public Int32 formId { get; set; }           
        public Boolean canAdd { get; set; }
        public Boolean canEdit { get; set; }
        public Boolean canDelete { get; set; }
        public Boolean canLock { get; set; }
        public Boolean canUnlock { get; set; }
        public Boolean canPreview { get; set; }
        public Boolean canPrint { get; set; }
        public Boolean canView { get; set; }
    }
}
