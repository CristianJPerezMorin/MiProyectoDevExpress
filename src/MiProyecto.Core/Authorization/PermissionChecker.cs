using Abp.Authorization;
using MiProyecto.Authorization.Roles;
using MiProyecto.Authorization.Users;

namespace MiProyecto.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
