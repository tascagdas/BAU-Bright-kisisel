﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels
{
    public class AddCategoryViewModel
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }

        [JsonPropertyName("ImageUrl")]
        public string ImageUrl { get; set; } = "";

        [JsonPropertyName("IsActive")]
        public bool IsActive { get; set; }

        [JsonPropertyName("IsDeleted")]
        public bool IsDeleted { get; set; }

        [JsonPropertyName("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [JsonPropertyName("ModifiedDate")]
        public DateTime ModifiedDate { get; set; }
    }
}