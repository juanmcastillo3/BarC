using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BarC.Models;
using BarC.Context;
using Microsoft.AspNetCore.Http;


namespace BarC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Homebar()
        {
           var userLogueado = HttpContext.Session.GetString("user");
            if (userLogueado == null || userLogueado == "") 
                {
                    return RedirectToAction("Login", "Usuario");
            }
    
            return View();
        }
        public IActionResult Homeadmin()
        {
            var userLogueado = HttpContext.Session.GetString("user");
            if (userLogueado == null || userLogueado == "")
            {
                return RedirectToAction("Login", "Usuario");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
