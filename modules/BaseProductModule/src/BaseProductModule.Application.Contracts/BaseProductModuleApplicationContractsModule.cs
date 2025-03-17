using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace BaseProductModule;

[DependsOn(
    typeof(BaseProductModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class BaseProductModuleApplicationContractsModule : AbpModule
{

}
