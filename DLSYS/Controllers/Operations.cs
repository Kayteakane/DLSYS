using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace DLSYS.Functions
{
    public class Operations
    {
        public static int getWeek()
        {
            int week_num = 0;
            try
            {
                DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                DateTime date1 = new DateTime(2011, 1, 1);
                Calendar cal = dfi.Calendar;

                Console.WriteLine("{0:d}: Week {1} ({2})", date1,
                                  cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                                    dfi.FirstDayOfWeek),
                                  cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));
                week_num = cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                      dfi.FirstDayOfWeek);
            } catch(Exception e)
            {
              //  e.
            }
            return week_num;
        }
    }
}