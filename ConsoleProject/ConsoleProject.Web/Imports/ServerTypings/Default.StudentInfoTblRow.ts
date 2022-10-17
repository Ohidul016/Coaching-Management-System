namespace ConsoleProject.Default {
    export interface StudentInfoTblRow {
        StudentId?: number;
        Name?: string;
        Gender?: boolean;
        CollegeName?: string;
        CollegeBatch?: string;
        FatherName?: string;
        MotherName?: string;
        Address?: string;
        Description?: string;
        MotherPhone?: string;
        FatherPhone?: string;
        PersonalPhone?: string;
        UserImage?: string;
        BatchId?: number;
        AdmissionDate?: string;
        AdmissionType?: Default.EnumList.AdmissionType;
        CourseTotalFee?: number;
        CourseDuration?: number;
        MonthlyFee?: number;
        LeftDate?: string;
        EntryDate?: string;
        EntryUser?: string;
        IsActive?: boolean;
        StudentStatus?: Default.EnumList.Active;
        StudentName?: string;
        StudentGender?: boolean;
        StudentCollegeName?: string;
        StudentCollegeBatch?: string;
        StudentFatherName?: string;
        StudentMotherName?: string;
        StudentAddress?: string;
        StudentDescription?: string;
        StudentMotherPhone?: string;
        StudentFatherPhone?: string;
        StudentPersonalPhone?: string;
        StudentUserImage?: string;
        StudentBatchId?: number;
        StudentAdmissionDate?: string;
        StudentAdmissionType?: number;
        StudentCourseTotalFee?: number;
        StudentCourseDuration?: number;
        StudentMonthlyFee?: number;
        StudentLeftDate?: string;
        StudentEntryDate?: string;
        StudentEntryUser?: string;
        StudentIsActive?: boolean;
        BatchBatchName?: string;
        BatchBatchTime?: string;
        BatchBatchDays?: string;
        BatchIsActive?: boolean;
        LookupText?: string;
        StudentDepartment?: string;
    }

    export namespace StudentInfoTblRow {
        export const idProperty = 'StudentId';
        export const nameProperty = 'LookupText';
        export const localTextPrefix = 'Default.StudentInfoTbl';
        export const lookupKey = 'Default.StudentInfoTbl';

        export function getLookup(): Q.Lookup<StudentInfoTblRow> {
            return Q.getLookup<StudentInfoTblRow>('Default.StudentInfoTbl');
        }

        export declare const enum Fields {
            StudentId = "StudentId",
            Name = "Name",
            Gender = "Gender",
            CollegeName = "CollegeName",
            CollegeBatch = "CollegeBatch",
            FatherName = "FatherName",
            MotherName = "MotherName",
            Address = "Address",
            Description = "Description",
            MotherPhone = "MotherPhone",
            FatherPhone = "FatherPhone",
            PersonalPhone = "PersonalPhone",
            UserImage = "UserImage",
            BatchId = "BatchId",
            AdmissionDate = "AdmissionDate",
            AdmissionType = "AdmissionType",
            CourseTotalFee = "CourseTotalFee",
            CourseDuration = "CourseDuration",
            MonthlyFee = "MonthlyFee",
            LeftDate = "LeftDate",
            EntryDate = "EntryDate",
            EntryUser = "EntryUser",
            IsActive = "IsActive",
            StudentStatus = "StudentStatus",
            StudentName = "StudentName",
            StudentGender = "StudentGender",
            StudentCollegeName = "StudentCollegeName",
            StudentCollegeBatch = "StudentCollegeBatch",
            StudentFatherName = "StudentFatherName",
            StudentMotherName = "StudentMotherName",
            StudentAddress = "StudentAddress",
            StudentDescription = "StudentDescription",
            StudentMotherPhone = "StudentMotherPhone",
            StudentFatherPhone = "StudentFatherPhone",
            StudentPersonalPhone = "StudentPersonalPhone",
            StudentUserImage = "StudentUserImage",
            StudentBatchId = "StudentBatchId",
            StudentAdmissionDate = "StudentAdmissionDate",
            StudentAdmissionType = "StudentAdmissionType",
            StudentCourseTotalFee = "StudentCourseTotalFee",
            StudentCourseDuration = "StudentCourseDuration",
            StudentMonthlyFee = "StudentMonthlyFee",
            StudentLeftDate = "StudentLeftDate",
            StudentEntryDate = "StudentEntryDate",
            StudentEntryUser = "StudentEntryUser",
            StudentIsActive = "StudentIsActive",
            BatchBatchName = "BatchBatchName",
            BatchBatchTime = "BatchBatchTime",
            BatchBatchDays = "BatchBatchDays",
            BatchIsActive = "BatchIsActive",
            LookupText = "LookupText",
            StudentDepartment = "StudentDepartment"
        }
    }
}

