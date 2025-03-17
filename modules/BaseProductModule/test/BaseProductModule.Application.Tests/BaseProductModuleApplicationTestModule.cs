using Volo.Abp.Modularity;

namespace BaseProductModule;

[DependsOn(
    typeof(BaseProductModuleApplicationModule),
    typeof(BaseProductModuleDomainTestModule)
    )]
public class BaseProductModuleApplicationTestModule : AbpModule
{

}
