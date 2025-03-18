using Volo.Abp.Reflection;

namespace PhysicalProductModule.Permissions;

public class PhysicalProductModulePermissions
{
    public const string GroupName = "PhysicalProductModule";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(PhysicalProductModulePermissions));
    }
}
