using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;
using MiniShop.UI.EmailServices.Abstract;
using MiniShop.UI.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<MiniShopDbContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
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
    options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromDays(10);
    // options.Lockout.AllowedForNewUsers = true;//yeniuden kayit olmaya imkan ver
    #endregion

    #region user ve signin ayarlari

    options.User.RequireUniqueEmail = true; // her email sadece 1 kez kayit olabilir.
    options.SignIn.RequireConfirmedEmail = false;

    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan=TimeSpan.FromDays(45);
    options.SlidingExpiration = true; //true ile sure her istekte sifirlanir.
    options.Cookie = new CookieBuilder
    {
        Name = "MiniShop.Security.Cookie",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict
    };
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartManager>();
builder.Services.AddScoped<IShoppingCartItemService, ShoppingCartItemManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRespository>();
builder.Services.AddScoped<IShoppingCartItemRepository, ShoppingCartItemRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();




builder.Services.AddScoped<IImageHelper, ImageHelper>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(options=>new SmtpEmailSender(
    builder.Configuration["EmailSender:Host"],
    builder.Configuration.GetValue<int>("EmailSender:Port"),
    builder.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
    builder.Configuration["EmailSender:UserName"],
    builder.Configuration["EmailSender:Password"]
    ));

builder.Services.AddNotyf(options =>
{
    options.DurationInSeconds = 5;
    options.IsDismissable = true;
    options.Position = NotyfPosition.TopRight;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
