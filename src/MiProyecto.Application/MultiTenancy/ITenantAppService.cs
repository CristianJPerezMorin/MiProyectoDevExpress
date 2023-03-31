using Abp.Application.Services;
using MiProyecto.MultiTenancy.Dto;

namespace MiProyecto.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

