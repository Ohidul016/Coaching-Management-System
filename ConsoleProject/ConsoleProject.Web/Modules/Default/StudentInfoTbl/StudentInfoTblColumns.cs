
namespace ConsoleProject.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.StudentInfoTbl")]
    [BasedOnRow(typeof(Entities.StudentInfoTblRow), CheckNames = true)]
    public class StudentInfoTblColumns
    {
        [EditLink,QuickFilter]
        public Int32? StudentId { get; set; }
        [EditLink]
        public String StudentName { get; set; }
        public String CollegeName { get; set; }
       
        [QuickFilter]
        public String BatchBatchName { get; set; }
      
        [QuickFilter]
        public DateTime AdmissionDate { get; set; }
      
        [QuickFilter]
        public DateTime LeftDate { get; set; }
        public Boolean IsActive { get; set; }
    }
}