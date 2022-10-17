
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class BatchTblGrid extends _Ext.GridBase<BatchTblRow, any> {
        protected getColumnsKey() { return 'Default.BatchTbl'; }
        protected getDialogType() { return BatchTblDialog; }
        protected getIdProperty() { return BatchTblRow.idProperty; }
        protected getLocalTextPrefix() { return BatchTblRow.localTextPrefix; }
        protected getService() { return BatchTblService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}