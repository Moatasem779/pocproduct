using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Product_POC.Data;

public class Product_POCDbContextFactory : IDesignTimeDbContextFactory<Product_POCDbContext>
{
    public Product_POCDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Product_POCDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Product_POCDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}