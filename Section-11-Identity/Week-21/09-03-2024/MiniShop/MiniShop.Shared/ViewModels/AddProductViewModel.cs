using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MiniShop.Shared.ViewModels
{
    public class AddProductViewModel
    {
        [JsonPropertyName("Name")]
        [DisplayName("Ürün")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [MinLength(5, ErrorMessage = "{0} alan�na uzunluğu {1} karakterden k���k de�er girilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden b�y�k de�er girilemez.")]
        public string Name { get; set; }


        [JsonPropertyName("Properties")]
        [DisplayName("Ürün özellikleri")]
        public string Properties { get; set; }


        [JsonPropertyName("Price")]
        [DisplayName("Ürün Fiyatı")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public decimal? Price { get; set; }


        [JsonPropertyName("ImageUrl")]
        [DisplayName("Resim")]
        public string ImageUrl { get; set; } = "";


        [JsonPropertyName("Url")]
        public string Url { get; set; }


        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif Ürün")]
        public bool IsActive { get; set; }


        [JsonPropertyName("IsHome")]
        [DisplayName("Ana Sayfa Ürünü")]
        public bool IsHome { get; set; }


        [JsonPropertyName("CategoryIds")]
        public List<int> CategoryIds { get; set; } = new List<int>();


        [DisplayName("Kategoriler")]
        public List<CategoryViewModel> Categories { get; set; }
    }
}
