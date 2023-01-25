using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskCode10.DAL;
using TaskCode10.Models;
using TaskCode10.ViewModels;

namespace TaskCode10.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class PozitionController:Controller
    {
        readonly AppDbContext _context;
        public PozitionController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Pozitions.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PozitionVM pozitionVM) 
        {
            Pozition pozition = new Pozition()
            {
                Name= pozitionVM.Name,
            };
            _context.Pozitions.Add(pozition);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            Pozition pozition = _context.Pozitions.Find(id);
            if (id == null) return NotFound();
            _context.Pozitions.Remove(pozition);
            _context.SaveChanges();
            return View();
        }
    }
}
