namespace ConsoleProject.Default {
    export interface BatchTblForm {
        BatchName: Serenity.StringEditor;
        BatchTime: Serenity.StringEditor;
        BatchDays: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
    }

    export class BatchTblForm extends Serenity.PrefixedContext {
        static formKey = 'Default.BatchTbl';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BatchTblForm.init)  {
                BatchTblForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.BooleanEditor;

                Q.initFormType(BatchTblForm, [
                    'BatchName', w0,
                    'BatchTime', w0,
                    'BatchDays', w0,
                    'IsActive', w1
                ]);
            }
        }
    }
}

