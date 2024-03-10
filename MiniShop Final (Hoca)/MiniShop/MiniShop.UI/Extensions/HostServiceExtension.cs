using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Concrete.Contexts;

namespace MiniShop.UI.Extensions
{
    public static class HostServiceExtension
    {
        public static IHost UpdateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var miniShopDbContext = scope.ServiceProvider.GetRequiredService<MiniShopDbContext>())
                {
                    try
                    {
                        var pendingMigrationCount = miniShopDbContext.Database.GetPendingMigrations().Count();
                        if (pendingMigrationCount > 0)
                            miniShopDbContext.Database.Migrate();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
