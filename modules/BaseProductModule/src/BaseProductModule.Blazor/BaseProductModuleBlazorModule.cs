using Microsoft.Extensions.DependencyInjection;
using BaseProductModule.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace BaseProductModule.Blazor;

[DependsOn(
    typeof(BaseProductModuleApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class BaseProductModuleBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<BaseProductModuleBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<BaseProductModuleBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new BaseProductModuleMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(BaseProductModuleBlazorModule).Assembly);
        });
    }
}
