using System.Threading.Tasks;
using Abp.Application.Services;
using HTO.Authorization.Accounts.Dto;

namespace HTO.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
