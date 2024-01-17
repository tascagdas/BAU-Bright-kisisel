using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;

namespace MiniShop.Business.Mappings
{
    public class GeneralMappingProfile:Profile
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();

        }
    }
}