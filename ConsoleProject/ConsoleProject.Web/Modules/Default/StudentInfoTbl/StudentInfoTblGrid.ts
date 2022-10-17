
namespace ConsoleProject.Default {
    import fld = StudentInfoTblRow.Fields;
    @Serenity.Decorators.registerClass()
    export class StudentInfoTblGrid extends _Ext.GridBase<StudentInfoTblRow, any> {
        protected getColumnsKey() { return 'Default.StudentInfoTbl'; }
        protected getDialogType() { return StudentInfoTblDialog; }
        protected getIdProperty() { return StudentInfoTblRow.idProperty; }
        protected getLocalTextPrefix() { return StudentInfoTblRow.localTextPrefix; }
        protected getService() { return StudentInfoTblService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
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
                        reportKey: 'Default.StudentInfoDetails',
                        params: {
                            StudentId: item.StudentId
                        }
                    });
                }
            }
        }

    }
}