using Volo.Abp.Reflection;

namespace BaseProductModule.Permissions;

public class BaseProductModulePermissions
{
    public const string GroupName = "BaseProductModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BaseProductModulePermissions));
    }
}
