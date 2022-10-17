
namespace ConsoleProject.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Batch_tbl]")]
    [DisplayName("Batch Information"), InstanceName("Batch Information"), TwoLevelCached]
    [ReadPermission("Default:BatBatchTblch_tbl:Read")]
    [InsertPermission("Default:BatchTbl:Insert")]
    [UpdatePermission("Default:BatchTbl:Update")]
    [DeletePermission("Default:BatchTbl:Delete")]

    [LookupScript(Permission = "?")]
    public sealed class BatchTblRow : Row, IIdRow, INameRow
    {
        #region Concat

        [Expression("CONCAT(T0.[Batch_Name], CONCAT(' : Time( ' , T0.Batch_Time,' )') , CONCAT(' Day : ' , T0.Batch_Days))"), ReadOnly(true)]
        public String LookupText
        {
            get { return Fields.LookupText[this]; }
            set { Fields.LookupText[this] = value; }
        }

        #endregion

        [DisplayName("Batch Id"), Column("Batch_Id"), Identity]
        public Int32? BatchId
        {
            get { return Fields.BatchId[this]; }
            set { Fields.BatchId[this] = value; }
        }

        [DisplayName("Batch Name"), Column("Batch_Name"), Size(100), NotNull, QuickSearch]
        public String BatchName
        {
            get { return Fields.BatchName[this]; }
            set { Fields.BatchName[this] = value; }
        }

        [DisplayName("Batch Time"), Column("Batch_Time"), Size(100), NotNull]
        public String BatchTime
        {
            get { return Fields.BatchTime[this]; }
            set { Fields.BatchTime[this] = value; }
        }

        [DisplayName("Batch Days"), Column("Batch_Days"), Size(50), NotNull]
        public String BatchDays
        {
            get { return Fields.BatchDays[this]; }
            set { Fields.BatchDays[this] = value; }
        }

        [DisplayName("Is Active")]
        public Boolean? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.BatchId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LookupText; } 
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public BatchTblRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field BatchId;
            public StringField BatchName;
            public StringField BatchTime;
            public StringField BatchDays;
            public StringField LookupText;
            public BooleanField IsActive;
        }
    }
}
