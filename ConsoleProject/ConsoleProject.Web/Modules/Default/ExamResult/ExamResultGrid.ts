
namespace ConsoleProject.Default {
    import fld = ExamResultRow.Fields;
    @Serenity.Decorators.registerClass()
    export class ExamResultGrid extends _Ext.GridBase<ExamResultRow, any> {
        protected getColumnsKey() { return 'Default.ExamResult'; }
        protected getDialogType() { return ExamResultDialog; }
        protected getIdProperty() { return ExamResultRow.idProperty; }
        protected getLocalTextPrefix() { return ExamResultRow.localTextPrefix; }
        protected getService() { return ExamResultService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected get_ExtGridOptions() {
            let opt = Q.deepClone(super.get_ExtGridOptions());
            opt.ShowEditInlineButtun = false;
            opt.ShowDeleteInlineButtun = false;
            return opt;
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
                        reportKey: 'Default.ExamResult',
                        params: {
                            ResultID: item.ResultId
                        }
                    });
                }
            }
        }

    }
}