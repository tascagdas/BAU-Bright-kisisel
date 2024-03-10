using MiniShop.Entity.Abstract;

namespace MiniShop.Entity.Concrete
{
    public class Product : BaseEntity, IMainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string Properties { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHome { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }//Navigation Property
    }
}
