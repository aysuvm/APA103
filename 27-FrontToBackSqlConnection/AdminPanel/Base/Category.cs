using _27_FrontToBackSqlConnection.Base;
using _27_FrontToBackSqlConnection.Models;

namespace FrontToBack.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
