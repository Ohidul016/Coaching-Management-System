
namespace ConsoleProject.Default {
    import fld = PaymentInfoTblRow.Fields;
    @Serenity.Decorators.registerClass()
    export class PaymentInfoTblGrid extends _Ext.GridBase<PaymentInfoTblRow, any> {
        protected getColumnsKey() { return 'Default.PaymentInfoTbl'; }
        protected getDialogType() { return PaymentInfoTblDialog; }
        protected getIdProperty() { return PaymentInfoTblRow.idProperty; }
        protected getLocalTextPrefix() { return PaymentInfoTblRow.localTextPrefix; }
        protected getService() { return PaymentInfoTblService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        //protected get_ExtGridOptions() {
        //    let opt = Q.deepClone(super.get_ExtGridOptions());
        //    opt.ShowEditInlineButtun = false;
        //    opt.ShowDeleteInlineButtun = false;
            
        //    return opt;
        //}

        protected getSlickOptions() {
            let opt = super.getSlickOptions();
            opt.showFooterRow = true;
            return opt;
        }
        protected usePager() {
            return false;
        }
   
        protected createSlickGrid() {
            var grid = super.createSlickGrid();

            // need to register this plugin for grouping or you'll have errors
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());

            this.view.setSummaryOptions({
                aggregators: [
                    new Slick.Aggregators.Sum(fld.Amount),
                ]
            });

            return grid;
        }


        protected getColumns() {
            var columns = super.getColumns();

            columns.splice(1, 0, {
                field: 'Print',
                name: '',
                format: ctx => '<a class="inline-action print-invoice" title="Print">' +
                    '<i class="fa fa-file-pdf-o text-red"></i></a>',
                width: 34,
                minWidth: 34,
                maxWidth: 34
            });

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row);
            var target = $(e.target);

            // if user clicks "i" element, e.g. icon
            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();

                if (target.hasClass('print-invoice')) {
                    ConsoleProject.Common.ReportHelper.execute({
                        reportKey: 'Default.PaymentDetailsReport',
                        params: {
                            PaymentId: item.PaymentId
                        }
                    });
                }
            }
        }

    }
}