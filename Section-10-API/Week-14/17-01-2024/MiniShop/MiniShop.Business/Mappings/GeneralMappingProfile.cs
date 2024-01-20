using AutoMapper;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
