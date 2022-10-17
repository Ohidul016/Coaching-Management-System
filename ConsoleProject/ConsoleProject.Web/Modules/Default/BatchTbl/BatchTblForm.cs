
namespace ConsoleProject.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.BatchTbl")]
    [BasedOnRow(typeof(Entities.BatchTblRow), CheckNames = true)]
    public class BatchTblForm
    {
        [FullWidth,Required]
        public String BatchName { get; set; }
        [FullWidth, Required]
        public String BatchTime { get; set; }
      
        [FullWidth, Required]
        public String BatchDays { get; set; }
     
        [HalfWidth]
        public Boolean IsActive { get; set; }
    }
}