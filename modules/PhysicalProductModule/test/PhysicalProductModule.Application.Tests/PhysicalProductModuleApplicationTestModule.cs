using Volo.Abp.Modularity;

namespace PhysicalProductModule;

[DependsOn(
    typeof(PhysicalProductModuleApplicationModule),
    typeof(PhysicalProductModuleDomainTestModule)
    )]
public class PhysicalProductModuleApplicationTestModule : AbpModule
{

}
