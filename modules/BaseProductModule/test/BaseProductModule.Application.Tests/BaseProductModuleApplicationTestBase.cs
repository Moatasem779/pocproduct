using Volo.Abp.Modularity;

namespace BaseProductModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class BaseProductModuleApplicationTestBase<TStartupModule> : BaseProductModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
