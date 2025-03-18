using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PhysicalProductModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class PhysicalProductModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<PhysicalProductModuleInstallerModule>();
        });
    }
}
