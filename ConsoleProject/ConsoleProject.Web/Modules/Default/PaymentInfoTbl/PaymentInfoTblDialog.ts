
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class PaymentInfoTblDialog extends _Ext.DialogBase<PaymentInfoTblRow, any> {
        protected getFormKey() { return PaymentInfoTblForm.formKey; }
        protected getIdProperty() { return PaymentInfoTblRow.idProperty; }
        protected getLocalTextPrefix() { return PaymentInfoTblRow.localTextPrefix; }
        protected getNameProperty() { return PaymentInfoTblRow.nameProperty; }
        protected getService() { return PaymentInfoTblService.baseUrl; }

        protected form = new PaymentInfoTblForm(this.idPrefix);
        constructor() {
            super();
            this.set_dialogTitle("Student Information");
            this.InitForm();
        }
        public InitForm() {
            this.form.StudentId.changeSelect2(x => {
                this.CourseShow(false);
                this.MonthlyShow(false);
                if (this.form.StudentId.value != null)
                this.LoadAllInfo(this.form.StudentId.value);
            });
            
        }
        protected afterLoadEntity() {
            super.afterLoadEntity();
            this.CourseShow(false);
            this.MonthlyShow(false);
        }

        public LoadAllInfo(_StudentId) { 
            PaymentInfoTblService.StudentDetailsInfo({ StudentId: +_StudentId },
                response => {
                    if (response.Entity) {
                        this.form.Roll.value = response.Entity.Student_Id;
                        this.form.CollegeName.value = response.Entity.College_Name;
                        if (response.Entity.AdmissionType == 1) {
                            this.form.AdmissionType.value = "Course";
                            this.CourseShow(true);
                            this.form.Coursefee.value = response.Entity.Course_TotalFee;
                            this.CourePayment(_StudentId);
                        }
                        else {
                            this.form.AdmissionType.value = "Monthly";
                            this.MonthlyShow(true);
                            this.form.MonthlyFee.value = response.Entity.Monthly_Fee;
                            this.MonthlyPayment(_StudentId);
                        }

                    }
                    else {
                        Q.alert("Invalid Student");
                    }
                }, { async: false })
        }

        public CourePayment(_StudentId) {
            PaymentInfoTblService.CoursePaymentDetailsInfo({ StudentId: +_StudentId },
                response => {
                    if (response.Entity) {
                        this.form.CoursePaid.value = response.Entity.Amount;
                        this.form.LastPaidDate.value = response.Entity.Payment_Date;
                    } else {
                        this.form.CoursePaid.value = 0;
                        this.form.LastPaidDate.value = null;
                    }
                },{ async:false });
        }

        public MonthlyPayment(_StudentId) {
            PaymentInfoTblService.MonthlyPaymentDetailsInfo({ StudentId: +_StudentId },
                response => {
                    if (response.Entity) {
                        this.form.MonthlyPaid.value = String( response.Entity.Amount);
                        this.form.LastPaidDate.value = response.Entity.Payment_Date;
                    }
                    else {
                        this.form.MonthlyPaid.value =  null;
                        this.form.LastPaidDate.value =  null;
                    }
                },{ async:false });
        }

        public CourseShow(_status) {
            q.showField(this.form.Coursefee, _status);
            q.showField(this.form.CoursePaid, _status);
        }
        public MonthlyShow(_status) {
            q.showField(this.form.MonthlyFee, _status);
            q.showField(this.form.MonthlyPaid, _status);
        }

        public BlankField() {
            this.form.CollegeName.value = null;
            this.form.AdmissionType.value = null;
            this.form.LastPaidDate.value = null;
            this.form.MonthlyFee.value = null;
            this.form.MonthlyPaid.value = null;
            this.form.Coursefee.value = null;
            this.form.CoursePaid.value = null;

        }
    }
}