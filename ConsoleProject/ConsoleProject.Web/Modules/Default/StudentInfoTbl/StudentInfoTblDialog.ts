namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class StudentInfoTblDialog extends _Ext.DialogBase<StudentInfoTblRow, any> {
        protected getFormKey() { return StudentInfoTblForm.formKey; }
        protected getIdProperty() { return StudentInfoTblRow.idProperty; }
        protected getLocalTextPrefix() { return StudentInfoTblRow.localTextPrefix; }
        protected getNameProperty() { return StudentInfoTblRow.nameProperty; }
        protected getService() { return StudentInfoTblService.baseUrl; }

        protected form = new StudentInfoTblForm(this.idPrefix);

        constructor() {
            super();
            this.set_dialogTitle("Student Information");
            this.InitForm();
        }
        public InitForm() {
            this.form.AdmissionType.changeSelect2(x => {
                if (this.form.AdmissionType.value == '1') {
                    q.showField(this.form.CourseTotalFee, true);
                    q.showField(this.form.CourseDuration, true);
                    q.showField(this.form.MonthlyFee, false);
                }
                else if (this.form.AdmissionType.value == '2') {
                    q.showField(this.form.CourseTotalFee, false);
                    q.showField(this.form.CourseDuration, false);
                    q.showField(this.form.MonthlyFee, true);
                }
                else {
                    q.showField(this.form.CourseTotalFee, false);
                    q.showField(this.form.CourseDuration, false);
                    q.showField(this.form.MonthlyFee, false);
                }
            });
            this.form.StudentStatus.changeSelect2(x => {
                if (this.form.StudentStatus.value == '1') {
                    this.form.IsActive.value = true;
                } else {
                    this.form.IsActive.value = false;
                }
            })
        }
        protected afterLoadEntity() {
            super.afterLoadEntity();
            q.showField(this.form.CourseTotalFee, false);
            q.showField(this.form.CourseDuration, false);
            q.showField(this.form.MonthlyFee, false);
            if (this.isNew()) {
                this.form.IsActive.value = true;
                this.form.StudentStatus.value = '1';
            } else {
                if (this.form.IsActive.value == true) {
                    this.form.StudentStatus.value = ConsoleProject.Default.EnumList.Active.Running.toString();
                } else {
                    this.form.StudentStatus.value = ConsoleProject.Default.EnumList.Active.Left.toString();
                }
            }
        }


    }
}