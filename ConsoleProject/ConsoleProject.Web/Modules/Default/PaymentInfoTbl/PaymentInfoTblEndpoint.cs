
namespace ConsoleProject.Default.Endpoints
{
    using ConsoleProject.Default.Repositories;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.PaymentInfoTblRepository;
    using MyRow = Entities.PaymentInfoTblRow;

    [RoutePrefix("Services/Default/PaymentInfoTbl"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class PaymentInfoTblController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public RetrieveResponse<StudentInfoList> StudentDetailsInfo(IDbConnection connection, PaymentRequest request)
        {
            return new MyRepository().StudentDetailsInfo(connection, request);
        }
        public ListResponse<PaymentListAll> PaymentDetailsInfo(IDbConnection connection, PaymentRequest request)
        {
            return new MyRepository().PaymentDetailsInfo(connection, request);
        }

        public RetrieveResponse<PaymentListAll> CoursePaymentDetailsInfo(IDbConnection connection, PaymentRequest request)
        {
            return new MyRepository().CoursePaymentDetailsInfo(connection, request);

        }
        public RetrieveResponse<PaymentListAll> MonthlyPaymentDetailsInfo(IDbConnection connection, PaymentRequest request)
        {
            return new MyRepository().MonthlyPaymentDetailsInfo(connection, request);
        }

    }
    }
