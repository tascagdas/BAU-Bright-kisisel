using Microsoft.EntityFrameworkCore;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Entity.Concrete;

namespace MiniShop.Data.Concrete.Repositories;

public class ShoppingCartRespository:GenericRepository<ShoppingCart>,IShoppingCartRepository
{
    public ShoppingCartRespository(MiniShopDbContext _context) : base(_context)
    {
        
    }

    private MiniShopDbContext MiniShopDbContext
    {
        get{return _dbContext as MiniShopDbContext;}
    }
    public async Task<ShoppingCart> GetShoppingCartByUserIdAsync(string userId)
    {
        var shoppingCart = await MiniShopDbContext.ShoppingCarts.Where(cart => cart.UserId == userId)
            .Include(cart => cart.ShoppingCartItems).ThenInclude(item => item.Product).FirstOrDefaultAsync();
        return shoppingCart;
    }

    public async Task DeleteFromShoppingCartAsync(int shoppingCartId, int productId)
    {
        // var query = @"DELETE FROM ShoppingCartItems WHERE ShoppingCartID=@p0 AND ProductId=@p1";
        // await MiniShopDbContext.Database.ExecuteSqlRawAsync(query, shoppingCartId, productId);
        var deletedShoppingCartItem = await MiniShopDbContext.ShoppingCartItems
            .Where(x => x.ShoppingCartId == shoppingCartId && x.ProductId == productId).FirstOrDefaultAsync();
        MiniShopDbContext.ShoppingCartItems.Remove(deletedShoppingCartItem);
        await MiniShopDbContext.SaveChangesAsync();
    }

    public async Task ClearShoppingCartAsync(int shoppingCartId)
    {
        // var query = @"DELETE FROM ShoppingCartItems WHERE ShoppingCartID=@p0";
        // await MiniShopDbContext.Database.ExecuteSqlRawAsync(query, shoppingCartId);
        var deletedShoppingCartItems =await MiniShopDbContext.ShoppingCartItems
            .Where(x => x.ShoppingCartId == shoppingCartId).ToListAsync();
        MiniShopDbContext.ShoppingCartItems.RemoveRange(deletedShoppingCartItems);
        await MiniShopDbContext.SaveChangesAsync();
    }
}