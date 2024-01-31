using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.DTOs
{
    public class AddProductDTO
    {
        public string Name { get; set; }
        public string Properties { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
        public int[] CategoryIds { get; set; }
    }
}
