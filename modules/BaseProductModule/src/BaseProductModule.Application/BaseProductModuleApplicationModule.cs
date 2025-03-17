using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace BaseProductModule;

[DependsOn(
    typeof(BaseProductModuleDomainModule),
    typeof(BaseProductModuleApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class BaseProductModuleApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<BaseProductModuleApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<BaseProductModuleApplicationModule>(validate: true);
        });
    }
}
