using System;

namespace HRISVSC.Models
{
    public class TrnDTRLine
    {
        public Int32 id { get; set; }
        public Int32 dtrId { get; set; }
        public Int32 employeeId { get; set; }
        public Int32 shiftCodeId { get; set; }
        public DateTime date { get; set; }
        public DateTime timeIn1 { get; set; }
        public DateTime timeOut1 { get; set; }
        public DateTime timeIn2 { get; set; }
        public DateTime timeOut2 { get; set; }
        public Boolean officialBusiness { get; set; }
        public Boolean onLeave { get; set; }
        public Boolean absent { get; set; }
        public Boolean halfdayAbsent { get; set; }
        public Decimal regularHours { get; set; }
        public Decimal nightHours { get; set; }
        public Decimal overtimeHours { get; set; }
        public Decimal overtimeNightHours { get; set; }
        public Decimal grossTotalHours { get; set; }
        public Decimal tardyLateHours { get; set; }
        public Decimal tardyUndertimeHours { get; set; }
        public Decimal netTotalHours { get; set; }
        public Int32 dayTypeId { get; set; }
        public Boolean restDay { get; set; }
        public Decimal dayMultiplier { get; set; }
        public Decimal ratePerHour { get; set; }
        public Decimal ratePerNightHour { get; set; }
        public Decimal ratePerOvertimeHour { get; set; }
        public Decimal ratePerOvertimeNightHour { get; set; }
        public Decimal regularAmount { get; set; }
        public Decimal nightAmount { get; set; }
        public Decimal overtimeAmount { get; set; }
        public Decimal overtimeNightAmount { get; set; }
        public Decimal totalAmount { get; set; }
        public Decimal ratePerHourTardy { get; set; }
        public Decimal ratePerAbsentDay { get; set; }
        public Decimal tardyAmount { get; set; }
        public Decimal absentAmount { get; set; }
        public Decimal netAmount { get; set; }
    }
}
