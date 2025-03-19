using Volo.Abp.Application.Services;
using Product_POC.Localization;

namespace Product_POC.Services;

/* Inherit your application services from this class. */
public abstract class Product_POCAppService : ApplicationService
{
    protected Product_POCAppService()
    {
        LocalizationResource = typeof(Product_POCResource);
    }
}