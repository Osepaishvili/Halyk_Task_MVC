using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HTO.Controllers
{
    public abstract class HTOControllerBase: AbpController
    {
        protected HTOControllerBase()
        {
            LocalizationSourceName = HTOConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
