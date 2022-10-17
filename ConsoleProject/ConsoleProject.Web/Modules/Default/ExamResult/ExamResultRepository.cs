
namespace ConsoleProject.Default.Repositories
{
    using ConsoleProject.Default.Entities;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.ExamResultRow;

    public class ExamResultRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            this.AddData(uow,request);
            return new SaveResponse();
            //return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            this.AddData(uow, request);
            return new SaveResponse();
           // return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
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

        private void AddData(IUnitOfWork pUow, SaveRequest<MyRow> request)
        {
            var uow = pUow as UnitOfWork;
            var user = (UserDefinition)Authorization.UserDefinition;
            var Username = user.Username;
            if(request.Entity.BatchId == null)
            {
                throw new ValidationError("Please Enter Batch No");
            }             
            else if(request.Entity.ExamType == null)
            {
                throw new ValidationError("Please Enter Exam Type");
            }       
            else if(request.Entity.ExamMark == null)
            {
                throw new ValidationError("Please Enter Exam Type");
            }
            foreach(var item in request.Entity.ExamMark)
            {
                ExamResultRow rowFld = new ExamResultRow();
                rowFld.ExamDate = request.Entity.ExamDate;
                rowFld.BatchId = request.Entity.BatchId;
                rowFld.ExamType = request.Entity.ExamType;
                rowFld.ChapterNo = request.Entity.ChapterNo;
                rowFld.TotalMark = request.Entity.TotalMark;
                rowFld.HeightMark = request.Entity.HeightMark;
                rowFld.StudentId = item.StudentId;
                rowFld.ObatainedMark = item.ObatainedMark;
                uow.Connection.Insert(rowFld);
            }
        }


        }
    }