using System.Threading.Tasks;
using AbpIoAzureDevops.Localization;
using Volo.Abp.UI.Navigation;

namespace AbpIoAzureDevops.Blazor
{
    public class AbpIoAzureDevopsMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<AbpIoAzureDevopsResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "AbpIoAzureDevops.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
