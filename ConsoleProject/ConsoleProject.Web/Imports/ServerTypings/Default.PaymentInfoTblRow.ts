namespace ConsoleProject.Default {
    export interface PaymentInfoTblRow {
        PaymentId?: number;
        StudentId?: number;
        PaymentDate?: string;
        Amount?: number;
        EntryDate?: string;
        EntryUser?: string;
        StudentName?: string;
        StudentGender?: boolean;
        StudentCollegeName?: string;
        StudentCollegeBatch?: string;
        StudentFatherName?: string;
        StudentMotherName?: string;
        StudentAddress?: string;
        StudentDescription?: string;
        StudentUserImage?: string;
        StudentAdmissionDate?: string;
        StudentAdmissionType?: number;
        StudentCourseTotalFee?: number;
        StudentCourseDuration?: number;
        StudentMonthlyFee?: number;
        StudentLeftDate?: string;
        StudentEntryDate?: string;
        StudentEntryUser?: string;
        StudentIsActive?: number;
    }

    export namespace PaymentInfoTblRow {
        export const idProperty = 'PaymentId';
        export const nameProperty = 'EntryUser';
        export const localTextPrefix = 'Default.PaymentInfoTbl';
        export const lookupKey = 'Default.PaymentInfoTbl';

        export function getLookup(): Q.Lookup<PaymentInfoTblRow> {
            return Q.getLookup<PaymentInfoTblRow>('Default.PaymentInfoTbl');
        }

        export declare const enum Fields {
            PaymentId = "PaymentId",
            StudentId = "StudentId",
            PaymentDate = "PaymentDate",
            Amount = "Amount",
            EntryDate = "EntryDate",
            EntryUser = "EntryUser",
            StudentName = "StudentName",
            StudentGender = "StudentGender",
            StudentCollegeName = "StudentCollegeName",
            StudentCollegeBatch = "StudentCollegeBatch",
            StudentFatherName = "StudentFatherName",
            StudentMotherName = "StudentMotherName",
            StudentAddress = "StudentAddress",
            StudentDescription = "StudentDescription",
            StudentUserImage = "StudentUserImage",
            StudentAdmissionDate = "StudentAdmissionDate",
            StudentAdmissionType = "StudentAdmissionType",
            StudentCourseTotalFee = "StudentCourseTotalFee",
            StudentCourseDuration = "StudentCourseDuration",
            StudentMonthlyFee = "StudentMonthlyFee",
            StudentLeftDate = "StudentLeftDate",
            StudentEntryDate = "StudentEntryDate",
            StudentEntryUser = "StudentEntryUser",
            StudentIsActive = "StudentIsActive"
        }
    }
}

