using System.Threading.Tasks;
using MiProyecto.Configuration.Dto;

namespace MiProyecto.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
