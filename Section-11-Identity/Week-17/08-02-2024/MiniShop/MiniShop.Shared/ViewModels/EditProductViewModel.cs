using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class EditProductViewModel
    {
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        [DisplayName("�r�n")]
        [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz.")]
        [MinLength(5, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden k���k de�er girilemez.")]
        [MaxLength(100, ErrorMessage = "{0} alan�na uzunlu�u {1} karakterden b�y�k de�er girilemez.")]
        public string Name { get; set; }


        [JsonPropertyName("Properties")]
        [DisplayName("�r�n �zellikleri")]
        public string Properties { get; set; }


        [JsonPropertyName("Price")]
        [DisplayName("�r�n Fiyat�")]
        [Required(ErrorMessage = "{0} alan� bo� b�rak�lamaz.")]
        public decimal? Price { get; set; }


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
        public List<int> CategoryIds { get; set; }


        [DisplayName("Kategoriler")]
        public List<CategoryViewModel> Categories { get; set; }

    }
}
