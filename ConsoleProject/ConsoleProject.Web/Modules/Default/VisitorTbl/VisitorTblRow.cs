
namespace ConsoleProject.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Visitor_tbl]")]
    [DisplayName("Visitor Information"), InstanceName("Visitor Information"), TwoLevelCached]
    [ReadPermission("Default:VisitorTbl:Read")]
    [InsertPermission("Default:VisitorTbl:Insert")]
    [UpdatePermission("Default:VisitorTbl:Update")]
    [DeletePermission("Default:VisitorTbl:Delete")]
    public sealed class VisitorTblRow : Row, IIdRow, INameRow
    {
        [DisplayName("Visitor Id"), Column("Visitor_Id"), Identity]
        public Int32? VisitorId
        {
            get { return Fields.VisitorId[this]; }
            set { Fields.VisitorId[this] = value; }
        }

        [DisplayName("Name"), Size(100), QuickSearch]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("College Name"), Column("College_Name"), Size(50)]
        public String CollegeName
        {
            get { return Fields.CollegeName[this]; }
            set { Fields.CollegeName[this] = value; }
        }

        [DisplayName("College Batch"), Column("College_Batch"), Size(50)]
        public String CollegeBatch
        {
            get { return Fields.CollegeBatch[this]; }
            set { Fields.CollegeBatch[this] = value; }
        }

        [DisplayName("Father Name"), Column("Father_Name"), Size(50)]
        public String FatherName
        {
            get { return Fields.FatherName[this]; }
            set { Fields.FatherName[this] = value; }
        }

        [DisplayName("Mother Name"), Column("Mother_Name"), Size(50)]
        public String MotherName
        {
            get { return Fields.MotherName[this]; }
            set { Fields.MotherName[this] = value; }
        }

        [DisplayName("Personal Contact"), Column("Personal_Contact"), Size(50)]
        public String PersonalContact
        {
            get { return Fields.PersonalContact[this]; }
            set { Fields.PersonalContact[this] = value; }
        }

        [DisplayName("Parents Contact"), Column("Parents_Contact"), Size(50)]
        public String ParentsContact
        {
            get { return Fields.ParentsContact[this]; }
            set { Fields.ParentsContact[this] = value; }
        }

        [DisplayName("Address"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Visit Date"), Column("Visit_Date")]
        public DateTime? VisitDate
        {
            get { return Fields.VisitDate[this]; }
            set { Fields.VisitDate[this] = value; }
        }

        [DisplayName("Notes"), Size(50)]
        public String Notes
        {
            get { return Fields.Notes[this]; }
            set { Fields.Notes[this] = value; }
        }

        [DisplayName("Email"), Size(50)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.VisitorId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VisitorTblRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field VisitorId;
            public StringField Name;
            public StringField CollegeName;
            public StringField CollegeBatch;
            public StringField FatherName;
            public StringField MotherName;
            public StringField PersonalContact;
            public StringField ParentsContact;
            public StringField Address;
            public DateTimeField VisitDate;
            public StringField Notes;
            public StringField Email;
        }
    }
}
