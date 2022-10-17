
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class ExamTypeDialog extends _Ext.DialogBase<ExamTypeRow, any> {
        protected getFormKey() { return ExamTypeForm.formKey; }
        protected getIdProperty() { return ExamTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ExamTypeRow.localTextPrefix; }
        protected getNameProperty() { return ExamTypeRow.nameProperty; }
        protected getService() { return ExamTypeService.baseUrl; }

        protected form = new ExamTypeForm(this.idPrefix);

    }
}