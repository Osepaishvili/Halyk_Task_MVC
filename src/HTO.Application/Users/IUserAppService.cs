using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HTO.Roles.Dto;
using HTO.Users.Dto;

namespace HTO.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
