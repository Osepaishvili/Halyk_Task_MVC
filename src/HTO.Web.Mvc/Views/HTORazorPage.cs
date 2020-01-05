using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace HTO.Web.Views
{
    public abstract class HTORazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HTORazorPage()
        {
            LocalizationSourceName = HTOConsts.LocalizationSourceName;
        }
    }
}
