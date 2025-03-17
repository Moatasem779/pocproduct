using BaseProductModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BaseProductModule;

public abstract class BaseProductModuleController : AbpControllerBase
{
    protected BaseProductModuleController()
    {
        LocalizationResource = typeof(BaseProductModuleResource);
    }
}
