using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace BaseProductModule.Blazor.Menus;

public class BaseProductModuleMenuContributor : IMenuContributor
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
        context.Menu.AddItem(new ApplicationMenuItem(BaseProductModuleMenus.Prefix, displayName: "BaseProductModule", "/BaseProductModule", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
