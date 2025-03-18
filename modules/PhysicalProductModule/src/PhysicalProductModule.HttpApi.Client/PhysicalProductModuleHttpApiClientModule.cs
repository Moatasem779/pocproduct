using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PhysicalProductModule;

[DependsOn(
    typeof(PhysicalProductModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class PhysicalProductModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(PhysicalProductModuleApplicationContractsModule).Assembly,
            PhysicalProductModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PhysicalProductModuleHttpApiClientModule>();
        });

    }
}
