using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace GlobalERP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GlobalERPControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}