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

#region Route Region

app.MapControllerRoute(
    name: "products",
    pattern: "urunler/{categoryUrl?}",
    defaults: new { Controller = "Product", Action = "Index" }
);

app.MapAreaControllerRoute(
    name: "productsadmin",
    pattern: "yonetici/urunler/{isdeleted}",
    areaName: "Admin",
    defaults: new { Controller = "Product", Action = "Index" });


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