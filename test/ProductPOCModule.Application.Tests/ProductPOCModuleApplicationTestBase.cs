using Volo.Abp.Modularity;

namespace ProductPOCModule;

public abstract class ProductPOCModuleApplicationTestBase<TStartupModule> : ProductPOCModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
