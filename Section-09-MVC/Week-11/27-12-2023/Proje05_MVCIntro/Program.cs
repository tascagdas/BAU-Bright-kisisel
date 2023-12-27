var builder = WebApplication.CreateBuilder(args);
/*
AddControllersWithViews metodu, bu projenin bir MVC uygulaması olmasını sağlar. Burada ControllersWithVievs servisini IOC (servis havuzu) içine koymuş oluruz. Uygulama ihtiyaç duyduğu her anda bu havuzdan bu bilgiyi edinebilir.

MVC nedir?

Model: Projemizdeki veri, veri tabanı gibi işleri yürüttüğümüz bölüm.
View: Projemizdeki arayüzü temsil eden bölüm.
Controller: Gelen tüm istekleri karşılayan yani projemizin asıl backend kodlarının yer alacağı bölüm.
*/
builder.Services.AddControllersWithViews();

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

//https://localhost:5069/Product/AddProduct

//https://localhost:5069/
//https://localhost:5069/Home
//https://localhost:5069/Home/Index

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();