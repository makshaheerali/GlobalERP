using Abp.Web.Mvc.Views;

namespace GlobalERP.Web.Views
{
    public abstract class GlobalERPWebViewPageBase : GlobalERPWebViewPageBase<dynamic>
    {

    }

    public abstract class GlobalERPWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected GlobalERPWebViewPageBase()
        {
            LocalizationSourceName = GlobalERPConsts.LocalizationSourceName;
        }
    }
}