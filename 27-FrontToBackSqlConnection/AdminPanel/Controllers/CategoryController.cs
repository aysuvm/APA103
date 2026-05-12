using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.AdminPanel.Controllers
{

    [Area ("AdminPanel")]
    public class CategoryController : Controller
    {

        public CategoryController(AppDbContext dbContext)
        {
            
        }
        public async Task < IActionResult> Index()
        {
            List<Category> categories = await _context.Categories
    .Where(c => !c.IsDeleted)
    .ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool existCategory = await _context.Categories
                .AnyAsync(c => c.Name.Trim() == category.Name.Trim());

            if (existCategory)
            {
                ModelState.AddModelError("Name", "Category Already exist!");
            }

            return View(category);
        }
    }
}
    

