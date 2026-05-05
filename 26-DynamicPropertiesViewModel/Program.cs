namespace Dynamic_Data_ViewModels
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
    "Corporative",
    "corporative-satislar",
    new{controller="home",action="corporativesales"}
);

            app.Run();

            app.MapControllerRoute(
                "default",
                "{controller=home}/{action= index}/{id?}"
            );

            app.Run();
        }
    }
}
