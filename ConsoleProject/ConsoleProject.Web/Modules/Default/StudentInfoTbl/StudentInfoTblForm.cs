
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

    [FormScript("Default.StudentInfoTbl")]
    [BasedOnRow(typeof(Entities.StudentInfoTblRow))]
    public class StudentInfoTblForm
    {
        [Tab("Personal Information")]
        [HalfWidth, Required]
        public String Name { get; set; }

        [OneWay, Required, HalfWidth]
        public Gender GenderType { get; set; }

        [HalfWidth, Required, Hidden]
        public Boolean Gender { get; set; }

        [HalfWidth, Required]
        public String CollegeName { get; set; }
        [HalfWidth, Required]
        public String CollegeBatch { get; set; }
        [HalfWidth, Required]
        public String FatherName { get; set; }
        [HalfWidth, Required]
        public String MotherName { get; set; }
        [FullWidth, Required]
        public String Address { get; set; }
       
        [FullWidth, TextAreaEditor(Rows = 2)]
        public String Description { get; set; }
       
        [OneThirdWidth, Required]
        public String MotherPhone { get; set; }
       
        [OneThirdWidth, Required]
        public String FatherPhone { get; set; }


        [OneThirdWidth]
        public String PersonalPhone { get; set; }
       
        [HalfWidth]
        public String StudentDepartment { get; set; }

        [FullWidth]
        public String UserImage { get; set; }

        [Tab("Admission Information")]

        [HalfWidth]
        public DateTime EntryDate { get; set; }
     
        [HalfWidth, Required]
        public DateTime AdmissionDate { get; set; }


        [FullWidth]
        public Int32 BatchId { get; set; }

        [FullWidth, Required]
        public Int32 AdmissionType { get; set; }

        [HalfWidth, Hidden]
        public Decimal CourseTotalFee { get; set; }

        [HalfWidth, Hidden]
        public Double CourseDuration { get; set; }

        [FullWidth, Hidden]
        public Decimal MonthlyFee { get; set; }

    

        [Hidden]
        public String EntryUser { get; set; }
        [Hidden]
        public Boolean IsActive { get; set; }
        [HalfWidth]
        public Active? StudentStatus { get; set; }
        
        [DisplayName("Expected Left Date"),HalfWidth]
        public DateTime? LeftDate { get; set; }


    }
}