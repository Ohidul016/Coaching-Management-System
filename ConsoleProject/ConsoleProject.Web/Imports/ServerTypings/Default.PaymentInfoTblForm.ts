namespace ConsoleProject.Default {
    export interface PaymentInfoTblForm {
        StudentId: Serenity.LookupEditor;
        Roll: Serenity.IntegerEditor;
        CollegeName: Serenity.StringEditor;
        AdmissionType: Serenity.StringEditor;
        Coursefee: Serenity.DecimalEditor;
        CoursePaid: Serenity.DecimalEditor;
        CourseDuration: Serenity.StringEditor;
        MonthlyFee: Serenity.DecimalEditor;
        MonthlyPaid: Serenity.StringEditor;
        LastPaidDate: Serenity.DateEditor;
        Description: Serenity.StringEditor;
        PaymentDate: Serenity.DateEditor;
        Amount: Serenity.DecimalEditor;
        EntryDate: Serenity.DateEditor;
        EntryUser: Serenity.StringEditor;
    }

    export class PaymentInfoTblForm extends Serenity.PrefixedContext {
        static formKey = 'Default.PaymentInfoTbl';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PaymentInfoTblForm.init)  {
                PaymentInfoTblForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.StringEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.DateEditor;

                Q.initFormType(PaymentInfoTblForm, [
                    'StudentId', w0,
                    'Roll', w1,
                    'CollegeName', w2,
                    'AdmissionType', w2,
                    'Coursefee', w3,
                    'CoursePaid', w3,
                    'CourseDuration', w2,
                    'MonthlyFee', w3,
                    'MonthlyPaid', w2,
                    'LastPaidDate', w4,
                    'Description', w2,
                    'PaymentDate', w4,
                    'Amount', w3,
                    'EntryDate', w4,
                    'EntryUser', w2
                ]);
            }
        }
    }
}

