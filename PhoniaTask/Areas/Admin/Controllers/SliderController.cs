using Microsoft.AspNetCore.Mvc;
using PhoniaTask.DAL;
using PhoniaTask.Models;
using PhoniaTask.ViewModels.Sliders;

namespace PhoniaTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateSliderVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            Slider slider = new Slider
            {
                Discount = vm.Discount,
                CreateTime = DateTime.Now,
                ImageUrl = vm.ImageUrl,
                IsDeleted = false,
                Subtitle = vm.Subtitle,
                Title = vm.Title
            };
            //await _context.Sliders.AddAsync(slider);
            //await _context.SaveChangeAsync();
            return View();
        }
    }
}
