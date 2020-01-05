using System.Collections.Generic;
using HTO.Roles.Dto;
using HTO.Users.Dto;

namespace HTO.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
