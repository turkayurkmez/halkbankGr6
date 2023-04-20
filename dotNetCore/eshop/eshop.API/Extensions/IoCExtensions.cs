using eshop.Application;
using eshop.Infrastructure.Data;
using eshop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eshop.API.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddNecessaryInstances(this IServiceCollection services, string connectionString)
        {

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddDbContext<HalkEshopDbContext>(option => option.UseSqlServer(connectionString));
            return services;
        }

    }
}
