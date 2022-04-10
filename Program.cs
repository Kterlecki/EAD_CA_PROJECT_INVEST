using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EAD_CA_PROJECT_INVEST.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<EAD_CA_PROJECT_INVESTContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EAD_CA_PROJECT_INVESTContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
