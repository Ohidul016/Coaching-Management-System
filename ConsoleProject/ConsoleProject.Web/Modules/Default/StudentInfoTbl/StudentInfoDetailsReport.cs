namespace ConsoleProject.Default
{
    using ConsoleProject.Administration;
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using System;
    using System.Collections.Generic;

    [Report("Default.StudentInfoDetails")]
    [ReportDesign(MVC.Views.Default.StudentInfoTbl.StudentInfoTblDetailsReport)]
    [ReadPermission("Default:StudentInfoTbl:Read")]
    public class StudentInfoDetailsReport : IReport, ICustomizeHtmlToPdf
    {
        public Int32 StudentId  { get; set; }

        public object GetData()
        {
            var data = new StudentInfoDetailsReportData();

            using (var connection = SqlConnections.NewFor<StudentInfoTblRow>())
            {
                var o = StudentInfoTblRow.Fields;

                data.Student = connection.TryById<StudentInfoTblRow>(this.StudentId, q => q
                     .SelectTableFields()
                     .Select(o.StudentId)
                     .Select(o.StudentName)
                     .Select(o.StudentCollegeName)
                     .Select(o.CollegeBatch)
                     .Select(o.StudentGender)
                     .Select(o.FatherName)
                     .Select(o.MotherName)
                     .Select(o.MotherName)
                     .Select(o.CollegeName) 
                     .Select(o.StudentAddress)
                     .Select(o.PersonalPhone)
                     .Select(o.FatherPhone)
                     .Select(o.MotherPhone)
                     .Select(o.UserImage)
                     .Select(o.EntryDate)
                     .Select(o.AdmissionDate)
                     .Select(o.BatchBatchName)
                     .Select(o.BatchBatchTime)
                     .Select(o.BatchBatchDays)
                     .Select(o.AdmissionType)
                     .Select(o.MonthlyFee)
                     .Select(o.CourseTotalFee)
                     .Select(o.CourseDuration)
                     .Select(o.StudentName)) ?? new StudentInfoTblRow();
             
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            // options.MarginsAll = "2cm";
        }
    }

  
    public class StudentInfoDetailsReportData 
    {
        public StudentInfoTblRow Student { get; set; }
    }
}