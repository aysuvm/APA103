using FrontToBack.Models;

namespace _27_FrontToBackSqlConnection.ViewModels
{
    public class ProductGetVM
    {
        public string Image { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string SKU { get; set; }

        public string CategoryName { get; set; }
    }
}