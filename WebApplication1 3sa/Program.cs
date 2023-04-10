
using WebApplication1_3sa_.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews() .AddRazorRuntimeCompilation();
builder.Services.AddDbContext<DatabaseContext>(Opts ›
    {
    object Opts = null;
    Opts.UseSqlServer("Server=localhost;Database=WebApplication1_3sa_DB;Trusted_Connection=true")

} );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
