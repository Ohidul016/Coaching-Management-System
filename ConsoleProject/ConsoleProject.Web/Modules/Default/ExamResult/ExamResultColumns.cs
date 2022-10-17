
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.ExamResult")]
    [BasedOnRow(typeof(Entities.ExamResultRow))]
    public class ExamResultColumns
    {
        [QuickFilter]
        public Int32? StudentId { get; set; }
    
        [QuickFilter]
        public DateTime ExamDate { get; set; }

        public String BatchBatchName { get; set; }

        [QuickFilter]
        public String ExamTypeExamName { get; set; }
        public String ChapterNo { get; set; }
        public Decimal ObatainedMark { get; set; }
        public Decimal HeightMark { get; set; }
        public Decimal TotalMark { get; set; }
    }
}