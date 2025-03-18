using PhysicalProductModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PhysicalProductModule;

public abstract class PhysicalProductModuleController : AbpControllerBase
{
    protected PhysicalProductModuleController()
    {
        LocalizationResource = typeof(PhysicalProductModuleResource);
    }
}
