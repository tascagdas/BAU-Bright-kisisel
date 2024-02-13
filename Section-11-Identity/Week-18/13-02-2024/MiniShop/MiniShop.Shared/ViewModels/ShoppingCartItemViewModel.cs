namespace MiniShop.Shared.ViewModels;

public class ShoppingCartItemViewModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductImageUrl { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int Quantity { get; set; }
}