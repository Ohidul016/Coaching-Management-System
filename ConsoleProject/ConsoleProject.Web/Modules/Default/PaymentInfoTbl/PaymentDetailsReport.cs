namespace ConsoleProject.Default
{
    using ConsoleProject.Administration;
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using System;
    using System.Collections.Generic;

    [Report("Default.PaymentDetailsReport")] 
    [ReportDesign(MVC.Views.Default.PaymentInfoTbl.PaymentTblDetailsReport)] 
    [ReadPermission("Default:PaymentInfoTbl:Read")] 
    public class PaymentDetailsReport : IReport, ICustomizeHtmlToPdf 
    {
        public Int32 PaymentId  { get; set; } 

        public object GetData()
        {
            var data = new PaymentDetailsReportData();

            using (var connection = SqlConnections.NewFor<PaymentInfoTblRow>())
            {
                var o = PaymentInfoTblRow.Fields;

                data.Student = connection.TryById<PaymentInfoTblRow>(this.PaymentId, q => q
                     .SelectTableFields()
                     .Select(o.StudentId)
                     .Select(o.StudentName)
                     .Select(o.StudentCollegeName)
                     .Select(o.PaymentDate)
                     .Select(o.Amount)
                     ) ?? new PaymentInfoTblRow();
             
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            // options.MarginsAll = "2cm";
        }
    }

  
    public class PaymentDetailsReportData 
    {
        public PaymentInfoTblRow Student { get; set; }
    }
}