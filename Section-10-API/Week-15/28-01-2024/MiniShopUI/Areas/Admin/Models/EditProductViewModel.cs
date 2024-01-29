using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.MVC.Areas.Admin.Models
{
    public class EditProductViewModel
    {
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        [DisplayName("Ürün")]
        [Required(ErrorMessage ="{0} alaný boþ býrakýlamaz.")]
        [MinLength(5,ErrorMessage ="{0} alanýna uzunluðu {1} karakterden küçük deðer girilemez.")]
        [MaxLength(100,ErrorMessage ="{0} alanýna uzunluðu {1} karakterden büyük deðer girilemez.")]
        public string Name { get; set; }


        [JsonPropertyName("Properties")]
        [DisplayName("Ürün Özellikleri")]
        public string Properties { get; set; }

        
        [JsonPropertyName("Price")]
        [DisplayName("Ürün Fiyatý")]
        [Required(ErrorMessage = "{0} alaný boþ býrakýlamaz.")]
        public decimal? Price { get; set; }

        
        [JsonPropertyName("ImageUrl")]
        [DisplayName("Resim")]
        public string ImageUrl { get; set; }


        [JsonPropertyName("Url")]
        public string Url { get; set; }

        
        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif Ürün")]
        public bool IsActive { get; set; }

        
        [JsonPropertyName("IsHome")]
        [DisplayName("Ana Sayfa Ürünü")]
        public bool IsHome { get; set; }


        [JsonPropertyName("CategoryIds")]
        public List<int> CategoryIds { get; set; } 


        [DisplayName("Kategoriler")]
        public List<CategoryViewModel> Categories { get; set; }
    }
}