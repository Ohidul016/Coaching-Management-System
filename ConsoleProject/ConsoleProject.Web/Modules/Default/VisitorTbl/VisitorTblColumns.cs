
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.VisitorTbl")]
    [BasedOnRow(typeof(Entities.VisitorTblRow), CheckNames = true)]
    public class VisitorTblColumns
    {
        [EditLink]
        public String Name { get; set; }
        public String CollegeName { get; set; }
       
        [QuickFilter]
        public DateTime VisitDate { get; set; }
        public String Email { get; set; }
    }
}