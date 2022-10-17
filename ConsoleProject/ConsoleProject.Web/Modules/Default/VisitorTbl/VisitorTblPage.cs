
namespace ConsoleProject.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/VisitorTbl"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.VisitorTblRow))]
    public class VisitorTblController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/VisitorTbl/VisitorTblIndex.cshtml");
        }
    }
}