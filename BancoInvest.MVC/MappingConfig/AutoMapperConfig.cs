using BancoInvest.Application.Mapping;

namespace BancoInvest.MVC.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this WebApplicationBuilder builder)
        {
            if(builder == null) throw new ArgumentNullException(nameof(builder));

            builder.Services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}
