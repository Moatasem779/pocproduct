using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace PhysicalProductModule.Blazor.Menus;

public class PhysicalProductModuleMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(PhysicalProductModuleMenus.Prefix, displayName: "PhysicalProductModule", "/PhysicalProductModule", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
