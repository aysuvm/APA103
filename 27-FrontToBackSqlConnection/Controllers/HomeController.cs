using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.Services;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO.Pipes;

namespace _27_FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext  _context;
       

        public HomeController(AppDbContext context)
        {
            _context = context;
            
        }








        List<Slider> sliders = new List<Slider>();
        {
        Title = "Basliq-1", Subtitle = "Komekci basliq-1", Description = "Gullerden qalmadi", Image = "1-1-524x617.png";
Title = "Basliq-1", Subtitle = "Komekci basliq-1", Description = "Gullerden qalmadi", Image = "1-2-524x617.png";
Title = "Basliq-1", Subtitle = "Komekci basliq-1", Description = "Gullerden qalmadi", Image = "1-1-524x617.png";
        }
       

        public IActionResult Index()
        {


            Product product = _context.Products.Include(p=>p.Category).FirstOrDefault();

            Category category = _context.Categories
                .FirstOrDefault(c => c.Id == product.CategoryId);

            List<Slider> sliders = _context.Sliders
                .OrderBy(s => s.Order)
                .Where(s => !s.isDeleted)
                .Take(2)
                .ToList();


            List<Product> products = _context.Products
    .Where(p => !p.IsDeleted)
    .Include(p => p.ProductImages.Where (pi=>pi.isPrimary !=null))
    .ToList();




            HomeVM homeVM = new ();

            Sliders = sliders,
                Products = products

        };

        return View(homeVM);


    }
}
