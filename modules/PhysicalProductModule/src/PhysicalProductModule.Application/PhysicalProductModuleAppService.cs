using PhysicalProductModule.Localization;
using Volo.Abp.Application.Services;

namespace PhysicalProductModule;

public abstract class PhysicalProductModuleAppService : ApplicationService
{
    protected PhysicalProductModuleAppService()
    {
        LocalizationResource = typeof(PhysicalProductModuleResource);
        ObjectMapperContext = typeof(PhysicalProductModuleApplicationModule);
    }
}
