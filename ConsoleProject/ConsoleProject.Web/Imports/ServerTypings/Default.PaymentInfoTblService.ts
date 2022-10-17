namespace ConsoleProject.Default {
    export namespace PaymentInfoTblService {
        export const baseUrl = 'Default/PaymentInfoTbl';

        export declare function Create(request: Serenity.SaveRequest<PaymentInfoTblRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PaymentInfoTblRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PaymentInfoTblRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PaymentInfoTblRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function StudentDetailsInfo(request: Default.Repositories.PaymentRequest, onSuccess?: (response: Serenity.RetrieveResponse<Default.Repositories.StudentInfoList>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function PaymentDetailsInfo(request: Default.Repositories.PaymentRequest, onSuccess?: (response: Serenity.ListResponse<Default.Repositories.PaymentListAll>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function CoursePaymentDetailsInfo(request: Default.Repositories.PaymentRequest, onSuccess?: (response: Serenity.RetrieveResponse<Default.Repositories.PaymentListAll>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function MonthlyPaymentDetailsInfo(request: Default.Repositories.PaymentRequest, onSuccess?: (response: Serenity.RetrieveResponse<Default.Repositories.PaymentListAll>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Default/PaymentInfoTbl/Create",
            Update = "Default/PaymentInfoTbl/Update",
            Delete = "Default/PaymentInfoTbl/Delete",
            Retrieve = "Default/PaymentInfoTbl/Retrieve",
            List = "Default/PaymentInfoTbl/List",
            StudentDetailsInfo = "Default/PaymentInfoTbl/StudentDetailsInfo",
            PaymentDetailsInfo = "Default/PaymentInfoTbl/PaymentDetailsInfo",
            CoursePaymentDetailsInfo = "Default/PaymentInfoTbl/CoursePaymentDetailsInfo",
            MonthlyPaymentDetailsInfo = "Default/PaymentInfoTbl/MonthlyPaymentDetailsInfo"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'StudentDetailsInfo', 
            'PaymentDetailsInfo', 
            'CoursePaymentDetailsInfo', 
            'MonthlyPaymentDetailsInfo'
        ].forEach(x => {
            (<any>PaymentInfoTblService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}

