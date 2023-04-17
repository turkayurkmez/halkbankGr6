var builder = WebApplication.CreateBuilder(args);

//Uygulamada ihtiyaç duyacağınız her instance builder.Services koleksiyonuna eklenmeli!
builder.Services.AddControllersWithViews();

var app = builder.Build();

//middleware: HttpRequest üzerinde çalışan yapılar. 
//app.UseWelcomePage();

//bazı middleware'leri doğru sırayla çağırmalısınız. İşte bu sırayla çalışma işine; Pipeline diyoruz.

/*
 * 1. Gelen Request'i denetle
 * 2. denetimden geçerse yönlendir
 * 3. geçemezse 403-404 döndür.
 */

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
//app.MapGet("/", () => "Merhaba Dünya!");

app.Run();
