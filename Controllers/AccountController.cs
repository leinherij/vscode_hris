using Microsoft.AspNet.Mvc;

namespace HRISVSC.Controllers
{
    public class AccountController : Controller
    {
        
        public IActionResult Login()
        {        
            return View();
        }
        
        public IActionResult Register()
        {
            return View();
        } 
         
    }
}
