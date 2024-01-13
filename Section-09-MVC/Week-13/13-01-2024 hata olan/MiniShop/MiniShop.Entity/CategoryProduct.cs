using System;
namespace MiniShop.Entity
{
	public class CategoryProduct
	{

		public int CategoryId { get; set; }
		//Navigation Property
		public Category Category { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }


	}
}

