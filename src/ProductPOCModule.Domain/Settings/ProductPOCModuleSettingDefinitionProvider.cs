using Volo.Abp.Settings;

namespace ProductPOCModule.Settings;

public class ProductPOCModuleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductPOCModuleSettings.MySetting1));
    }
}
