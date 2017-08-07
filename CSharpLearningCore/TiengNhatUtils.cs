using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearningCore
{
    static public class TiengNhatUtils
    {
        public static string ThuTrongTuan(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "月";
                case DayOfWeek.Tuesday:
                    return "火";
                case DayOfWeek.Wednesday:
                    return "水";
                case DayOfWeek.Thursday:
                    return "木";
                case DayOfWeek.Friday:
                    return "金";
                case DayOfWeek.Saturday:
                    return "土";
                case DayOfWeek.Sunday:
                    return "日";
                default:
                    return String.Empty;
            }
        }
    }
}
