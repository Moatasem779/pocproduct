using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PhysicalProductModule.EntityFrameworkCore;

[ConnectionStringName(PhysicalProductModuleDbProperties.ConnectionStringName)]
public interface IPhysicalProductModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
