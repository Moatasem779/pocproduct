using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace BaseProductModule.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(BaseProductModuleBlazorModule)
    )]
public class BaseProductModuleBlazorServerModule : AbpModule
{

}
