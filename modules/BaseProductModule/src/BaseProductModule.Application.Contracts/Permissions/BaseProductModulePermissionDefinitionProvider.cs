using BaseProductModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BaseProductModule.Permissions;

public class BaseProductModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BaseProductModulePermissions.GroupName, L("Permission:BaseProductModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BaseProductModuleResource>(name);
    }
}
