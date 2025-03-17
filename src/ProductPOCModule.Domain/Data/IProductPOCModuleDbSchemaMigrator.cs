using System.Threading.Tasks;

namespace ProductPOCModule.Data;

public interface IProductPOCModuleDbSchemaMigrator
{
    Task MigrateAsync();
}
