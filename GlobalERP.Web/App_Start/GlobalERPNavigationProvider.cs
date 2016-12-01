using Abp.Application.Navigation;
using Abp.Localization;
using GlobalERP.Authorization;

namespace GlobalERP.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class GlobalERPNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
               .AddItem(
                    new MenuItemDefinition(
                        "Tenants",
                        L("Tenants"),
                        url: "#tenants",
                        icon: "fa fa-globe",
                        requiredPermissionName: PermissionNames.Pages_Tenants
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Users",
                        L("Users"),
                        url: "#users",
                        icon: "fa fa-users",
                        requiredPermissionName: PermissionNames.Pages_Users
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Vehicle",
                        L("Vehicle"),
                        icon: "fa fa-car"
                        ).AddItem(new MenuItemDefinition(
                             "Register",
                             L("Register"),
                               url: "vehicle/create",
                             icon: "fa fa-car",
                             requiresAuthentication: true
                            )
                        ).AddItem(new MenuItemDefinition(
                             "Index",
                             L("Index"),
                               url: "vehicle/index",
                             icon: "fa fa-car",
                             requiresAuthentication: true
                         ))).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", GlobalERPConsts.LocalizationSourceName),
                 
                        icon: "fa fa-info"
                        ).AddItem(new MenuItemDefinition(
                             "Create",
                             L("Create"),
                               url: "/",
                             icon: "fa fa-road" 
                            ))
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, GlobalERPConsts.LocalizationSourceName);
        }
    }
}
