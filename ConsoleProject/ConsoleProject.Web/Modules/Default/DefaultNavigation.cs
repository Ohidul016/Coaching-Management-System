using Serenity.Navigation;
using MyPages = ConsoleProject.Default.Pages;

[assembly: NavigationMenu(int.MaxValue, "Student", icon: "fa fa-group")]
[assembly: NavigationLink(int.MaxValue, "Student/Student Information", typeof(MyPages.StudentInfoTblController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Student/Student Specific Information", typeof(MyPages.StudentInfoTblController), action: "StudentInfo", icon: null)]

[assembly: NavigationMenu(int.MaxValue, "Payment", icon: "fa fa-money")]
[assembly: NavigationLink(int.MaxValue, "Payment/Payment Information", typeof(MyPages.PaymentInfoTblController), icon: null)]

[assembly: NavigationMenu(int.MaxValue, "Exam", icon: "fa fa-snowflake-o")]
[assembly: NavigationLink(int.MaxValue, "Exam/Exam Result", typeof(MyPages.ExamResultController), icon: null)]

[assembly: NavigationMenu(int.MaxValue, "Visitor", icon: "fa fa-child")]
[assembly: NavigationLink(int.MaxValue, "Visitor/Visitor Information", typeof(MyPages.VisitorTblController), icon: null)]

[assembly: NavigationMenu(int.MaxValue, "Settings", icon: "fa fa-cogs")]
[assembly: NavigationLink(int.MaxValue, "Settings/Exam Type", typeof(MyPages.ExamTypeController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Batch Information", typeof(MyPages.BatchTblController), icon: null)]
