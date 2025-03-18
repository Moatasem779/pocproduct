using Localization.Resources.AbpUi;
using ProductPOCModule.Localization;
using Volo.Abp.Account;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
using Volo.Abp.TenantManagement;
using BaseProductModule;
using PhysicalProductModule;

namespace ProductPOCModule;

 [DependsOn(
    typeof(ProductPOCModuleApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule)
    )]
[DependsOn(typeof(BaseProductModuleHttpApiModule))]
    [DependsOn(typeof(PhysicalProductModuleHttpApiModule))]
    public class ProductPOCModuleHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ProductPOCModuleResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
