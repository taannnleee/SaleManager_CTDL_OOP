using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;

namespace SaleManager.Utilities
{
    public static class CheckTime
    {
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) || ((year % 100 == 0) && (year % 400 == 0)))
                return true;
            return false;
        }

        public static int CheckDay(int year, int month, int day)
        {
            if (day <= 0) return 0;
            else
            {
                if ((month == 2) && (day > 29) && (IsLeapYear(year))) return 0;
                else
                {
                    if (month == 4 || month == 6 || month == 9 || month == 12 && day > 30) return 0;
                    else if (month == 1 || month == 3 || month == 5 || month == 8 || month == 10 || month == 12 & day > 31) return 0;

                }
            }
            return 1;
        }
        
        public static int CheckMonth(int month)
        {
            if(month < 1 || month > 12)
                return 0;
            return 1;
        }
        public static int CheckYear( int year)
        {
            if (year < 0)
                return 0;
            return 1;
        }
        public static int CheckHour(int hour)
        {
            if(hour < 0 || hour > 24)
                return 0;
            return 1;
        }
        public static int CheckMinute(int minute)
        {
            if (minute < 0 || minute > 59)
                return 0;
            return 1;
        }
        public static int CheckSecond(int second)
        {
            if (second < 0 || second > 59)
                return 0;
            return 1;
        }
    }
}
