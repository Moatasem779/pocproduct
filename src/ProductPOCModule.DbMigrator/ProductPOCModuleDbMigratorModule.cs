using ProductPOCModule.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProductPOCModule.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProductPOCModuleEntityFrameworkCoreModule),
    typeof(ProductPOCModuleApplicationContractsModule)
)]
public class ProductPOCModuleDbMigratorModule : AbpModule
{
}
