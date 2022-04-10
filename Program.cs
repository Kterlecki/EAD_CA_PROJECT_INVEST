using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EAD_CA_PROJECT_INVEST.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EAD_CA_PROJECT_INVESTContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EAD_CA_PROJECT_INVESTContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
