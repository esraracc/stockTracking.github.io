using AutoMapper;
using EntityLayer;
using StockTrackingApp.Models;
using StockTrackingApp.Models.AccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackingApp.AutoMappers
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<User, UserDetailsModel>().ReverseMap();
        }

    }
}
