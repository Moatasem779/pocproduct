using ProductPOCModule.Localization;
using Volo.Abp.Application.Services;

namespace ProductPOCModule;

/* Inherit your application services from this class.
 */
public abstract class ProductPOCModuleAppService : ApplicationService
{
    protected ProductPOCModuleAppService()
    {
        LocalizationResource = typeof(ProductPOCModuleResource);
    }
}
