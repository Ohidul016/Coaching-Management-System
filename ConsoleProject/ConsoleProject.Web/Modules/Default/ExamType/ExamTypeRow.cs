
namespace ConsoleProject.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[ExamType]")]
    [DisplayName("Exam Type"), InstanceName("Exam Type"), TwoLevelCached]
    [ReadPermission("Default:ExamType:Read")]
    [InsertPermission("Default:ExamType:Insert")]
    [UpdatePermission("Default:ExamType:Update")]
    [DeletePermission("Default:ExamType:Delete")]

    [LookupScript(Permission = "?")]
    public sealed class ExamTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Exam Id"), Column("ExamID"), Identity]
        public Int32? ExamId
        {
            get { return Fields.ExamId[this]; }
            set { Fields.ExamId[this] = value; }
        }

        [DisplayName("Exam Name"), Column("Exam_Name"), Size(50), NotNull, QuickSearch]
        public String ExamName
        {
            get { return Fields.ExamName[this]; }
            set { Fields.ExamName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ExamId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ExamName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ExamTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ExamId;
            public StringField ExamName;
        }
    }
}
