using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Utilities
{
    public static class DateUtilities
    {
        public static int YearsBetweenDates(DateTime initialDate, DateTime finalDate)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime olddate = initialDate;//new DateTime(1947, 11, 15);
            //olddate.Dump();
            DateTime curdate = finalDate;    //DateTime.Now.ToLocalTime();
            //curdate.Dump();

            TimeSpan span = curdate - olddate;

            // because we start at year 1 for the Gregorian 
            // calendar, we must subtract a year here.

            int years = (zeroTime + span).Year - 1;
            int months = (zeroTime + span).Month - 1;
            int days = (zeroTime + span).Day;

            return years;
        }
        public static int MonthsBetweenDates(DateTime initialDate, DateTime finalDate)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime olddate = initialDate;//new DateTime(1947, 11, 15);
            //olddate.Dump();
            DateTime curdate = finalDate;    //DateTime.Now.ToLocalTime();
            //curdate.Dump();

            TimeSpan span = curdate - olddate;

            // because we start at year 1 for the Gregorian 
            // calendar, we must subtract a year here.

            int years = (zeroTime + span).Year - 1;
            int months = (zeroTime + span).Month - 1;
            int days = (zeroTime + span).Day;

            return months;
        }
    }
}
