﻿using eshop.MVC.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Eğer herhangi bir sınıf, IProductService interface'ini implemente eden bir nesne talep ediyorsa; ProductService instance'ini kullan:
//Eğer bir arabaya lastik gerekiyorsa Bridgestone kullan.



var connectionString = builder.Configuration.GetConnectionString("db");

builder.Services.AddNecessaryInstances(connectionString);



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
{
    option.LoginPath = "/Users/Login";
    option.ReturnUrlParameter = "nereye";
    option.AccessDeniedPath = "/Users/AccessDenied";
});




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
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "categoryRoute",
    pattern: "Kategoriler/{categoryId?}",
    defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
