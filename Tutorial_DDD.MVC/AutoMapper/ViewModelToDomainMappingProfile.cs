using System;
using AutoMapper;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.MVC.ViewModels;

namespace Tutorial_DDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }
        protected override void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}