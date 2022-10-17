using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleProject.Default
{
    public partial class ExamResultGridEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "ConsoleProject.Default.ExamResultGridEditor";

        public ExamResultGridEditorAttribute()
            : base(Key)
        {
        }
    }
}

