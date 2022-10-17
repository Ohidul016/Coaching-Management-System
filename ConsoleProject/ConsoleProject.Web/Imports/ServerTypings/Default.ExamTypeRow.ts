namespace ConsoleProject.Default {
    export interface ExamTypeRow {
        ExamId?: number;
        ExamName?: string;
    }

    export namespace ExamTypeRow {
        export const idProperty = 'ExamId';
        export const nameProperty = 'ExamName';
        export const localTextPrefix = 'Default.ExamType';
        export const lookupKey = 'Default.ExamType';

        export function getLookup(): Q.Lookup<ExamTypeRow> {
            return Q.getLookup<ExamTypeRow>('Default.ExamType');
        }

        export declare const enum Fields {
            ExamId = "ExamId",
            ExamName = "ExamName"
        }
    }
}

