
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.PaymentInfoTbl")]
    [BasedOnRow(typeof(Entities.PaymentInfoTblRow), CheckNames = true)]
    public class PaymentInfoTblColumns
    {
        [EditLink,QuickFilter]
        public Int32? StudentId { get; set; }


        [QuickFilter]
        public DateTime PaymentDate { get; set; }
        public Decimal Amount { get; set; }
    }
}