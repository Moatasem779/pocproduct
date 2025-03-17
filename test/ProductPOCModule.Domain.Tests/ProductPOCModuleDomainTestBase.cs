using Volo.Abp.Modularity;

namespace ProductPOCModule;

/* Inherit from this class for your domain layer tests. */
public abstract class ProductPOCModuleDomainTestBase<TStartupModule> : ProductPOCModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
