
using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{
    public class SoftwareController : Controller
    {
        public IActionResult MainMenu()
        {
            return View();
        }
        ///////////////////
        //Setup under Menu
        ///////////////////
        
        public IActionResult Employee()
        {
            
            return View();
        }
        public IActionResult ShiftCode()
        {
            
            return View();
        }
        public IActionResult Company()
        {
            
            return View();
        }
        public IActionResult DayType()
        {
            
            return View();
        }
        public IActionResult MandatoryTaxTables()
        {
            
            return View();
        }
        public IActionResult OtherIncome()
        {
            
            return View();
        }
        public IActionResult SystemTables()
        {
            
            return View();
        }
        public IActionResult OtherDeduction()
        {
            
            return View();
        }
        public IActionResult Users()
        {
            
            return View();
        }
        public IActionResult ChangeShiftCode()
        {
            
            return View();
        }
        public IActionResult Settings()
        {
            
            return View();
        }
        ///////////////////////////
        // Activities Under Main Menu
        ///////////////////////
        public IActionResult DTR()
        {
            
            return View();
        }
        public IActionResult PayrollOtherIncome()
        {
            
            return View();
        }
        public IActionResult PayrollOtherDeduction()
        {
            
            return View();
        }
        public IActionResult LeaveApplication()
        {
            
            return View();
        }
        public IActionResult LastWithholdingTax()
        {
            
            return View();
        }
        public IActionResult OvertimeApplication()
        {
            
            return View();
        }
        public IActionResult Loans()
        {
            
            return View();
        }
        public IActionResult Payroll()
        {
            
            return View();
        }
        
        ////////////////////////////////////////////////////////////////
        //Reports Under Main Menu
        //////////////////////////////////////////////////////////////////////
        
        public IActionResult DTRReports()
        {
            
            return View();
        }
        public IActionResult LeaveReports()
        {
            
            return View();
        }
        public IActionResult PayrollReports()
        {
            
            return View();
        }
        public IActionResult LoanReports()
        {
            
            return View();
        }
        public IActionResult MandatoryReports()
        {
            
            return View();
        }
        public IActionResult AccountingReports()
        {
            
            return View();
        }
        public IActionResult WithholdingTaxReports()
        {
            
            return View();
        }
        public IActionResult ATMBank()
        {
            
            return View();
        }
        public IActionResult Demographics()
        {
            
            return View();
        }
    }
}
