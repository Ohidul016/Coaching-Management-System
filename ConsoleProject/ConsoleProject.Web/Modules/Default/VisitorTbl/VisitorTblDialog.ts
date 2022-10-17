
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class VisitorTblDialog extends _Ext.DialogBase<VisitorTblRow, any> {
        protected getFormKey() { return VisitorTblForm.formKey; }
        protected getIdProperty() { return VisitorTblRow.idProperty; }
        protected getLocalTextPrefix() { return VisitorTblRow.localTextPrefix; }
        protected getNameProperty() { return VisitorTblRow.nameProperty; }
        protected getService() { return VisitorTblService.baseUrl; }

        protected form = new VisitorTblForm(this.idPrefix);
        constructor() {
            super();
            this.set_dialogTitle("Visitor Information");
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();
            var ob = new Date();
            this.form.VisitDate.value = ob.toString();
        }

    }
}