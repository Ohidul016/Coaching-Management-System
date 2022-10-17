namespace ConsoleProject.Default {
    export interface VisitorTblForm {
        Name: Serenity.StringEditor;
        CollegeName: Serenity.StringEditor;
        CollegeBatch: Serenity.StringEditor;
        FatherName: Serenity.StringEditor;
        MotherName: Serenity.StringEditor;
        PersonalContact: Serenity.StringEditor;
        ParentsContact: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        VisitDate: Serenity.DateEditor;
        Notes: Serenity.TextAreaEditor;
    }

    export class VisitorTblForm extends Serenity.PrefixedContext {
        static formKey = 'Default.VisitorTbl';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!VisitorTblForm.init)  {
                VisitorTblForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.TextAreaEditor;

                Q.initFormType(VisitorTblForm, [
                    'Name', w0,
                    'CollegeName', w0,
                    'CollegeBatch', w0,
                    'FatherName', w0,
                    'MotherName', w0,
                    'PersonalContact', w0,
                    'ParentsContact', w0,
                    'Address', w0,
                    'Email', w0,
                    'VisitDate', w1,
                    'Notes', w2
                ]);
            }
        }
    }
}

