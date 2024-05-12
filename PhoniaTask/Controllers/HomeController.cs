using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoniaTask.DAL;
using PhoniaTask.ViewModels.Categories;

namespace PhoniaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhoniaContext _context;

        public HomeController(PhoniaContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            var data = await _context.Categories
                .Select(c => new GetCategoryVM
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
            return View(data);
        }
    }
}
