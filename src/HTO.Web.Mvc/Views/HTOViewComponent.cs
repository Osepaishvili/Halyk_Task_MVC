using Abp.AspNetCore.Mvc.ViewComponents;

namespace HTO.Web.Views
{
    public abstract class HTOViewComponent : AbpViewComponent
    {
        protected HTOViewComponent()
        {
            LocalizationSourceName = HTOConsts.LocalizationSourceName;
        }
    }
}
