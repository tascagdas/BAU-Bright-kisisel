using MiniShop.Entity.Abstract;

namespace MiniShop.Entity.Concrete
{
    public class ShoppingCart : IMainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UserId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new List<ShoppingCartItem>();
    }
}
