using System.Collections.Generic;
using MiProyecto.Roles.Dto;

namespace MiProyecto.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
