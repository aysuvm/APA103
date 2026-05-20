using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using FrontToBack.Areas.AdminPanel.ViewModels.Product;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Areas.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p => p.ProductImages)
                .Include(p => p.Category)
                .ToListAsync();

            List <ProductsGetVM> productsGetVMs = new();

            List<ProductGetVM> model = new();

            foreach (var product in products)
            {
                ProductGetVM productGetVM = new()
                {
                    Name = product.Name,
                    Price = product.Price,
                    CategoryName = product.Category.Name,
                    SKU = product.SKU,
                    Image = product.ProductImages.FirstOrDefault()?.Image
                };

                if (productCreateVM.TagIds != null)
                {
                    product.ProductTags = productCreateVM.TagIds
                        .Select(tId => new ProductTag
                        {
                            TagId = tId
                        })
                        .ToList();
                }

                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));


            }

            return View(products);
        }

        public async Task<IActionResult> Create()
        {
            ProductCreateVM productCreateVM = new()
            {
                Product  = await _context.Product.Where(c => !c.IsDeleted).ToListAsync()
            };

            return View(productCreateVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateVM productCreateVM)
        {
            productCreateVM.Product = await _context.Product
                .Where(c => !c.IsDeleted)
                .ToListAsync();

            if (!ModelState.IsValid)
                return View(productCreateVM);

            bool existCategory = productCreateVM.Product
                .Any(c => c.Id == productCreateVM.CategoryId);

            if (!existCategory)
            {
                ModelState.AddModelError(nameof(ProductCreateVM.CategoryId),
                    "Category does not exist!");

                return View(productCreateVM);
            }

            return View(productCreateVM);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1) return BadRequest();

            Product? existProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (existProduct == null) return NotFound();

            if (!ModelState.IsValid) return View();

            ProductUpdateVM productUpdateVM = new()
            {
                Name = existProduct.Name,
                Price = existProduct.Price,
                Description = existProduct.Description,
                SKU = existProduct.SKU,
                CategoryId = existProduct.CategoryId,
            };

            return View(productUpdateVM);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int? id, ProductUpdateVM productUpdateVM)
        {
            if (id == null || id < 1) return BadRequest();

            productUpdateVM.Categories = await _context.Categories
                .Where(c => !c.IsDeleted)
                .ToListAsync();

            if (!ModelState.IsValid) return View(productUpdateVM);

            Product? existProduct = await _context.Products
                .FirstOrDefaultAsync(p => p.Id == id);

            if (existProduct == null) return NotFound();

            bool existCategory = productUpdateVM.Categories
                .Any(c => c.Id == productUpdateVM.CategoryId);

            if (!existCategory)
            {

                return View(productUpdateVM);
            }
        }

        bool existCategory = productCreateVM.Categories.Any(c => c.Id == productCreateVM.CategoryId);
if (!existCategory)
{
    ModelState.AddModelError(nameof(ProductCreateVM.CategoryId), "Category does not exist!");
    return View(productCreateVM);
    }

if (productCreateVM.TagIds is not null)
{
    bool existTag = productCreateVM.TagIds.Any(tagId => !productCreateVM.Tags.Exists(t => t.Id == tagId));
    if (existTag)
    {
        ModelState.AddModelError(nameof(ProductCreateVM.TagIds), "Tag does not exist!");
        return View(productCreateVM);
}
}
    }
}
