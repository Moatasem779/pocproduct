using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace PhysicalProductModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PhysicalProductModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class PhysicalProductModuleConsoleApiClientModule : AbpModule
{

}
