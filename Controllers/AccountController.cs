using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;

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
