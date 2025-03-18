using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace PhysicalProductModule.EntityFrameworkCore;

[DependsOn(
    typeof(PhysicalProductModuleDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class PhysicalProductModuleEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<PhysicalProductModuleDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
