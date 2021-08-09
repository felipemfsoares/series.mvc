using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Series.Mvc.Data;
using Series.Mvc.Models;

namespace Series.Mvc.Controllers
{
    [Authorize]
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
            return View("Create",new Serie());
        }
        
        [HttpPost]
        public async Task<IActionResult> Store(Serie serie)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", serie);
            }
            await context.Series.AddAsync(serie);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var serie = await context.Series.FirstAsync(s => s.Id == id);
            if (serie == null)
            {
                return RedirectToAction("Index");
            }
            return View(serie);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Destroy(int id)
        {
            var serie = await context.Series.FindAsync(id);
            if (serie == null)
            {
                return RedirectToAction("Index");
            }
            context.Series.Remove(serie);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(Serie serie)
        {
            context.Entry(serie).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}