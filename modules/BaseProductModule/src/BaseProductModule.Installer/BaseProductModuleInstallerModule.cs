using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace BaseProductModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class BaseProductModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BaseProductModuleInstallerModule>();
        });
    }
}
