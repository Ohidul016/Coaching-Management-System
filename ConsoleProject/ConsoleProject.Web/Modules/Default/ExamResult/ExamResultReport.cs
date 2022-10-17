namespace ConsoleProject.Default
{
    using ConsoleProject.Administration;
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using System;
    using System.Collections.Generic;

    [Report("Default.ExamResult")]
    [ReportDesign(MVC.Views.Default.ExamResult.ExamResultReport)] 
    [ReadPermission("Default:ExamResult:Read")]
    public class ExamResultReport : IReport, ICustomizeHtmlToPdf 
    {
        public Int32 ResultID  { get; set; } 

        public object GetData()
        {
            var data = new ExamResultReportData();

            using (var connection = SqlConnections.NewFor<ExamResultRow>())
            {
                var o = ExamResultRow.Fields;

                data.Student = connection.TryById<ExamResultRow>(this.ResultID, q => q
                     .SelectTableFields()
                     .Select(o.StudentId)
                     .Select(o.StudentName)
                     .Select(o.StudentCollegeName)
                     .Select(o.StudentCollegeBatch)
                     .Select(o.StudentGender)
                     .Select(o.StudentFatherName)
                     .Select(o.StudentMotherName)
                     .Select(o.BatchBatchName)
                     .Select(o.BatchBatchTime)
                     .Select(o.BatchBatchDays)
                     .Select(o.ExamDate)
                     .Select(o.ExamType)
                     .Select(o.ExamTypeExamName)
                     .Select(o.ObatainedMark)
                     .Select(o.TotalMark)
                     .Select(o.HeightMark)) ?? new ExamResultRow();
             
            }


            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            // options.MarginsAll = "2cm";
        }
    }

  
    public class ExamResultReportData 
    {
        public ExamResultRow Student { get; set; } 
    }
}