namespace _27_FrontToBackSqlConnection.Models.Base
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

            public List<ProductTag> ProductTags { get; set; }
    }
}
