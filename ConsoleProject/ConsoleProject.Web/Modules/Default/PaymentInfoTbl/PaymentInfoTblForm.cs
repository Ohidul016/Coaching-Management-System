
namespace ConsoleProject.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.PaymentInfoTbl")]
    [BasedOnRow(typeof(Entities.PaymentInfoTblRow))]
    public class PaymentInfoTblForm
    {
        [HalfWidth,Required]
        public Int32 StudentId { get; set; }

        [HalfWidth,OneWay,ReadOnly(true)]
        public Int32? Roll { get; set; }
       
        [HalfWidth, OneWay, ReadOnly(true)]
        public string CollegeName { get; set; }
       
        [HalfWidth, OneWay, ReadOnly(true)]
        public string AdmissionType { get; set; }
       
        [Category("Fee Information")]
        [HalfWidth, OneWay, DisplayName("Course Total Fee"), ReadOnly(true),Hidden]
        public decimal? Coursefee { get; set; }
       
        [HalfWidth, OneWay, DisplayName("Total Paid Amount"), ReadOnly(true), Hidden]
        public decimal? CoursePaid { get; set; }
     
        [HalfWidth, OneWay, DisplayName("Course Information"), ReadOnly(true), Hidden]
        public string CourseDuration { get; set; }

        [HalfWidth, OneWay,DisplayName("Monthly Fee"), ReadOnly(true), Hidden]
        public decimal? MonthlyFee { get; set; } 
       
        [HalfWidth, OneWay, ReadOnly(true), Hidden]
        public string MonthlyPaid { get; set; } 
     
        [HalfWidth,ReadOnly(true),OneWay]
        public  DateTime? LastPaidDate { get; set; }
       
        [FullWidth, OneWay, ReadOnly(true),Hidden]
        public string Description { get; set; }

        [Category("Payment")]
        [HalfWidth,Required]
        public DateTime PaymentDate { get; set; }
     
        [HalfWidth, Required]
        public Decimal Amount { get; set; }
       
        [Hidden]
        public DateTime EntryDate { get; set; }
        
        [Hidden]
        public String EntryUser { get; set; }
    }
}