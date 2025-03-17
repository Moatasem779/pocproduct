using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BaseProductModule.EntityFrameworkCore;

[ConnectionStringName(BaseProductModuleDbProperties.ConnectionStringName)]
public interface IBaseProductModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
