using System;
using System.Collections.Generic;
using System.Text;

namespace HuongThaoCore
{
    public static class HTJapanese
    {
        public static string DayOfWeek(DateTime dateTime)
        {
            switch (dateTime.DayOfWeek)
            {
                case System.DayOfWeek.Monday:
                    return "月";
                case System.DayOfWeek.Tuesday:
                    return "火";
                case System.DayOfWeek.Wednesday:
                    return "水";
                case System.DayOfWeek.Thursday:
                    return "木";
                case System.DayOfWeek.Friday:
                    return "金";
                case System.DayOfWeek.Saturday:
                    return "土";
                case System.DayOfWeek.Sunday:
                    return "日";
                default:
                    return string.Empty;
            }
        }
    }
}
