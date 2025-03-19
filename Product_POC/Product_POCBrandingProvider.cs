using Microsoft.Extensions.Localization;
using Product_POC.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Product_POC;

[Dependency(ReplaceServices = true)]
public class Product_POCBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Product_POCResource> _localizer;

    public Product_POCBrandingProvider(IStringLocalizer<Product_POCResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
