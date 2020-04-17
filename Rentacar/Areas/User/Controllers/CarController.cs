using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Rentacar.Areas.User.Controllers
{
    [Area("User")]
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }
}