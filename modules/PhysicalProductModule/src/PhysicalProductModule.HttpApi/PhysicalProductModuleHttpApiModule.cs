using Localization.Resources.AbpUi;
using PhysicalProductModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace PhysicalProductModule;

[DependsOn(
    typeof(PhysicalProductModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class PhysicalProductModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(PhysicalProductModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<PhysicalProductModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
