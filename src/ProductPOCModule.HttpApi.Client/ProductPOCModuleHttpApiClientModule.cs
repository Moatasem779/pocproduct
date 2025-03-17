using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.VirtualFileSystem;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;
using BaseProductModule;

namespace ProductPOCModule;

[DependsOn(
    typeof(ProductPOCModuleApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiClientModule),
    typeof(AbpFeatureManagementHttpApiClientModule),
    typeof(AbpAccountHttpApiClientModule),
    typeof(AbpIdentityHttpApiClientModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
[DependsOn(typeof(BaseProductModuleHttpApiClientModule))]
    public class ProductPOCModuleHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ProductPOCModuleApplicationContractsModule).Assembly,
            RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProductPOCModuleHttpApiClientModule>();
        });
    }
}
