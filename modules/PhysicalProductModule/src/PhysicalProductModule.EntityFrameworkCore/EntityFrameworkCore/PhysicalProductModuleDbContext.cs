using BaseProductModule.Entities;
using Microsoft.EntityFrameworkCore;
using PhysicalProductModule.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace PhysicalProductModule.EntityFrameworkCore;

[ConnectionStringName(PhysicalProductModuleDbProperties.ConnectionStringName)]
public class PhysicalProductModuleDbContext : AbpDbContext<PhysicalProductModuleDbContext>, IPhysicalProductModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<PhysicalProduct> PhysicalProducts { get; set; }
    public PhysicalProductModuleDbContext(DbContextOptions<PhysicalProductModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<PhysicalProduct>(b =>
        {
            b.UseTpcMappingStrategy();
            b.HasQueryFilter(e => !EF.Property<bool>(e, "IsDeleted")); 
        }); builder.ConfigurePhysicalProductModule();
    }
}
