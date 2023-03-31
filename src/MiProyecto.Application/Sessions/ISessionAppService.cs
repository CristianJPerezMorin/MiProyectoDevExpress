using System.Threading.Tasks;
using Abp.Application.Services;
using MiProyecto.Sessions.Dto;

namespace MiProyecto.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
