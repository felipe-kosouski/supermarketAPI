using System;
using AutoMapper;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;

namespace SupermarketAPI.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
