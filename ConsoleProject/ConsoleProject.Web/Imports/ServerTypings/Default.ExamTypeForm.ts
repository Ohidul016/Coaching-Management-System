namespace ConsoleProject.Default {
    export interface ExamTypeForm {
        ExamName: Serenity.StringEditor;
    }

    export class ExamTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ExamType';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamTypeForm.init)  {
                ExamTypeForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ExamTypeForm, [
                    'ExamName', w0
                ]);
            }
        }
    }
}

