using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace PhysicalProductModule;

[DependsOn(
    typeof(PhysicalProductModuleDomainModule),
    typeof(PhysicalProductModuleApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class PhysicalProductModuleApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<PhysicalProductModuleApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<PhysicalProductModuleApplicationModule>(validate: true);
        });
    }
}
