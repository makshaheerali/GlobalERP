using Abp.Authorization;
using GlobalERP.Authorization.Roles;
using GlobalERP.MultiTenancy;
using GlobalERP.Users;

namespace GlobalERP.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
