
namespace ConsoleProject.Default.Entities
{
    using ConsoleProject.Default.EnumList;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[StudentInfo_tbl]")]
    [DisplayName("Student Information"), InstanceName("Student Information"), TwoLevelCached]
    [ReadPermission("Default:StudentInfoTbl:Read")]
    [InsertPermission("Default:StudentInfoTbl:Insert")]
    [UpdatePermission("Default:StudentInfoTbl:Update")]
    [DeletePermission("Default:StudentInfoTbl:Delete")]

    [LookupScript(Permission = "?")]

    public sealed class StudentInfoTblRow : Row, IIdRow, INameRow
    {

        #region Concat

        [Expression("CONCAT(T0.[Name], CONCAT(' - ' , T0.Student_Id))"), ReadOnly(true)]
        public String LookupText
        {
            get { return Fields.LookupText[this]; }
            set { Fields.LookupText[this] = value; }
        }

        #endregion

        [DisplayName("Roll No."), Column("Student_Id"), Identity, ForeignKey("[dbo].[StudentInfo_tbl]", "Student_Id"), LeftJoin("jStudent"), TextualField("StudentName")]
        public Int32? StudentId
        {
            get { return Fields.StudentId[this]; }
            set { Fields.StudentId[this] = value; }
        }

        [DisplayName("Name"), Size(200), NotNull, QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Department"), Size(200), NotNull, QuickSearch]
        public String StudentDepartment
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }



        [DisplayName("Gender"), NotNull]
        public Boolean? Gender
        {
            get { return Fields.Gender[this]; }
            set { Fields.Gender[this] = value; }
        }

        [DisplayName("College Name"), Column("College_Name"), Size(200), NotNull]
        public String CollegeName
        {
            get { return Fields.CollegeName[this]; }
            set { Fields.CollegeName[this] = value; }
        }

        [DisplayName("College Batch"), Column("College_batch"), Size(100), NotNull]
        public String CollegeBatch
        {
            get { return Fields.CollegeBatch[this]; }
            set { Fields.CollegeBatch[this] = value; }
        }

        [DisplayName("Father Name"), Column("Father_Name"), Size(200), NotNull]
        public String FatherName
        {
            get { return Fields.FatherName[this]; }
            set { Fields.FatherName[this] = value; }
        }

        [DisplayName("Mother Name"), Column("Mother_Name"), Size(200), NotNull]
        public String MotherName
        {
            get { return Fields.MotherName[this]; }
            set { Fields.MotherName[this] = value; }
        }

