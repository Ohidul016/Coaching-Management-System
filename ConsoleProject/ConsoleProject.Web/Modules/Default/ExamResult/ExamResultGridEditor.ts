namespace ConsoleProject.Default {
    import fld = ExamResultRow.Fields;
    @Serenity.Decorators.registerClass()
    export class ExamResultGridEditor extends _Ext.GridEditorBase<ExamResultRow> {
        protected getColumnsKey() { return 'Default.ExamResult2'; }
        protected getLocalTextPrefix() { return ExamResultRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
        protected get_ExtGridOptions() {
            let opt = Q.deepClone(super.get_ExtGridOptions());
            opt.ShowEditInlineButtun = false;
            return opt;
        }

        protected getButtons(): Serenity.ToolButton[] {

            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
            return buttons;
        }


    }
}