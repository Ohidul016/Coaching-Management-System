
namespace ConsoleProject.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using ConsoleProject.Default.EnumList;
    using ConsoleProject.Default.Entities;

    [FormScript("Default.ExamResult")]
    [BasedOnRow(typeof(Entities.ExamResultRow))]
    public class ExamResultForm
    {
     
       
        [FullWidth,Required]
        public Int32? BatchId { get; set; }

        [HalfWidth, Required]
        public DateTime ExamDate { get; set; }
       

        [HalfWidth, Required]
        public Int32 ExamType { get; set; }
       
        [FullWidth, Required]
        public String ChapterNo { get; set; }
      
        [HalfWidth]
        public Decimal TotalMark { get; set; }
       
        [HalfWidth]
        public Decimal HeightMark { get; set; }
     
        [Category(" ")]
        [FullWidth]
        public Int32 StudentId { get; set; }
        [FullWidth]
        public Decimal ObatainedMark { get; set; }

        [OneWay, DisplayName(""), StaticTextBlock, CssClass("col-md-4")]
        public string AddtoGrid { get; set; }


        [ExamResultGridEditor,FullWidth]
        public List<ExamResultRow> ExamMark { get; set; }
    }
}