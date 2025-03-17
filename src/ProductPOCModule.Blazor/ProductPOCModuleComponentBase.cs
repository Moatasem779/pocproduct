using ProductPOCModule.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ProductPOCModule.Blazor;

public abstract class ProductPOCModuleComponentBase : AbpComponentBase
{
    protected ProductPOCModuleComponentBase()
    {
        LocalizationResource = typeof(ProductPOCModuleResource);
    }
}
