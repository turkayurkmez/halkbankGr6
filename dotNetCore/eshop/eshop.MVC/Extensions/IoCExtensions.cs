using eshop.Application;
using eshop.Infrastructure.Data;
using eshop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eshop.MVC.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddNecessaryInstances(this IServiceCollection services, string connectionString)
        {

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<ICategoryRepository, EFCategoryRepository>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserService, UserService>();
            services.AddDbContext<HalkEshopDbContext>(option => option.UseSqlServer(connectionString));
            return services;
        }

    }
}
