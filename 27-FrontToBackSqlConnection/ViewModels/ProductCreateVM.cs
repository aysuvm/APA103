namespace FrontToBack.Areas.AdminPanel.ViewModels.Product
{
    public class ProductCreateVM
    {
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? SKU { get; set; }

        public string? CategoryId { get; set; }
    }
}