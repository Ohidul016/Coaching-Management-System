namespace ConsoleProject.Default {
    export interface BatchTblRow {
        BatchId?: number;
        BatchName?: string;
        BatchTime?: string;
        BatchDays?: string;
        LookupText?: string;
        IsActive?: boolean;
    }

    export namespace BatchTblRow {
        export const idProperty = 'BatchId';
        export const nameProperty = 'LookupText';
        export const localTextPrefix = 'Default.BatchTbl';
        export const lookupKey = 'Default.BatchTbl';

        export function getLookup(): Q.Lookup<BatchTblRow> {
            return Q.getLookup<BatchTblRow>('Default.BatchTbl');
        }

        export declare const enum Fields {
            BatchId = "BatchId",
            BatchName = "BatchName",
            BatchTime = "BatchTime",
            BatchDays = "BatchDays",
            LookupText = "LookupText",
            IsActive = "IsActive"
        }
    }
}

