using System;
using AutoMapper;
using DotNetWebAPI.Dtos;
using DotNetWebAPI.Models;

namespace DotNetWebAPI.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryReadDto>();
        }

    }
}
