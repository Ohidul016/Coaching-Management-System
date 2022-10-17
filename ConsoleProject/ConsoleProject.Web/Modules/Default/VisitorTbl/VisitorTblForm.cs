
namespace ConsoleProject.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.VisitorTbl")]
    [BasedOnRow(typeof(Entities.VisitorTblRow), CheckNames = true)]
    public class VisitorTblForm
    {
        [FullWidth,Required]
        public String Name { get; set; }
      
        [FullWidth, Required]
        public String CollegeName { get; set; }
        [FullWidth]
        public String CollegeBatch { get; set; }
        [HalfWidth]
        public String FatherName { get; set; }
        [HalfWidth]
        public String MotherName { get; set; }
        [HalfWidth]
        public String PersonalContact { get; set; }
        [HalfWidth]
        public String ParentsContact { get; set; }
        [FullWidth]
        public String Address { get; set; }
        [HalfWidth]
        public String Email { get; set; }
        [HalfWidth]
        public DateTime VisitDate { get; set; }
        [FullWidth, TextAreaEditor(Rows = 3)]
        public String Notes { get; set; }
     
    }
}