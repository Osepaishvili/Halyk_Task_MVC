using System.Collections.Generic;
using HTO.Roles.Dto;

namespace HTO.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}