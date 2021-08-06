using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Series.Mvc.Data;

namespace Series.Mvc.Controllers
{
    public class SeriesController : Controller
    {
        private readonly ApplicationDbContext context;
        
        public SeriesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET
        public async Task<IActionResult> Index()
        {
            return View(await context.Series.ToListAsync());
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }
    }
}