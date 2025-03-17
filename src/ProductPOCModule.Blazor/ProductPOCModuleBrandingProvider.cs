using Microsoft.Extensions.Localization;
using ProductPOCModule.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ProductPOCModule.Blazor;

[Dependency(ReplaceServices = true)]
public class ProductPOCModuleBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ProductPOCModuleResource> _localizer;

    public ProductPOCModuleBrandingProvider(IStringLocalizer<ProductPOCModuleResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
