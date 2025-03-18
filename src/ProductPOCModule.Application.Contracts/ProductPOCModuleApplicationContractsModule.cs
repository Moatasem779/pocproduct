using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.TenantManagement;
using BaseProductModule;
using PhysicalProductModule;

namespace ProductPOCModule;

[DependsOn(
    typeof(ProductPOCModuleDomainSharedModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpAccountApplicationContractsModule),
    typeof(AbpTenantManagementApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule)
)]
[DependsOn(typeof(BaseProductModuleApplicationContractsModule))]
    [DependsOn(typeof(PhysicalProductModuleApplicationContractsModule))]
    public class ProductPOCModuleApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        ProductPOCModuleDtoExtensions.Configure();
    }
}
