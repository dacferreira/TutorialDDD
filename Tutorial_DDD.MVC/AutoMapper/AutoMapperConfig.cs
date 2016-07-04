using AutoMapper;

namespace Tutorial_DDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(p =>
            {
                p.AddProfile<DomainToViewModelIMappingProfile>();
                p.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}