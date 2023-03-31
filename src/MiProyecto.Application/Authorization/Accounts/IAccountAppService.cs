using System.Threading.Tasks;
using Abp.Application.Services;
using MiProyecto.Authorization.Accounts.Dto;

namespace MiProyecto.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
