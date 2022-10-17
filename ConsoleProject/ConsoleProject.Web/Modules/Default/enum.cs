using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ConsoleProject.Default.EnumList 
{

    [EnumKey("AdmissionType"), ScriptInclude]
    public enum AdmissionType 
    {
        Course = 1,
        Monthly = 2,
    }

    [EnumKey("Active"), ScriptInclude]
    public enum Active
    {
        Running = 1, 
        [Description("Not Running")]
        Left = 0, 
    }

    [EnumKey("Gender"), ScriptInclude]
    public enum Gender
    {
        Male = 1,
        Female = 0,
    }

    [EnumKey("Department"), ScriptInclude]
    public enum Department
    {
        Science  = 1,
        Commerce = 2, 
        Arts = 3,  
    }

    [EnumKey("BatchTime"), ScriptInclude] 
    public enum BatchTime
    {
        [Description("06.00 - 07.00 AM")]
        time1 =1,    
        
        [Description("07.00 - 08.00 AM")]
        time2 =2,
        
        [Description("08.00 - 09.00 AM")]
        time3 = 3,

        [Description("10.00 - 11.00 AM")]
        time4 = 4,

        [Description("11.00 - 12.00 AM")]
        time5 = 5,

        [Description("12.00 - 01.00 PM")]
        time6 = 6,

        [Description("01.00 - 02.00 PM")]
        time7 = 7,

        [Description("02.00 - 03.00 PM")]
        time8 = 8,

        [Description("04.00 - 05.00 PM")]
        time9 = 9,
        [Description("06.00 - 07.00 PM")]
        time10 = 10,
        [Description("08.00 - 09.00 PM")]
        time11 = 11,
        [Description("09.00 - 10.00 PM")]
        time12 = 12,
    }
}