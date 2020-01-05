using System.Threading.Tasks;
using HTO.Configuration.Dto;

namespace HTO.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
