using Volo.Abp.Modularity;

namespace PhysicalProductModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class PhysicalProductModuleApplicationTestBase<TStartupModule> : PhysicalProductModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
