using System;

namespace HRISVSC.Models
{
    public class MstEmployee
    {
        public Int32 id { get; set; }
        public String idNumber { get; set; }
        public String biometricIdNumber { get; set; }
        public String lastName { get; set; }
        public String firstName { get; set; }
        public String middleName { get; set; }
        public string extensionName { get; set; }
        public String fullName { get; set; }
        public String address { get; set; }
        public Int32 zipCodeId { get; set; }
        public String phoneNumber { get; set; }
        public String cellphoneNumber { get; set; }
        public String emailAddress { get; set; }
        public DateTime dateOfBirth { get; set; }
        public String placeOfBirth { get; set; }
        public Int32 placeOfBirthZipCodeId { get; set; }
        public DateTime dateHired { get; set; }
       // public DateTime dateResigned { get; set; }
        public String sex { get; set; }
        public String civilStatus { get; set; }
        public Int32 citizenshipId { get; set; }
        public Int32 religionId { get; set; }
        public Decimal height { get; set; }
        public Decimal weight { get; set; }
        public String gsisNumber { get; set; }
        public String sssNumber { get; set; }
        public String hdmfNumber { get; set; }
        public String phicNumber { get; set; }
        public String tin { get; set; }
        public Int32 taxCodeId { get; set; }
        public String atmAccountNumber { get; set; }
        public Int32 companyId { get; set; }
        public Int32 branchId { get; set; }
        public Int32 departmentId { get; set; }
        public Int32 divisionId { get; set; }
        public Int32 positionId { get; set; }
        public Int32 payrollGroupId { get; set; }
        public Int32 accountId { get; set; }
        public Int32 payrollTypeId { get; set; }
        public Int32 shiftCodeId { get; set; }
        public Int32 fixNumberOfDays { get; set; }
        public Int32 fixNumberOfHours { get; set; }
        public Decimal monthlyRate { get; set; }
        public Decimal payrollRate { get; set; }
        public Decimal dailyRate { get; set; }
        public Decimal absentDailyRate { get; set; }
        public Decimal hourlyRate { get; set; }
        public Decimal nightHourlyRate { get; set; }
        public Decimal overtimeHourlyRate { get; set; }
        public Decimal overtimeNightHourlyRate { get; set; }
        public Decimal tardyHourlyRate { get; set; }
        public Int32 entryUserId { get; set; }
        public DateTime entryDateTime { get; set; }
        public Int32 updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public Boolean isLocked { get; set; }
        public String taxTable { get; set; }
        public Decimal hdmfAddOn { get; set; }
        public Decimal sssAddOn { get; set; }
        public String hdmfType { get; set; }
        public Boolean sssIsGrossAmount { get; set; }
    }
    
}
