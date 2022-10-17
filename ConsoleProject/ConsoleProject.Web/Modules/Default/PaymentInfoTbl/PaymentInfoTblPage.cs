
namespace ConsoleProject.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/PaymentInfoTbl"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PaymentInfoTblRow))]
    public class PaymentInfoTblController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/PaymentInfoTbl/PaymentInfoTblIndex.cshtml");
        }
    }
}