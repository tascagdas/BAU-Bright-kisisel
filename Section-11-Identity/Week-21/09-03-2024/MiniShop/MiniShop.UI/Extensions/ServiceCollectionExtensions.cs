using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;
using MiniShop.UI.EmailServices.Abstract;
using MiniShop.UI.EmailServices.Concrete;

namespace MiniShop.UI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection LoadMyDbContextServices(this IServiceCollection services)
    {
        services.AddDbContext<MiniShopDbContext>(options =>
            options
                .UseSqlite(services
                    .BuildServiceProvider()
                    .GetRequiredService<IConfiguration>()
                    .GetConnectionString("SqliteConnection")));
        return services;
    }

    public static IServiceCollection LoadMyIdentityServices(this IServiceCollection services)
    {
        services.AddIdentity<User, Role>().AddEntityFrameworkStores<MiniShopDbContext>().AddDefaultTokenProviders();
        services.Configure<IdentityOptions>(options =>
        {
            #region Parola ayarları

            options.Password.RequiredLength = 6; //Parola 6 karakter olmalı
            options.Password.RequireDigit = true; //Parola sayısal değer içermeli
            options.Password.RequireNonAlphanumeric = true; // Parola ozel karakter icermeli
            options.Password.RequireUppercase = true; // Parola buyuk harf icermeli
            options.Password.RequireLowercase = true; // parola kucuk harf icermeli
            // options.Password.RequiredUniqueChars // Parola Tekrar etmemesi istenen karakterleri bu ozellik ile verilir.

            #endregion

            #region Hesap Kilitleme Ayarları

            options.Lockout.MaxFailedAccessAttempts = 3;
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(10);
            // options.Lockout.AllowedForNewUsers = true;//yeniuden kayit olmaya imkan ver

            #endregion

            #region user ve signin ayarlari

            options.User.RequireUniqueEmail = true; // her email sadece 1 kez kayit olabilir.
            options.SignIn.RequireConfirmedEmail = false;

            #endregion
        });

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/";
            options.AccessDeniedPath = "/Account/AccessDenied";
            options.ExpireTimeSpan = TimeSpan.FromDays(45);
            options.SlidingExpiration = true; //true ile sure her istekte sifirlanir.
            options.Cookie = new CookieBuilder
            {
                Name = "MiniShop.Security.Cookie",
                HttpOnly = true,
                SameSite = SameSiteMode.Strict
            };
        });
        return services;
    }

    public static IServiceCollection LoadMyRepositoryServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<IShoppingCartService, ShoppingCartManager>();
        services.AddScoped<IShoppingCartItemService, ShoppingCartItemManager>();
        services.AddScoped<IOrderService, OrderManager>();
        services.AddScoped<IMessageService, MessageManager>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IShoppingCartRepository, ShoppingCartRespository>();
        services.AddScoped<IShoppingCartItemRepository, ShoppingCartItemRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IMessageRepository, MessageRepository>();
        return services;
    }

    public static IServiceCollection LoadMyOtherServices(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        
        
        services.AddScoped<IImageHelper, ImageHelper>();

        
        
        services.AddScoped<IEmailSender, SmtpEmailSender>(options => new SmtpEmailSender(
            services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>()["EmailSender:Host"],
            services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>().GetValue<int>("EmailSender:Port"),
            services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>().GetValue<bool>("EmailSender:EnableSSL"),
            services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>()["EmailSender:UserName"],
            services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>()["EmailSender:Password"]
        ));

        
        
        services.AddNotyf(options =>
        {
            options.DurationInSeconds = 5;
            options.IsDismissable = true;
            options.Position = NotyfPosition.TopRight;
        });
        return services;
    }
}
