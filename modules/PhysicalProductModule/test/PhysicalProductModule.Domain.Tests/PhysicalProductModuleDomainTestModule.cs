using Volo.Abp.Modularity;

namespace PhysicalProductModule;

[DependsOn(
    typeof(PhysicalProductModuleDomainModule),
    typeof(PhysicalProductModuleTestBaseModule)
)]
public class PhysicalProductModuleDomainTestModule : AbpModule
{

}
