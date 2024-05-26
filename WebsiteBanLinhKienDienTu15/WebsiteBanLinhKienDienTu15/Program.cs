using Microsoft.EntityFrameworkCore;
using WebsiteBanLinhKienDienTu15.Models;
using WebsiteBanLinhKienDienTu15.Repository;

var builder = WebApplication.CreateBuilder(args);


//var connectionString = builder.Configuration.GetConnectionString("WebDienTu15Context");
//builder.Services.AddDbContext<WebDienTu15Context>(x => x.UseSqlServer(connectionString));


//builder.Services.AddDbContext<WebsiteBanLinhKienDienTu15.Models.WebDienTu15Context>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
//});

var connectionString = builder.Configuration.GetConnectionString("Database")
                               ?? throw new ArgumentNullException("connectionString");

builder.Services.AddDbContext<WebDienTu15Context>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<ILoaiSpRepository, LoaiSpRepository>();



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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
