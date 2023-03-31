using System.Collections.Generic;
using MiProyecto.Roles.Dto;

namespace MiProyecto.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
