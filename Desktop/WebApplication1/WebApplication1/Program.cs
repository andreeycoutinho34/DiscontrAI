var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Register}/{id?}");

app.Run();
