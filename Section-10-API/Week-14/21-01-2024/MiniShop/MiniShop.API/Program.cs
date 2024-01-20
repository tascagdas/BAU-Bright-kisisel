using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<MiniShopDbContext>(options=>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();





builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
