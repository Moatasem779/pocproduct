using Microsoft.Extensions.DependencyInjection;
using PhysicalProductModule.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace PhysicalProductModule.Blazor;

[DependsOn(
    typeof(PhysicalProductModuleApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class PhysicalProductModuleBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<PhysicalProductModuleBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<PhysicalProductModuleBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new PhysicalProductModuleMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(PhysicalProductModuleBlazorModule).Assembly);
        });
    }
}
