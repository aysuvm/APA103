namespace _27_FrontToBackSqlConnection.Models.Base
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
