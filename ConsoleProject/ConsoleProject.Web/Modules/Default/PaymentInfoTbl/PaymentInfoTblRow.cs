namespace ConsoleProject.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[PaymentInfo_tbl]")]
    [DisplayName("Payment Information"), InstanceName("Payment Information"), TwoLevelCached]
    [ReadPermission("Default:PaymentInfoTbl:Read")]
    [InsertPermission("Default:PaymentInfoTbl:Insert")]
    [UpdatePermission("Default:PaymentInfoTbl:Update")]
    [DeletePermission("Default:PaymentInfoTbl:Delete")]

    [LookupScript(Permission = "?")]
    public sealed class PaymentInfoTblRow : Row, IIdRow, INameRow
    {
        
        [DisplayName("Payment Id"), Column("Payment_Id"), Identity]
        public Int32? PaymentId
        {
            get { return Fields.PaymentId[this]; }
            set { Fields.PaymentId[this] = value; }
        }

        [DisplayName("Roll No."), Column("Student_Id"), ForeignKey("[dbo].[StudentInfo_tbl]", "Student_Id"), LeftJoin("jStudent"), TextualField("StudentName")]
       [LookupEditor(typeof(StudentInfoTblRow))]
        public Int32? StudentId
        {
            get { return Fields.StudentId[this]; }
            set { Fields.StudentId[this] = value; }
        }

        [DisplayName("Payment Date"), Column("Payment_Date")]
        public DateTime? PaymentDate
        {
            get { return Fields.PaymentDate[this]; }
            set { Fields.PaymentDate[this] = value; }
        }

        [DisplayName("Amount"), Size(18)]
        public Decimal? Amount
        {
            get { return Fields.Amount[this]; }
            set { Fields.Amount[this] = value; }
        }

        [DisplayName("Entry Date"), Column("Entry_Date")]
        public DateTime? EntryDate
        {
            get { return Fields.EntryDate[this]; }
            set { Fields.EntryDate[this] = value; }
        }

        [DisplayName("Entry User"), Column("Entry_User"), Size(50), QuickSearch]
        public String EntryUser
        {
            get { return Fields.EntryUser[this]; }
            set { Fields.EntryUser[this] = value; }
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

        [DisplayName("Batch"), Expression("jStudent.[College_batch]")]
        public String StudentCollegeBatch
        {
            get { return Fields.StudentCollegeBatch[this]; }
            set { Fields.StudentCollegeBatch[this] = value; }
        }

        [DisplayName("Father's Name"), Expression("jStudent.[Father_Name]")]
        public String StudentFatherName
        {
            get { return Fields.StudentFatherName[this]; }
            set { Fields.StudentFatherName[this] = value; }
        }

        [DisplayName("Mother's Name"), Expression("jStudent.[Mother_Name]")]
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

      

        [ImageUploadEditor(FilenameFormat = "StudentImage/~", CopyToHistory = true)]
        [DisplayName("Upload Image"), Expression("jStudent.[User_Image]")]
        public String StudentUserImage
        {
            get { return Fields.StudentUserImage[this]; }
            set { Fields.StudentUserImage[this] = value; }
        }

        [DisplayName("Admission Date"), Expression("jStudent.[AdmissionDate]")]
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

        [DisplayName("Course Duration(Month)"), Expression("jStudent.[Course_Duration]")]
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

        [DisplayName("Entry Date"), Expression("jStudent.[Entry_Date]")]
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

        [DisplayName("Is Active"), Expression("jStudent.[IsActive]")]
        public Int32? StudentIsActive
        {
            get { return Fields.StudentIsActive[this]; }
            set { Fields.StudentIsActive[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PaymentId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EntryUser; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PaymentInfoTblRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PaymentId;
            public Int32Field StudentId;
            public DateTimeField PaymentDate;
            public DecimalField Amount;
            public DateTimeField EntryDate;
            public StringField EntryUser;

            public StringField StudentName;
            public BooleanField StudentGender;
            public StringField StudentCollegeName;
            public StringField StudentCollegeBatch;
            public StringField StudentFatherName;
            public StringField StudentMotherName;
            public StringField StudentAddress;
            public StringField StudentDescription;
            public StringField StudentUserImage;
            public DateTimeField StudentAdmissionDate;
            public Int32Field StudentAdmissionType;
            public DecimalField StudentCourseTotalFee;
            public DoubleField StudentCourseDuration;
            public DecimalField StudentMonthlyFee;
            public DateTimeField StudentLeftDate;
            public DateTimeField StudentEntryDate;
            public StringField StudentEntryUser;
            public Int32Field StudentIsActive;
        }
    }
}
