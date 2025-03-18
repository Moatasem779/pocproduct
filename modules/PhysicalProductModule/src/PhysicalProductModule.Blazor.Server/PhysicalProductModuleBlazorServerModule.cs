using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace PhysicalProductModule.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(PhysicalProductModuleBlazorModule)
    )]
public class PhysicalProductModuleBlazorServerModule : AbpModule
{

}
