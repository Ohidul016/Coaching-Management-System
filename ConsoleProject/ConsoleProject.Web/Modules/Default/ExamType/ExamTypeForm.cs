
namespace ConsoleProject.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.ExamType")]
    [BasedOnRow(typeof(Entities.ExamTypeRow), CheckNames = true)]
    public class ExamTypeForm
    {
        public String ExamName { get; set; }
    }
}