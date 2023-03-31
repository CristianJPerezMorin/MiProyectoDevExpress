using System.Collections.Generic;
using MiProyecto.Roles.Dto;

namespace MiProyecto.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}