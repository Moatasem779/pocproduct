using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace PhysicalProductModule;

[DependsOn(
    typeof(PhysicalProductModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class PhysicalProductModuleApplicationContractsModule : AbpModule
{

}
