
namespace ConsoleProject.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[ExamResult]")]
    [DisplayName("Exam Result"), InstanceName("Exam Result"), TwoLevelCached]
    [ReadPermission("Default:ExamResult:Read")]
    [InsertPermission("Default:ExamResult:Insert")]
    [UpdatePermission("Default:ExamResult:Update")]
    [DeletePermission("Default:ExamResult:Delete")]
    public sealed class ExamResultRow : Row, IIdRow, INameRow
    {
        [DisplayName("Result Id"), Column("ResultID"), PrimaryKey,Identity]
        public Int32? ResultId
        {
            get { return Fields.ResultId[this]; }
            set { Fields.ResultId[this] = value; }
        }

        public List<ExamResultRow> ExamMark
        {
            get { return Fields.ExamMark[this]; }
            set { Fields.ExamMark[this] = value; }
        }


        [DisplayName("Exam Date")]
        public DateTime? ExamDate
        {
            get { return Fields.ExamDate[this]; }
            set { Fields.ExamDate[this] = value; }
        }

        [DisplayName("Student Name"), Column("Student_Id"), ForeignKey("[dbo].[StudentInfo_tbl]", "Student_Id"), LeftJoin("jStudent"), TextualField("StudentName")]
       [LookupEditor(typeof(StudentInfoTblRow))]
        public Int32? StudentId
        {
            get { return Fields.StudentId[this]; }
            set { Fields.StudentId[this] = value; }
        }

        [DisplayName("Batch"), Column("BatchId"), ForeignKey("[dbo].[Batch_tbl]", "Batch_Id"), LeftJoin("jBatch"), TextualField("BatchBatchName")]
        [LookupEditor(typeof(BatchTblRow))]
        public Int32? BatchId
        {
            get { return Fields.BatchId[this]; }
            set { Fields.BatchId[this] = value; }
        }


        [LookupEditor(typeof(ExamTypeRow))]
        [DisplayName("Exam Type"), NotNull, ForeignKey("[dbo].[ExamType]", "ExamID"), LeftJoin("jExamType"), TextualField("ExamTypeExamName")]
        public Int32? ExamType
        {
            get { return Fields.ExamType[this]; }
            set { Fields.ExamType[this] = value; }
        }

        [DisplayName("Chapter No"), Size(50)]
        public String ChapterNo
        {
            get { return Fields.ChapterNo[this]; }
            set { Fields.ChapterNo[this] = value; }
        }

        [DisplayName("Total Mark"), Size(18)]
        public Decimal? TotalMark
        {
            get { return Fields.TotalMark[this]; }
            set { Fields.TotalMark[this] = value; }
        }

        [DisplayName("Obatained Mark"), Size(18)]
        public Decimal? ObatainedMark
        {
            get { return Fields.ObatainedMark[this]; }
            set { Fields.ObatainedMark[this] = value; }
        }

        [DisplayName("Highest Mark"), Size(18), NotNull]
        public Decimal? HeightMark
        {
            get { return Fields.HeightMark[this]; }
            set { Fields.HeightMark[this] = value; }
        }

        [DisplayName("Student Name"), Expression("jStudent.[Name]")]
        public String StudentName
        {
            get { return Fields.StudentName[this]; }
            set { Fields.StudentName[this] = value; }
        }

        [DisplayName("Student Gender"), Expression("jStudent.[Gender]")]
        public Boolean? StudentGender
        {
            get { return Fields.StudentGender[this]; }
            set { Fields.StudentGender[this] = value; }
        }

        [DisplayName("Student College Name"), Expression("jStudent.[College_Name]")]
        public String StudentCollegeName
        {
            get { return Fields.StudentCollegeName[this]; }
            set { Fields.StudentCollegeName[this] = value; }
        }

        [DisplayName("Student College Batch"), Expression("jStudent.[College_batch]")]
        public String StudentCollegeBatch
        {
            get { return Fields.StudentCollegeBatch[this]; }
            set { Fields.StudentCollegeBatch[this] = value; }
        }

        [DisplayName("Student Father Name"), Expression("jStudent.[Father_Name]")]
        public String StudentFatherName
        {
            get { return Fields.StudentFatherName[this]; }
            set { Fields.StudentFatherName[this] = value; }
        }

        [DisplayName("Student Mother Name"), Expression("jStudent.[Mother_Name]")]
        public String StudentMotherName
        {
            get { return Fields.StudentMotherName[this]; }
            set { Fields.StudentMotherName[this] = value; }
        }

        [DisplayName("Student Address"), Expression("jStudent.[Address]")]
        public String StudentAddress
        {
            get { return Fields.StudentAddress[this]; }
            set { Fields.StudentAddress[this] = value; }
        }

        [DisplayName("Student Description"), Expression("jStudent.[Description]")]
        public String StudentDescription
        {
            get { return Fields.StudentDescription[this]; }
            set { Fields.StudentDescription[this] = value; }
        }

        [DisplayName("Student Mother Phone"), Expression("jStudent.[Mother_Phone]")]
        public String StudentMotherPhone
        {
            get { return Fields.StudentMotherPhone[this]; }
            set { Fields.StudentMotherPhone[this] = value; }
        }

        [DisplayName("Student Father Phone"), Expression("jStudent.[Father_Phone]")]
        public String StudentFatherPhone
        {
            get { return Fields.StudentFatherPhone[this]; }
            set { Fields.StudentFatherPhone[this] = value; }
        }

        [DisplayName("Student Personal Phone"), Expression("jStudent.[Personal_Phone]")]
        public String StudentPersonalPhone
        {
            get { return Fields.StudentPersonalPhone[this]; }
            set { Fields.StudentPersonalPhone[this] = value; }
        }

        [DisplayName("Student User Image"), Expression("jStudent.[User_Image]")]
        public String StudentUserImage
        {
            get { return Fields.StudentUserImage[this]; }
            set { Fields.StudentUserImage[this] = value; }
        }

        [DisplayName("Student Batch Time"), Expression("jStudent.[Batch_Time]")]
        public String StudentBatchTime
        {
            get { return Fields.StudentBatchTime[this]; }
            set { Fields.StudentBatchTime[this] = value; }
        }

        [DisplayName("Student Admission Date"), Expression("jStudent.[AdmissionDate]")]
        public DateTime? StudentAdmissionDate
        {
            get { return Fields.StudentAdmissionDate[this]; }
            set { Fields.StudentAdmissionDate[this] = value; }
        }

        [DisplayName("Student Admission Type"), Expression("jStudent.[AdmissionType]")]
        public Int32? StudentAdmissionType
        {
            get { return Fields.StudentAdmissionType[this]; }
            set { Fields.StudentAdmissionType[this] = value; }
        }

        [DisplayName("Student Course Total Fee"), Expression("jStudent.[Course_TotalFee]")]
        public Decimal? StudentCourseTotalFee
        {
            get { return Fields.StudentCourseTotalFee[this]; }
            set { Fields.StudentCourseTotalFee[this] = value; }
        }

        [DisplayName("Student Days"), Expression("jStudent.[Days]")]
        public String StudentDays
        {
            get { return Fields.StudentDays[this]; }
            set { Fields.StudentDays[this] = value; }
        }

        [DisplayName("Student Course Duration"), Expression("jStudent.[Course_Duration]")]
        public Double? StudentCourseDuration
        {
            get { return Fields.StudentCourseDuration[this]; }
            set { Fields.StudentCourseDuration[this] = value; }
        }

        [DisplayName("Student Monthly Fee"), Expression("jStudent.[Monthly_Fee]")]
        public Decimal? StudentMonthlyFee
        {
            get { return Fields.StudentMonthlyFee[this]; }
            set { Fields.StudentMonthlyFee[this] = value; }
        }

        [DisplayName("Student Left Date"), Expression("jStudent.[Left_Date]")]
        public DateTime? StudentLeftDate
        {
            get { return Fields.StudentLeftDate[this]; }
            set { Fields.StudentLeftDate[this] = value; }
        }

        [DisplayName("Student Entry Date"), Expression("jStudent.[Entry_Date]")]
        public DateTime? StudentEntryDate
        {
            get { return Fields.StudentEntryDate[this]; }
            set { Fields.StudentEntryDate[this] = value; }
        }

        [DisplayName("Student Entry User"), Expression("jStudent.[Entry_User]")]
        public String StudentEntryUser
        {
            get { return Fields.StudentEntryUser[this]; }
            set { Fields.StudentEntryUser[this] = value; }
        }

        [DisplayName("Student Is Active"), Expression("jStudent.[IsActive]")]
        public Int32? StudentIsActive
        {
            get { return Fields.StudentIsActive[this]; }
            set { Fields.StudentIsActive[this] = value; }
        }
       
    

        [DisplayName("Exam Type"), Expression("jExamType.[Exam_Name]")]
        public String ExamTypeExamName
        {
            get { return Fields.ExamTypeExamName[this]; }
            set { Fields.ExamTypeExamName[this] = value; }
        }

        [DisplayName("Batch Name"), Expression("jBatch.[Batch_Name]")]
        public String BatchBatchName
        {
            get { return Fields.BatchBatchName[this]; }
            set { Fields.BatchBatchName[this] = value; }
        }

        [DisplayName("Batch Time"), Expression("jBatch.[Batch_Time]")]
        public String BatchBatchTime
        {
            get { return Fields.BatchBatchTime[this]; }
            set { Fields.BatchBatchTime[this] = value; }
        }

        [DisplayName("Batch Days"), Expression("jBatch.[Batch_Days]")]
        public String BatchBatchDays
        {
            get { return Fields.BatchBatchDays[this]; }
            set { Fields.BatchBatchDays[this] = value; }
        }


        IIdField IIdRow.IdField
        {
            get { return Fields.ResultId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ChapterNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ExamResultRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ResultId;
            public DateTimeField ExamDate;
            public Int32Field StudentId;
            public Int32Field BatchId;
            public Int32Field ExamType;
            public StringField ChapterNo;
            public DecimalField TotalMark;
            public DecimalField ObatainedMark;
            public DecimalField HeightMark;

            public StringField StudentName;
            public BooleanField StudentGender;
            public StringField StudentCollegeName;
            public StringField StudentCollegeBatch;
            public StringField StudentFatherName;
            public StringField StudentMotherName;
            public StringField StudentAddress;
            public StringField StudentDescription;
            public StringField StudentMotherPhone;
            public StringField StudentFatherPhone;
            public StringField StudentPersonalPhone;
            public StringField StudentUserImage;
            public StringField StudentBatchTime;
            public DateTimeField StudentAdmissionDate;
            public Int32Field StudentAdmissionType;
            public DecimalField StudentCourseTotalFee;
            public StringField StudentDays;
            public DoubleField StudentCourseDuration;
            public DecimalField StudentMonthlyFee;
            public DateTimeField StudentLeftDate;
            public DateTimeField StudentEntryDate;
            public StringField StudentEntryUser;
            public Int32Field StudentIsActive;

            public StringField ExamTypeExamName;
            public ListField<ExamResultRow> ExamMark;
            public StringField BatchBatchName;
            public StringField BatchBatchTime;
            public StringField BatchBatchDays;
        }
    }
}
