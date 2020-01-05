using Abp.Authorization;
using HTO.Authorization.Roles;
using HTO.Authorization.Users;

namespace HTO.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
