using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductPOCModule.Data;
using Volo.Abp.DependencyInjection;

namespace ProductPOCModule.EntityFrameworkCore;

public class EntityFrameworkCoreProductPOCModuleDbSchemaMigrator
    : IProductPOCModuleDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProductPOCModuleDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ProductPOCModuleDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProductPOCModuleDbContext>()
            .Database
            .MigrateAsync();
    }
}
