namespace ConsoleProject.Default {
    export interface ExamResultRow {
        ResultId?: number;
        ExamDate?: string;
        StudentId?: number;
        BatchId?: number;
        ExamType?: number;
        ChapterNo?: string;
        TotalMark?: number;
        ObatainedMark?: number;
        HeightMark?: number;
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
        StudentBatchTime?: string;
        StudentAdmissionDate?: string;
        StudentAdmissionType?: number;
        StudentCourseTotalFee?: number;
        StudentDays?: string;
        StudentCourseDuration?: number;
        StudentMonthlyFee?: number;
        StudentLeftDate?: string;
        StudentEntryDate?: string;
        StudentEntryUser?: string;
        StudentIsActive?: number;
        ExamTypeExamName?: string;
        ExamMark?: ExamResultRow[];
        BatchBatchName?: string;
        BatchBatchTime?: string;
        BatchBatchDays?: string;
    }

    export namespace ExamResultRow {
        export const idProperty = 'ResultId';
        export const nameProperty = 'ChapterNo';
        export const localTextPrefix = 'Default.ExamResult';

        export declare const enum Fields {
            ResultId = "ResultId",
            ExamDate = "ExamDate",
            StudentId = "StudentId",
            BatchId = "BatchId",
            ExamType = "ExamType",
            ChapterNo = "ChapterNo",
            TotalMark = "TotalMark",
            ObatainedMark = "ObatainedMark",
            HeightMark = "HeightMark",
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
            StudentBatchTime = "StudentBatchTime",
            StudentAdmissionDate = "StudentAdmissionDate",
            StudentAdmissionType = "StudentAdmissionType",
            StudentCourseTotalFee = "StudentCourseTotalFee",
            StudentDays = "StudentDays",
            StudentCourseDuration = "StudentCourseDuration",
            StudentMonthlyFee = "StudentMonthlyFee",
            StudentLeftDate = "StudentLeftDate",
            StudentEntryDate = "StudentEntryDate",
            StudentEntryUser = "StudentEntryUser",
            StudentIsActive = "StudentIsActive",
            ExamTypeExamName = "ExamTypeExamName",
            ExamMark = "ExamMark",
            BatchBatchName = "BatchBatchName",
            BatchBatchTime = "BatchBatchTime",
            BatchBatchDays = "BatchBatchDays"
        }
    }
}

