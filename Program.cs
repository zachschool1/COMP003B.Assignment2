/*Zachary Jordan
 * COMP003B ASP.NET Core
 * Faculty name: Jonathan Cruz
 * The purpose of this application is going to be something simple, maybe it talks about a fake product or something. I haven't decided yet I just want to make sure I get the set up correct
 */


namespace COMP003B.Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
          
            app.UseStaticFiles();

            app.UseMiddleware<COMP003B.Assignment2.Middleware.RequestLoggingMiddleware>();
            app.UseWelcomePage("/welcome");

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
