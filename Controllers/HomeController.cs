using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelBinding_In_MVC_Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding_In_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string SubmitForm(IFormCollection form)
        {
            var UserName = form["username"].ToString();
            var UserEmail = form["useremail"].ToString();
           
            return $"Username:{UserName} User Email :{UserEmail}";

        }
        public ActionResult Index1()
        {
            return View();
        }

        [HttpPost]
        public string Submitform1(User user)
        {
            if(user!=null)
            {
                  if (ModelState.IsValid){

                    return   $"Username:{user.UserName} User Email :{user.UserEmail}"; }

            }

            return "Some error Occured";



        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
