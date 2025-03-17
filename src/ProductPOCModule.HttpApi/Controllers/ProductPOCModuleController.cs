using ProductPOCModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductPOCModule.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProductPOCModuleController : AbpControllerBase
{
    protected ProductPOCModuleController()
    {
        LocalizationResource = typeof(ProductPOCModuleResource);
    }
}
