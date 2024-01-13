﻿using System;
namespace MiniShop.Entity
{
	public class Category
	{
		public int Id { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime ModifiedDate { get; set; } = DateTime.Now;
		public bool IsActive { get; set; } = true;
		public bool IsDelete { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Url { get; set; }
		public List<CategoryProduct> CategoryProducts { get; set; }
	}
}

