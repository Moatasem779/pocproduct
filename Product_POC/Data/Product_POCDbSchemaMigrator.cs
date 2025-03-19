using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Product_POC.Data;

public class Product_POCDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public Product_POCDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the Product_POCDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Product_POCDbContext>()
            .Database
            .MigrateAsync();

    }
}
