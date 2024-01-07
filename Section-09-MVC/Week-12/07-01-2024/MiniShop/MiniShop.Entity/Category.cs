using System;
namespace MiniShop.Entity
{
	public class Category
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
		public bool IsActive { get; set; }
		public bool IsDelete { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
	}
}

