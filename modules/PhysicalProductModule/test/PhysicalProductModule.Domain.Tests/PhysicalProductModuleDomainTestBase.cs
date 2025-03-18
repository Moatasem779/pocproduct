using Volo.Abp.Modularity;

namespace PhysicalProductModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class PhysicalProductModuleDomainTestBase<TStartupModule> : PhysicalProductModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
