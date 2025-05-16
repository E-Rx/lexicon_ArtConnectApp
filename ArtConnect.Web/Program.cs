namespace ArtConnect.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Images
            app.UseStaticFiles();


            app.MapControllers();
            app.Run();
        }
    }
}
