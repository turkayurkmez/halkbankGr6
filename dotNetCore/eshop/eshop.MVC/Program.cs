using eshop.Application;
using eshop.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Eğer herhangi bir sınıf, IProductService interface'ini implemente eden bir nesne talep ediyorsa; ProductService instance'ini kullan:
//Eğer bir arabaya lastik gerekiyorsa Bridgestone kullan.

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, FakeProductRepository>();
builder.Services.AddTransient<ICategoryRepository, FakeCategoryRepository>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddSession();

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
app.UseSession();

app.UseAuthorization();


app.MapControllerRoute(
    name: "categoryRoute",
    pattern: "Kategoriler/{categoryId?}",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
