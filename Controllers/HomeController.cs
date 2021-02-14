using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Form_Submission.Models;

namespace Form_Submission.Controllers
{ 
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            Console.WriteLine(user.FirstName);
            if(ModelState.IsValid)
            {
                //send user to database
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }            
        }

        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}
