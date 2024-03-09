namespace MiniShop.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }//Navigation Property
        public int CategoryId { get; set; }
        public Category Category { get; set; }//Navigation Property
    }
}
