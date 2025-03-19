using Product_POC.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Product_POC.Permissions;

public class Product_POCPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Product_POCPermissions.GroupName);


        //Define your own permissions here. Example:
        //myGroup.AddPermission(Product_POCPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Product_POCResource>(name);
    }
}
