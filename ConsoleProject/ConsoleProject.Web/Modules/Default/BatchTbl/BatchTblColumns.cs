
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.BatchTbl")]
    [BasedOnRow(typeof(Entities.BatchTblRow), CheckNames = true)]
    public class BatchTblColumns
    {

        [EditLink]
        public String BatchName { get; set; }
        public String BatchTime { get; set; }
        public String BatchDays { get; set; }
        public Boolean IsActive { get; set; }
    }
}