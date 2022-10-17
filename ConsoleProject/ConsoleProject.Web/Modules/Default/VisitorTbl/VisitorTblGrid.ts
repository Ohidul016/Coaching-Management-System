
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class VisitorTblGrid extends _Ext.GridBase<VisitorTblRow, any> {
        protected getColumnsKey() { return 'Default.VisitorTbl'; }
        protected getDialogType() { return VisitorTblDialog; }
        protected getIdProperty() { return VisitorTblRow.idProperty; }
        protected getLocalTextPrefix() { return VisitorTblRow.localTextPrefix; }
        protected getService() { return VisitorTblService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}