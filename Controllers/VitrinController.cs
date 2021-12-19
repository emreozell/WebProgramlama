using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlama.Controllers
{
    public class VitrinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
