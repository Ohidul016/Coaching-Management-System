
namespace ConsoleProject.Default {

    @Serenity.Decorators.registerClass()
    export class ExamResultDialog extends _Ext.DialogBase<ExamResultRow, any> {
        protected getFormKey() { return ExamResultForm.formKey; }
        protected getIdProperty() { return ExamResultRow.idProperty; }
        protected getLocalTextPrefix() { return ExamResultRow.localTextPrefix; }
        protected getNameProperty() { return ExamResultRow.nameProperty; }
        protected getService() { return ExamResultService.baseUrl; }

        protected form = new ExamResultForm(this.idPrefix);

        constructor() {
            super();
            this.InitForm();
            this.set_dialogTitle("Consolidated Funds");
            var fieldButton = $('.AddtoGrid')[0];

            fieldButton.innerHTML = `<label class="caption" title=""></label>
                <a href= "javascript:;" class="btn btn-success DetailAdd"> <i class="fa fa-fw fa-plus-circle"> </i>Add</a>`;

            $('.DetailAdd').click(e => this.addtoGrid());
       


        }
        public addtoGrid() {
            if (this.form.StudentId.value == null) {
                Q.notifyWarning("Please Select Student");
                return;
            }
            else if (this.form.StudentId.value == "") {
                Q.notifyWarning("Please select Student.");
                return;
            }
            else if (this.form.ObatainedMark.value == null) {
                Q.notifyWarning("Please Enter Obtained Mark");
                return;
            }
            else if (this.form.ObatainedMark.value < 0) {
                Q.notifyWarning("Please Enter Obtained Mark");
                return;
            }

            var _items = this.form.ExamMark.getItems();
            var VoucherSubLedger: ExamResultRow[];

            var _details: ExamResultRow;
            _details = {};

            _details.StudentId = +this.form.StudentId.value;
            _details.StudentName = this.form.StudentId.text;
            _details.ObatainedMark = this.form.ObatainedMark.value;
            var flag = 0;
            // Existing item check
            _items.forEach(item => {
                flag = 0;
                if (item.StudentId == Q.parseInteger(this.form.StudentId.value)) {
                    _details = {};
                    flag = 1;
                    Q.alert('Item already exists.');
                }

            });

            if (flag == 1) {
            }
            else {
                if (_details.StudentId != null && _details.ObatainedMark != null) {
                    _items.push(_details);
                    this.form.StudentId.value = null;
                    this.form.ObatainedMark.value = 0;
                }
            }
            this.form.ExamMark.value = _items;
        }

        public InitForm() {
            this.form.ExamType.changeSelect2(x => {
                this.form.ExamMark.value = null;
            });
        }

        protected updateInterface() {
            super.updateInterface();

            q.initDetailEditor(this, this.form.ExamMark, { hideToolbar: false });

            //this.applyChangesButton.hide();
        } 


    }
}