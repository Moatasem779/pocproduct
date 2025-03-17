using Volo.Abp.Modularity;

namespace BaseProductModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class BaseProductModuleDomainTestBase<TStartupModule> : BaseProductModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
