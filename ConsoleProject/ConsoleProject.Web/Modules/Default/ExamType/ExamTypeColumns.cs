
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.ExamType")]
    [BasedOnRow(typeof(Entities.ExamTypeRow), CheckNames = true)]
    public class ExamTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 ExamId { get; set; }
        [EditLink]
        public String ExamName { get; set; }
    }
}