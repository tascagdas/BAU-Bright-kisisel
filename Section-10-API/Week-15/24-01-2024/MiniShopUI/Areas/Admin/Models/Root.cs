using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MiniShop.MVC.Areas.Admin.Models;

namespace MiniShopUI.Areas.Admin.Models
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