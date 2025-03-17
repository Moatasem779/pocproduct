using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace BaseProductModule;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(BaseProductModuleDomainSharedModule)
)]
public class BaseProductModuleDomainModule : AbpModule
{

}
