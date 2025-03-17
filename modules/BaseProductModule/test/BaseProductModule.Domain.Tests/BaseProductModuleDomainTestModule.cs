using Volo.Abp.Modularity;

namespace BaseProductModule;

[DependsOn(
    typeof(BaseProductModuleDomainModule),
    typeof(BaseProductModuleTestBaseModule)
)]
public class BaseProductModuleDomainTestModule : AbpModule
{

}
