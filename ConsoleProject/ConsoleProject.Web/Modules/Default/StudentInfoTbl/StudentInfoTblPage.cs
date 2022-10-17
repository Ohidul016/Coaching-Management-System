
namespace ConsoleProject.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/StudentInfoTbl"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.StudentInfoTblRow))]
    public class StudentInfoTblController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/StudentInfoTbl/StudentInfoTblIndex.cshtml");
        }
    }
}