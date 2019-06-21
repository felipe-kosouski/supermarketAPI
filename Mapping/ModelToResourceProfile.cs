using System;
using AutoMapper;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;

namespace SupermarketAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}
