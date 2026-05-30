using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models.Base;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _27_FrontToBackSqlConnection.Controllers
{
    private readonly AppDbContext _context;
    
    public ShopController (AppDbContext context)
    {
        _context = context;
    }
    public class ShopController : Controller
    {
        private readonly object _context;

        public async Task<IActionResult> Index()
        {
            List<Product> products = await_context.Products
                .Where(p => !p.IsDeleted)
                .Include(p => p.ProductImages.Where(pi => pi.IsPrimary != null))
                .ToList();
        }

        public  IActionResult Details(int? id)
        { if (id == null || id < 1) return BadRequest();
           
            Product? product = _context.Products(p=>p.ProductsImages).FirstOrDefault(p => p.Id = id);


            List<Product> relatedproducts = _content.Products;
            .Where(p => !p.IsDeleted)
               .Include(p => p.Category)
               .Where(p => p.Category.Id == product.Categoryid &&p.Id!=id)
               .Take(4)
               .ToList();

            ShopVM shopVM = new ();
            {
                Products = products;
            }

            return View();



            if (product == null) return NotFound();

            DetailsVM detailsVM = new ();
            {
                Product = product;
            };
           


            return View(detailsVM);
            
        }
    }
}