        [DisplayName("Address"), Size(200), NotNull]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Description"), Size(300)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Mother Phone"), Column("Mother_Phone"), Size(15)]
        public String MotherPhone
        {
            get { return Fields.MotherPhone[this]; }
            set { Fields.MotherPhone[this] = value; }
        }

        [DisplayName("Father Phone"), Column("Father_Phone"), Size(15), NotNull]
        public String FatherPhone
        {
            get { return Fields.FatherPhone[this]; }
            set { Fields.FatherPhone[this] = value; }
        }

        [DisplayName("Personal Phone"), Column("Personal_Phone"), Size(15)]
        public String PersonalPhone
        {
            get { return Fields.PersonalPhone[this]; }
            set { Fields.PersonalPhone[this] = value; }
        }

        [DisplayName("User Image"), Column("User_Image"), Size(300)]
        [ImageUploadEditor(FilenameFormat = "StudentImage/~", CopyToHistory = true)]
        public String UserImage
        {
            get { return Fields.UserImage[this]; }
            set { Fields.UserImage[this] = value; }
        }

      
        [DisplayName("Batch"), Column("Batch_Id"), ForeignKey("[dbo].[Batch_tbl]", "Batch_Id"), LeftJoin("jBatch"), TextualField("BatchBatchName")]
        [LookupEditor(typeof(BatchTblRow))]
        public Int32? BatchId
        {
            get { return Fields.BatchId[this]; }
            set { Fields.BatchId[this] = value; }
        }

        [DisplayName("Admission Date"), NotNull]
        public DateTime? AdmissionDate
        {
            get { return Fields.AdmissionDate[this]; }
            set { Fields.AdmissionDate[this] = value; }
        }

        [DisplayName("Admission Type"), NotNull]
        public AdmissionType? AdmissionType
        {
            get { return (AdmissionType)Fields.AdmissionType[this]; }
            set { Fields.AdmissionType[this] = (Int32)value; }
        }

        [DisplayName("Course Total Fee"), Column("Course_TotalFee"), Size(18)]
        public Decimal? CourseTotalFee
        {
            get { return Fields.CourseTotalFee[this]; }
            set { Fields.CourseTotalFee[this] = value; }
        }

        [DisplayName("Course Duration"), Column("Course_Duration")]
        public Double? CourseDuration
        {
            get { return Fields.CourseDuration[this]; }
            set { Fields.CourseDuration[this] = value; }
        }

        [DisplayName("Monthly Fee"), Column("Monthly_Fee"), Size(18)]
        public Decimal? MonthlyFee
        {
            get { return Fields.MonthlyFee[this]; }
            set { Fields.MonthlyFee[this] = value; }
        }

        [DisplayName("Left Date"), Column("Left_Date")]
        public DateTime? LeftDate
        {
            get { return Fields.LeftDate[this]; }
            set { Fields.LeftDate[this] = value; }
        }

        [DisplayName("Entry Date"), Column("Entry_Date")]
        public DateTime? EntryDate
        {
            get { return Fields.EntryDate[this]; }
            set { Fields.EntryDate[this] = value; }
        }

        [DisplayName("Entry User"), Column("Entry_User"), Size(50)]
        public String EntryUser
        {
            get { return Fields.EntryUser[this]; }
            set { Fields.EntryUser[this] = value; }
        }

        [DisplayName("Student Is Running")]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Name"), Expression("jStudent.[Name]")]
        public String StudentName
        {
            get { return Fields.StudentName[this]; }
            set { Fields.StudentName[this] = value; }
        }

        [DisplayName("Gender"), Expression("jStudent.[Gender]")]
        public Boolean? StudentGender
        {
            get { return Fields.StudentGender[this]; }
            set { Fields.StudentGender[this] = value; }
        }

        [DisplayName("College Name"), Expression("jStudent.[College_Name]")]
        public String StudentCollegeName
        {
            get { return Fields.StudentCollegeName[this]; }
            set { Fields.StudentCollegeName[this] = value; }
        }

        [DisplayName("College Batch"), Expression("jStudent.[College_batch]")]
        public String StudentCollegeBatch
        {
            get { return Fields.StudentCollegeBatch[this]; }
            set { Fields.StudentCollegeBatch[this] = value; }
        }

        [DisplayName("Father Name"), Expression("jStudent.[Father_Name]")]
        public String StudentFatherName
        {
            get { return Fields.StudentFatherName[this]; }
            set { Fields.StudentFatherName[this] = value; }
        }

        [DisplayName("Mother Name"), Expression("jStudent.[Mother_Name]")]
        public String StudentMotherName
        {
            get { return Fields.StudentMotherName[this]; }
            set { Fields.StudentMotherName[this] = value; }
        }

        [DisplayName("Address"), Expression("jStudent.[Address]")]
        public String StudentAddress
        {
            get { return Fields.StudentAddress[this]; }
            set { Fields.StudentAddress[this] = value; }
        }

        [DisplayName("Description"), Expression("jStudent.[Description]")]
        public String StudentDescription
        {
            get { return Fields.StudentDescription[this]; }
            set { Fields.StudentDescription[this] = value; }
        }

        [DisplayName("Mother's Phone"), Expression("jStudent.[Mother_Phone]")]
        public String StudentMotherPhone
        {
            get { return Fields.StudentMotherPhone[this]; }
            set { Fields.StudentMotherPhone[this] = value; }
        }

        [DisplayName("Father's Phone"), Expression("jStudent.[Father_Phone]")]
        public String StudentFatherPhone
        {
            get { return Fields.StudentFatherPhone[this]; }
            set { Fields.StudentFatherPhone[this] = value; }
        }

        [DisplayName("Personal Phone"), Expression("jStudent.[Personal_Phone]")]
        public String StudentPersonalPhone
        {
            get { return Fields.StudentPersonalPhone[this]; }
            set { Fields.StudentPersonalPhone[this] = value; }
        }

        [DisplayName("Student Image"), Expression("jStudent.[User_Image]")]
        public String StudentUserImage
        {
            get { return Fields.StudentUserImage[this]; }
            set { Fields.StudentUserImage[this] = value; }
        }

        [DisplayName("Batch"), Expression("jStudent.[Batch_Id]")]
        public Int32? StudentBatchId
        {
            get { return Fields.StudentBatchId[this]; }
            set { Fields.StudentBatchId[this] = value; }
        }

        [DisplayName("Joining Date"), Expression("jStudent.[AdmissionDate]")]
        public DateTime? StudentAdmissionDate
        {
            get { return Fields.StudentAdmissionDate[this]; }
            set { Fields.StudentAdmissionDate[this] = value; }
        }

        [DisplayName("Admission Type"), Expression("jStudent.[AdmissionType]")]
        public Int32? StudentAdmissionType
        {
            get { return Fields.StudentAdmissionType[this]; }
            set { Fields.StudentAdmissionType[this] = value; }
        }

        [DisplayName("Course Total Fee"), Expression("jStudent.[Course_TotalFee]")]
        public Decimal? StudentCourseTotalFee
        {
            get { return Fields.StudentCourseTotalFee[this]; }
            set { Fields.StudentCourseTotalFee[this] = value; }
        }

        [DisplayName("Course Duration"), Expression("jStudent.[Course_Duration]")]
        public Double? StudentCourseDuration
        {
            get { return Fields.StudentCourseDuration[this]; }
            set { Fields.StudentCourseDuration[this] = value; }
        }

        [DisplayName("Monthly Fee"), Expression("jStudent.[Monthly_Fee]")]
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

        [DisplayName("Admission Date"), Expression("jStudent.[Entry_Date]")]
        public DateTime? StudentEntryDate
        {
            get { return Fields.StudentEntryDate[this]; }
            set { Fields.StudentEntryDate[this] = value; }
        }

        [DisplayName("Entry User"), Expression("jStudent.[Entry_User]")]
        public String StudentEntryUser
        {
            get { return Fields.StudentEntryUser[this]; }
            set { Fields.StudentEntryUser[this] = value; }
        }

        [DisplayName("Student Is Active"), Expression("jStudent.[IsActive]")]
        public Boolean? StudentIsActive
        {
            get { return Fields.StudentIsActive[this]; }
            set { Fields.StudentIsActive[this] = value; }
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



        [DisplayName("Student Is Active"), Expression("jBatch.[IsActive]")]
        public Boolean? BatchIsActive
        {
            get { return Fields.BatchIsActive[this]; }
            set { Fields.BatchIsActive[this] = value; }
        }

        [DisplayName("Student Status"),NotMapped]
        public Active? StudentStatus
        {
            get { return (Active)Fields.StudentStatus[this]; }
            set { Fields.StudentStatus[this] = (Int32)value; }
        }


        IIdField IIdRow.IdField
        {
            get { return Fields.StudentId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LookupText; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StudentInfoTblRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field StudentId;
            public StringField Name;
            public BooleanField Gender;
            public StringField CollegeName;
            public StringField CollegeBatch;
            public StringField FatherName;
            public StringField MotherName;
            public StringField Address;
            public StringField Description;
            public StringField MotherPhone;
            public StringField FatherPhone;
            public StringField PersonalPhone;
            public StringField UserImage;
            public Int32Field BatchId;
            public DateTimeField AdmissionDate;
            public Int32Field AdmissionType;
            public DecimalField CourseTotalFee;
            public DoubleField CourseDuration;
            public DecimalField MonthlyFee;
            public DateTimeField LeftDate;
            public DateTimeField EntryDate;
            public StringField EntryUser;
            public BooleanField IsActive;
            public Int32Field StudentStatus;

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
            public Int32Field StudentBatchId;
            public DateTimeField StudentAdmissionDate;
            public Int32Field StudentAdmissionType;
            public DecimalField StudentCourseTotalFee;
            public DoubleField StudentCourseDuration;
            public DecimalField StudentMonthlyFee;
            public DateTimeField StudentLeftDate;
            public DateTimeField StudentEntryDate;
            public StringField StudentEntryUser;
            public BooleanField StudentIsActive;

            public StringField BatchBatchName;
            public StringField BatchBatchTime;
            public StringField BatchBatchDays;
            public BooleanField BatchIsActive;
            public StringField LookupText;
            public StringField StudentDepartment;
        }
    }
}
