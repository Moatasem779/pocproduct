using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace BaseProductModule;

[DependsOn(
    typeof(BaseProductModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class BaseProductModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(BaseProductModuleApplicationContractsModule).Assembly,
            BaseProductModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BaseProductModuleHttpApiClientModule>();
        });

    }
}
