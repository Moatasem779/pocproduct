using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProductPOCModule.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProductPOCModuleDbContextFactory : IDesignTimeDbContextFactory<ProductPOCModuleDbContext>
{
    public ProductPOCModuleDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        ProductPOCModuleEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<ProductPOCModuleDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new ProductPOCModuleDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProductPOCModule.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
