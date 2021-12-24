using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOdev.Data;

namespace WebOdev.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private object webHostEnvironment;
        public DefaultController(ApplicationDbContext context ,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
           
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Foods.Include("Category").ToListAsync());
        }
    }
    }
