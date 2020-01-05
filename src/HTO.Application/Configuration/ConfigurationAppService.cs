using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HTO.Configuration.Dto;

namespace HTO.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HTOAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
