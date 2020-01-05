using System.Threading.Tasks;
using Abp.Application.Services;
using HTO.Sessions.Dto;

namespace HTO.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
