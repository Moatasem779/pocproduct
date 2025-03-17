namespace BaseProductModule;

public static class BaseProductModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "BaseProductModule";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "BaseProductModule";
}
