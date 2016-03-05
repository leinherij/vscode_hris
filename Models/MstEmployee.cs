using System;
namespace HRISVSC.Models
{
    public class MstEmployee
    {
        public int id { get; set; }
        public string idNumber { get; set; }
        public string biometricIdNumber { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string extensionName { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public int zipCodeId { get; set; }
        public string phoneNumber { get; set; }
        public string cellphoneNumber { get; set; }
        public string emailAddress { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string placeOfBirth { get; set; }
        public int placeOfBirthZipCodeId { get; set; }
        public DateTime dateHired { get; set; }
        //public string dateResigned { get; set; }
        public string sex { get; set; }
        public string civilStatus { get; set; }
        public int citizenshipId { get; set; }
        public int religionId { get; set; }
        public decimal height { get; set; }
        public decimal weight { get; set; }
        public string gsisNumber { get; set; }
        public string sssNumber { get; set; }
        public string hdmfNumber { get; set; }
        public string phicNumber { get; set; }
        public string tin { get; set; }
        public int taxCodeId { get; set; }
        public string atmAccountNumber { get; set; }
        public int companyId { get; set; }
        public int branchId { get; set; }
        public int departmentId { get; set; }
        public int divisionId { get; set; }
        public int positionId { get; set; }
        public int payrollGroupId { get; set; }
        public int accountId { get; set; }
        public int payrollTypeId { get; set; }
        public int shiftCodeId { get; set; }
        public int fixNumberOfDays { get; set; }
        public int fixNumberOfHours { get; set; }
        public decimal monthlyRate { get; set; }
        public decimal payrollRate { get; set; }
        public decimal dailyRate { get; set; }
        public decimal absentDailyRate { get; set; }
        public decimal hourlyRate { get; set; }
        public decimal nightHourlyRate { get; set; }
        public decimal overtimeHourlyRate { get; set; }
        public decimal overtimeNightHourlyRate { get; set; }
        public decimal tardyHourlyRate { get; set; }
        public int entryUserId { get; set; }
        public DateTime entryDateTime { get; set; }
        public int updateUserId { get; set; }
        public DateTime updateDateTime { get; set; }
        public bool isLocked { get; set; }
        public string taxTable { get; set; }
        public decimal hdmfAddOn { get; set; }
        public decimal sssAddOn { get; set; }
        public string hdmfType { get; set; }
        public bool sssIsGrossAmount { get; set; }
    }
}
