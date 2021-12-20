﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlama.Data;

namespace WebProgramlama.Controllers
{

    public class VitrinController : Controller
    {

        private readonly ApplicationDbContext _context;

        public VitrinController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Foods.ToListAsync());
        }
    }
}
