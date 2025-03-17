using Localization.Resources.AbpUi;
using BaseProductModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace BaseProductModule;

[DependsOn(
    typeof(BaseProductModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class BaseProductModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(BaseProductModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<BaseProductModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
