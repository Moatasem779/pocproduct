using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProductPOCModule.Data;

/* This is used if database provider does't define
 * IProductPOCModuleDbSchemaMigrator implementation.
 */
public class NullProductPOCModuleDbSchemaMigrator : IProductPOCModuleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
