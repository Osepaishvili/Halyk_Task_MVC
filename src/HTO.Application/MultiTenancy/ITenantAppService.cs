using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HTO.MultiTenancy.Dto;

namespace HTO.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

