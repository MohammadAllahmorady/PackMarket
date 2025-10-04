using Microsoft.EntityFrameworkCore;
using PackMarket.DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("PackMarket");

builder.Services.AddDbContext<PackMarketContext>(option =>
{
    option.UseSqlServer(connectionString);
});

var app = builder.Build();



app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
