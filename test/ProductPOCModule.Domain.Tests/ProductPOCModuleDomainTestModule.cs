using Volo.Abp.Modularity;

namespace ProductPOCModule;

[DependsOn(
    typeof(ProductPOCModuleDomainModule),
    typeof(ProductPOCModuleTestBaseModule)
)]
public class ProductPOCModuleDomainTestModule : AbpModule
{

}
