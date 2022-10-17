
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class BatchTblDialog extends _Ext.DialogBase<BatchTblRow, any> {
        protected getFormKey() { return BatchTblForm.formKey; }
        protected getIdProperty() { return BatchTblRow.idProperty; }
        protected getLocalTextPrefix() { return BatchTblRow.localTextPrefix; }
        protected getNameProperty() { return BatchTblRow.nameProperty; }
        protected getService() { return BatchTblService.baseUrl; }

        protected form = new BatchTblForm(this.idPrefix);

    }
}