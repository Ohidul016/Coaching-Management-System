
namespace ConsoleProject.Default.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Linq;
    using MyRow = Entities.PaymentInfoTblRow;

    public class PaymentInfoTblRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> { }

        public RetrieveResponse<StudentInfoList> StudentDetailsInfo(IDbConnection connection, PaymentRequest request)
        {
            var list = new RetrieveResponse<StudentInfoList>();
            var sql = string.Empty;
            sql = $@"select Student_Id ,
                      Name ,
                      Gender	,
                      College_Name    ,
                      College_batch   ,
                      Father_Name     ,
                      Mother_Name     ,
                      Address	   ,
                      Description    ,
                      Batch_Id     ,
                      Mother_Phone,
                      Father_Phone   ,
                      Personal_Phone  ,
                      User_Image	   ,
                      AdmissionDate ,
                      AdmissionType  ,
                      Course_TotalFee,
                      Course_Duration,
                      Monthly_Fee    ,
                      IsActive   from StudentInfo_tbl where Student_Id={request.StudentId} ";
            list.Entity = connection.Query<StudentInfoList>(sql,commandType:CommandType.Text).FirstOrDefault();
            return list;
        }

        public ListResponse<PaymentListAll> PaymentDetailsInfo(IDbConnection connection, PaymentRequest request) 
        {
            var list = new ListResponse<PaymentListAll>();
            var sql = string.Empty;
            sql = $@"select Payment_Id,Student_Id,Payment_Date,Amount  from PaymentInfo_tbl where Student_Id={request.StudentId} ";
            list.Entities = connection.Query<PaymentListAll>(sql, commandType: CommandType.Text).ToList();
            return list;
        }          
        public RetrieveResponse<PaymentListAll> CoursePaymentDetailsInfo(IDbConnection connection, PaymentRequest request) 
        {
            var list = new RetrieveResponse<PaymentListAll>();
            list.Entity = new PaymentListAll();
            var sql = string.Empty;
            sql = $@"select Payment_Id,Student_Id,Payment_Date,Amount  from PaymentInfo_tbl where Student_Id={request.StudentId} order by Payment_Date desc ";
            var Search= connection.Query<PaymentListAll>(sql, commandType: CommandType.Text).ToList();
            decimal sum = 0;
           foreach(var item in Search)
            {
                sum +=Convert.ToDecimal(item.Amount);
            }
            list.Entity.Amount = sum;
            list.Entity.Payment_Date = Search.FirstOrDefault().Payment_Date;
            return list;
        }
        public RetrieveResponse<PaymentListAll> MonthlyPaymentDetailsInfo(IDbConnection connection, PaymentRequest request)
        {
            var list = new RetrieveResponse<PaymentListAll>();
            list.Entity= new PaymentListAll();
            var sql = string.Empty;
            sql = $@"select Payment_Id,Student_Id,Payment_Date,Amount  from PaymentInfo_tbl where Student_Id={request.StudentId} order by Payment_Date desc ";
            var Search = connection.Query<PaymentListAll>(sql, commandType: CommandType.Text).ToList();
            list.Entity.Amount = Search.FirstOrDefault().Amount;
            list.Entity.Payment_Date = Search.FirstOrDefault().Payment_Date;
            return list;
        }

    }
    
    public class PayDataList
    {
        public Int32? Payment_Id { get; set; }
        public Int32? Student_Id { get; set; }
        public DateTime? Payment_Date { get; set; }
        public decimal? Amount { get; set; }
    }
    public class StudentInfoList
    {
        public Int32? Student_Id { get; set; }
        public string Name { get; set; }
        public Boolean? Gender { get; set; }
        public string College_Name { get; set; }
        public string College_batch { get; set; }
        public string Father_Name { get; set; } 
        public string Mother_Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public Int32? Batch_Id { get; set; }
        public string Mother_Phone { get; set; }
        public string Father_Phone { get; set; } 
        public string Personal_Phone { get; set; }
        public string User_Image { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public Int32? AdmissionType { get; set;}
        public decimal? Course_TotalFee { get; set; }
        public double? Course_Duration { get; set; }
        public decimal? Monthly_Fee { get; set; }
        public Int32? IsActive { get; set; }
    }

    public class PaymentListAll 
    {
      public Int32? Payment_Id { get; set; }
        public Int32? Student_Id { get; set; }
        public DateTime? Payment_Date { get; set; }
       public decimal? Amount { get; set; }
    }
    public class PaymentRequest : ListRequest
    {
        public Int32? StudentId { get; set; }
    }
}