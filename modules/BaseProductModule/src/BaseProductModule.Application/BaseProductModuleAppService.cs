using BaseProductModule.Localization;
using Volo.Abp.Application.Services;

namespace BaseProductModule;

public abstract class BaseProductModuleAppService : ApplicationService
{
    protected BaseProductModuleAppService()
    {
        LocalizationResource = typeof(BaseProductModuleResource);
        ObjectMapperContext = typeof(BaseProductModuleApplicationModule);
    }
}
