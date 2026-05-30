namespace _27_FrontToBackSqlConnection.Models.Base
{
    public class ProductImage
    {
         public string Image {  get; set; }
        public bool? isPrimary { get; set; }
        public int ? ProductId { get; set; }
        public Product product { get; set; }
    }

