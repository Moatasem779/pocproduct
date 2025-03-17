using ProductPOCModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace ProductPOCModule.Permissions;

public class ProductPOCModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProductPOCModulePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProductPOCModulePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProductPOCModuleResource>(name);
    }
}
