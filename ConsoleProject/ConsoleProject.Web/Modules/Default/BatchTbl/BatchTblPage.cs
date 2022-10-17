
namespace ConsoleProject.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/BatchTbl"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.BatchTblRow))]
    public class BatchTblController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/BatchTbl/BatchTblIndex.cshtml");
        }
    }
}