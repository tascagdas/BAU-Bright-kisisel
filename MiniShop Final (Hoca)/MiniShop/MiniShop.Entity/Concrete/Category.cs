using MiniShop.Entity.Abstract;

namespace MiniShop.Entity.Concrete
{
    public class Category : BaseEntity, IMainEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }//Navigation Property
    }
}
