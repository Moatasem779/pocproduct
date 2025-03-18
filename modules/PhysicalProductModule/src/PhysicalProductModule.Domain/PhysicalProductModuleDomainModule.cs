using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace PhysicalProductModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(PhysicalProductModuleDomainSharedModule)
)]
public class PhysicalProductModuleDomainModule : AbpModule
{

}
