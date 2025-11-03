using Microsoft.EntityFrameworkCore;
using PackMarket.Core.Services;
using PackMarket.Core.Services.Interfaces;
using PackMarket.DataLayer.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("PackMarket");

builder.Services.AddDbContext<PackMarketContext>(option =>
{
    option.UseSqlServer(connectionString);
});

#region IOC
builder.Services.AddTransient<ISliderService,SliderService>();
builder.Services.AddTransient<IProductService, ProductService>();
#endregion

var app = builder.Build();



app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute("areas", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");

app.Run();
