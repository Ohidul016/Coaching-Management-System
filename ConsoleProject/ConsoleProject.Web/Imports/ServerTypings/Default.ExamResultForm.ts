namespace ConsoleProject.Default {
    export interface ExamResultForm {
        BatchId: Serenity.LookupEditor;
        ExamDate: Serenity.DateEditor;
        ExamType: Serenity.LookupEditor;
        ChapterNo: Serenity.StringEditor;
        TotalMark: Serenity.DecimalEditor;
        HeightMark: Serenity.DecimalEditor;
        StudentId: Serenity.LookupEditor;
        ObatainedMark: Serenity.DecimalEditor;
        AddtoGrid: StaticTextBlock;
        ExamMark: ExamResultGridEditor;
    }

    export class ExamResultForm extends Serenity.PrefixedContext {
        static formKey = 'Default.ExamResult';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ExamResultForm.init)  {
                ExamResultForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = s.DecimalEditor;
                var w4 = StaticTextBlock;
                var w5 = ExamResultGridEditor;

                Q.initFormType(ExamResultForm, [
                    'BatchId', w0,
                    'ExamDate', w1,
                    'ExamType', w0,
                    'ChapterNo', w2,
                    'TotalMark', w3,
                    'HeightMark', w3,
                    'StudentId', w0,
                    'ObatainedMark', w3,
                    'AddtoGrid', w4,
                    'ExamMark', w5
                ]);
            }
        }
    }
}

