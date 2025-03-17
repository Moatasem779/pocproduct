using Volo.Abp.Modularity;

namespace ProductPOCModule;

[DependsOn(
    typeof(ProductPOCModuleApplicationModule),
    typeof(ProductPOCModuleDomainTestModule)
)]
public class ProductPOCModuleApplicationTestModule : AbpModule
{

}
