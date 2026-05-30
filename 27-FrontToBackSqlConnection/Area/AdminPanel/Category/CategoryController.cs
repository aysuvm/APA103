using _27_FrontToBackSqlConnection.Models.Base;
using Furnish.Areas.AdminPanel.Models.Category;
using Furnish.Data;
using Furnish.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Furnish.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateVM vm)
        {
            if (!ModelState.IsValid) { return View(vm); }
            var category = new Category
            {
                Name = vm.NameVM
            };

            List<ProductTag> deleteTags = existProduct.ProductTags
    .Where(pTag => !productUpdateVM.TagIds
        .Exists(tId => tId == pTag.TagId)).ToList();

            List<int> createdTags = productUpdateVM.TagIds
    .Where(tId => !existProduct.ProductTags.Exists(pTag => pTag.TagId == tId)).ToList();


            _context.ProductTags.RemoveRange(deleteTags);

            existProduct.Name = productUpdateVM.Name;
            existProduct.Price = productUpdateVM.Price;
            existProduct.Description = productUpdateVM.Description;
            existProduct.SKU = productUpdateVM.SKU;
            existProduct.CategoryId = productUpdateVM.CategoryId.Value;

           ;
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
