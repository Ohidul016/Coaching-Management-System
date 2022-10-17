
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class ExamTypeGrid extends _Ext.GridBase<ExamTypeRow, any> {
        protected getColumnsKey() { return 'Default.ExamType'; } 
        protected getDialogType() { return ExamTypeDialog; }
        protected getIdProperty() { return ExamTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ExamTypeRow.localTextPrefix; }
        protected getService() { return ExamTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}