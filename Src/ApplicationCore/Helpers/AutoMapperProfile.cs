using ApplicationCore.Dtos;
using ApplicationCore.Entities.MembershipAggregate;
using ApplicationCore.Entities.UserAggregate;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Account, LoginDto>();
            CreateMap<LoginDto, Account>();

            CreateMap<Account, RegisterDto>();
            CreateMap<RegisterDto, Account>();

            CreateMap<Category, MembershipCategoryDto>();
            CreateMap<MembershipCategoryDto, Category>();
        }
    }
}
