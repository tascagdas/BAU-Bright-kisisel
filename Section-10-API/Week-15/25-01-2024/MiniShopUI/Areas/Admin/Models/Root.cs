using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json.Serialization;

namespace MiniShop.MVC.Areas.Admin.Models
{
    public class Root
    {
        [JsonPropertyName("Data")]
        public List<ProductViewModel> Data { get; set; }

        [JsonPropertyName("Errors")]
        public object Errors { get; set; }

        [JsonPropertyName("StatusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("IsSucceeded")]
        public bool IsSucceeded { get; set; }
    }
}
