using BaseProductModule.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace BaseProductModule.EntityFrameworkCore;

public static class BaseProductModuleDbContextModelCreatingExtensions
{
    public static void ConfigureBaseProductModule(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(BaseProductModuleDbProperties.DbTablePrefix + "Questions", BaseProductModuleDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<BaseProduct>(b =>
        {
            b.ToTable(BaseProductModuleDbProperties.DbTablePrefix + "BaseProducts");
            b.ConfigureByConvention(); //auto configure for the base class props
        });
    }
}
