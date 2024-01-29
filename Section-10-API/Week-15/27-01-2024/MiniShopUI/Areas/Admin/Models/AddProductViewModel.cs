using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.MVC.Areas.Admin.Models
{
    public class AddProductViewModel
    {

        [JsonPropertyName("Name")]
        [DisplayName("�r�n")]
        public string Name { get; set; }


        [JsonPropertyName("Properties")]
        [DisplayName("�r�n �zellikleri")]
        public string Properties { get; set; }

        
        [JsonPropertyName("Price")]
        [DisplayName("�r�n Fiyat�")]
        public decimal Price { get; set; }

        
        [JsonPropertyName("ImageUrl")]
        [DisplayName("Resim")]
        public string ImageUrl { get; set; }


        [JsonPropertyName("Url")]
        public string Url { get; set; }

        
        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif �r�n")]
        public bool IsActive { get; set; }

        
        [JsonPropertyName("IsHome")]
        [DisplayName("Ana Sayfa �r�n�")]
        public bool IsHome { get; set; }


        [JsonPropertyName("CategoryIds")]
        public int[] CategoryIds { get; set; }


        [DisplayName("Kategoriler")]
        public List<CategoryViewModel> Categories { get; set; }
    }
}