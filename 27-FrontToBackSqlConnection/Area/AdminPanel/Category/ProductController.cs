using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using FrontToBack.Areas.AdminPanel.ViewModels.Product;
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
    }
}
