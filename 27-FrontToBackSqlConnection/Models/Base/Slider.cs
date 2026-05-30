namespace _27_FrontToBackSqlConnection.Models.Base
{
    public class Slider
    {

       

        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
