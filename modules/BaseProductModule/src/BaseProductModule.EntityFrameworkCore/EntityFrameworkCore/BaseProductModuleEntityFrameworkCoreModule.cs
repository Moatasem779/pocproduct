using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BaseProductModule.EntityFrameworkCore;

[DependsOn(
    typeof(BaseProductModuleDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class BaseProductModuleEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<BaseProductModuleDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
