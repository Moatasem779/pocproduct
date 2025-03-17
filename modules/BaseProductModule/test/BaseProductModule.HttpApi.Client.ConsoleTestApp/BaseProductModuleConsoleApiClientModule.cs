using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace BaseProductModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BaseProductModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class BaseProductModuleConsoleApiClientModule : AbpModule
{

}
