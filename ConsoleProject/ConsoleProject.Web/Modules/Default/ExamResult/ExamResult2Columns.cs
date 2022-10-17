
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.ExamResult2")]
    [BasedOnRow(typeof(Entities.ExamResultRow))]
    public class ExamResult2Columns 
    {
        public String StudentName { get; set; }

        public Decimal ObatainedMark { get; set; }
      
        [Hidden]
        public DateTime ExamDate { get; set; }
        [Hidden]
        public Int32 ResultId { get; set; }

        [Hidden]
        public String ExamTypeExamName { get; set; }
        [Hidden]
        public String ChapterNo { get; set; }
        [Hidden]
        public Decimal TotalMark { get; set; }
        public Int32? BatchId { get; set; }
        
        [Hidden]
        public Decimal HeightMark { get; set; }
    }
}