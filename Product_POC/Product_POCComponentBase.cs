using Product_POC.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Product_POC;

public abstract class Product_POCComponentBase : AbpComponentBase
{
    protected Product_POCComponentBase()
    {
        LocalizationResource = typeof(Product_POCResource);
    }
}
