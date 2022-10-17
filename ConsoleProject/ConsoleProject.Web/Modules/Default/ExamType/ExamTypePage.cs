
namespace ConsoleProject.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/ExamType"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ExamTypeRow))]
    public class ExamTypeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/ExamType/ExamTypeIndex.cshtml");
        }
    }
}