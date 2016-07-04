using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutorial_DDD.Domain.Entities;
using Tutorial_DDD.MVC.ViewModels;

namespace Tutorial_DDD.MVC.AutoMapper
{
    public class DomainToViewModelIMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        protected override void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}