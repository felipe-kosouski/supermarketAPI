using System;
using AutoMapper;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;
using SupermarketAPI.Extensions;


namespace SupermarketAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToStringDescriptions()));
        }
    }
}
