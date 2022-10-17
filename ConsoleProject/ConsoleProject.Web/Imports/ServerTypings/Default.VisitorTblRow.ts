namespace ConsoleProject.Default {
    export interface VisitorTblRow {
        VisitorId?: number;
        Name?: string;
        CollegeName?: string;
        CollegeBatch?: string;
        FatherName?: string;
        MotherName?: string;
        PersonalContact?: string;
        ParentsContact?: string;
        Address?: string;
        VisitDate?: string;
        Notes?: string;
        Email?: string;
    }

    export namespace VisitorTblRow {
        export const idProperty = 'VisitorId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Default.VisitorTbl';

        export declare const enum Fields {
            VisitorId = "VisitorId",
            Name = "Name",
            CollegeName = "CollegeName",
            CollegeBatch = "CollegeBatch",
            FatherName = "FatherName",
            MotherName = "MotherName",
            PersonalContact = "PersonalContact",
            ParentsContact = "ParentsContact",
            Address = "Address",
            VisitDate = "VisitDate",
            Notes = "Notes",
            Email = "Email"
        }
    }
}

