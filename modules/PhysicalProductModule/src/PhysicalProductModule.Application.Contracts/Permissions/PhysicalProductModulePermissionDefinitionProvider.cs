using PhysicalProductModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PhysicalProductModule.Permissions;

public class PhysicalProductModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PhysicalProductModulePermissions.GroupName, L("Permission:PhysicalProductModule"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PhysicalProductModuleResource>(name);
    }
}
