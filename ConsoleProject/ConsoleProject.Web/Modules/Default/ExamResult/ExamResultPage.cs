
namespace ConsoleProject.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/ExamResult"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ExamResultRow))]
    public class ExamResultController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/ExamResult/ExamResultIndex.cshtml");
        }
    }
}