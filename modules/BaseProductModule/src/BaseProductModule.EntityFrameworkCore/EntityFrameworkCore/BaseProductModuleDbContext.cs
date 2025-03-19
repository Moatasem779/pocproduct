using BaseProductModule.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace BaseProductModule.EntityFrameworkCore;

[ConnectionStringName(BaseProductModuleDbProperties.ConnectionStringName)]
public class BaseProductModuleDbContext : AbpDbContext<BaseProductModuleDbContext>, IBaseProductModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<BaseProduct> BaseProducts { get; set; }

    public BaseProductModuleDbContext(DbContextOptions<BaseProductModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<BaseProduct>(b =>
        {
            b.UseTpcMappingStrategy();
            b.Ignore(e => e.IsDeleted); // 👈 Ignore soft delete on base entity
        });
        builder.ConfigureBaseProductModule();
    }
}
