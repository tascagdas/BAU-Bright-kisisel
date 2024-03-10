using MiniShop.UI.Extensions;

var builder = WebApplication.CreateBuilder(args);

#region ServicesRegion
builder.Services.AddControllersWithViews();
builder.Services.LoadMyDbContextServices();
builder.Services.LoadMyIdentityServices();
builder.Services.LoadMyRepositoryServices();
builder.Services.LoadMyOtherServices();
#endregion

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

#region RouteRegion
app.MapControllerRoute(
    name: "products",
    pattern: "urunler/{categoryUrl?}",
    defaults: new { controller = "Product", action = "Index" }
    );

app.MapAreaControllerRoute(
    name: "productsadmin",
    pattern: "yonetici/urunler/{isdeleted}",
    areaName: "Admin",
    defaults: new { controller = "Product", action = "Index" }
    );

// https://localhost:59079/yonetici/urunler/false þeklinde görünen url yapýmýzý
// https://localhost:59079/yonetici/urunler/silinenurunler þeklinde gözükecek çalýþmayý yapýnýz.

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion

app.UpdateDatabase().Run();
