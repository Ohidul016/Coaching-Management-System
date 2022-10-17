namespace ConsoleProject.Default {
    export interface StudentInfoTblForm {
        Name: Serenity.StringEditor;
        GenderType: Serenity.EnumEditor;
        Gender: Serenity.BooleanEditor;
        CollegeName: Serenity.StringEditor;
        CollegeBatch: Serenity.StringEditor;
        FatherName: Serenity.StringEditor;
        MotherName: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        MotherPhone: Serenity.StringEditor;
        FatherPhone: Serenity.StringEditor;
        PersonalPhone: Serenity.StringEditor;
        StudentDepartment: Serenity.StringEditor;
        UserImage: Serenity.ImageUploadEditor;
        EntryDate: Serenity.DateEditor;
        AdmissionDate: Serenity.DateEditor;
        BatchId: Serenity.LookupEditor;
        AdmissionType: Serenity.EnumEditor;
        CourseTotalFee: Serenity.DecimalEditor;
        CourseDuration: Serenity.DecimalEditor;
        MonthlyFee: Serenity.DecimalEditor;
        EntryUser: Serenity.StringEditor;
        IsActive: Serenity.BooleanEditor;
        StudentStatus: Serenity.EnumEditor;
        LeftDate: Serenity.DateEditor;
    }

    export class StudentInfoTblForm extends Serenity.PrefixedContext {
        static formKey = 'Default.StudentInfoTbl';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StudentInfoTblForm.init)  {
                StudentInfoTblForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EnumEditor;
                var w2 = s.BooleanEditor;
                var w3 = s.TextAreaEditor;
                var w4 = s.ImageUploadEditor;
                var w5 = s.DateEditor;
                var w6 = s.LookupEditor;
                var w7 = s.DecimalEditor;

                Q.initFormType(StudentInfoTblForm, [
                    'Name', w0,
                    'GenderType', w1,
                    'Gender', w2,
                    'CollegeName', w0,
                    'CollegeBatch', w0,
                    'FatherName', w0,
                    'MotherName', w0,
                    'Address', w0,
                    'Description', w3,
                    'MotherPhone', w0,
                    'FatherPhone', w0,
                    'PersonalPhone', w0,
                    'StudentDepartment', w0,
                    'UserImage', w4,
                    'EntryDate', w5,
                    'AdmissionDate', w5,
                    'BatchId', w6,
                    'AdmissionType', w1,
                    'CourseTotalFee', w7,
                    'CourseDuration', w7,
                    'MonthlyFee', w7,
                    'EntryUser', w0,
                    'IsActive', w2,
                    'StudentStatus', w1,
                    'LeftDate', w5
                ]);
            }
        }
    }
}

