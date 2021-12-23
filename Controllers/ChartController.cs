using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOdev.Data;
using WebOdev.Models;

namespace WebOdev.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ChartController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChartController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VisualizeProductResult()
        {
            return Json(FoodList());
        }
        public List<FoodChart> FoodList()
        {
            List<FoodChart> cs = new List<FoodChart>();
            cs = _context.Foods.Select(f => new FoodChart
            {
                foodname = f.Name,
                stock = f.Stock

            }).ToList();


            return cs;

        }
        public IActionResult Statistics()
        {
            var cs = _context.Foods.Count();
            ViewBag.d1 = cs;

            var cs2 = _context.Categories.Count();
            ViewBag.d2 = cs2;



            var foid = _context.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            ViewBag.d4 = foid;


            var cs3 = _context.Foods.Where(x => x.CategoryID == foid).Count();
            ViewBag.d3 = cs3;
            var cs4 = _context.Foods.Where(x => x.CategoryID == 2).Count();
            ViewBag.d5 = cs4;

            var cs5 = _context.Foods.Sum(x => x.Stock);
            ViewBag.d6 = cs5;




            return View();
        }
    }
}
