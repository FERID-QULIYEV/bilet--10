using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskCode10.DAL;
using TaskCode10.Models;
using TaskCode10.ViewModels;
namespace TaskCode10.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class EmployeeController: Controller
    {
        readonly AppDbContext _context;
        readonly IWebHostEnvironment _env;
        public EmployeeController(AppDbContext context , IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeVM employeeVM)
        {
            if (!ModelState.IsValid) return View();
            IFormFile file = employeeVM.Image;
            if (!file.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("image", "duzgun sekil yukleyin");
                return View();
            }
            if (!(employeeVM.Image.Length / 1024 / 1024 < 2))
            {
                ModelState.AddModelError("image", "duzgun olcude sekil yukleyin");
                return View();
            }
            string Filename=Guid.NewGuid()+file.Name;
            //Filename.Substring();
            using (Stream stream = new FileStream(Path.Combine(_env.WebRootPath, "assets", "img", "team", Filename+".jpg"), FileMode.Create))
            {
                file.CopyTo(stream);
            }
            Employee employee = new Employee()
            {
                FullName = employeeVM.FullName,
                Image = Filename,
                PozisionId = employeeVM.PozisionId,
                Facebook = employeeVM.Facebook,
                Twitter= employeeVM.Twitter,
                Instagram= employeeVM.Instagram
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            Employee employee = _context.Employees.Find(id);
            if (id == null) return NotFound();
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return View();
        }
    }
}
