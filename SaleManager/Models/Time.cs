using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Utilities;

namespace SaleManager.Models
{
    public class Time
    {
        private int day;
        private int month;
        private int year;
        private int hour;
        private int minute;
        private int second;

        public int Day
        {
            get { return day; }
            set {
                if (CheckTime.CheckDay(Year, Month, value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be true");
                day = value; }
        }


        public int Month
        {
            get { return month; }
            set {
                if (CheckTime.CheckMonth(value) == 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1 and 12.");
                month = value; }
        }

        public int Year
        {
            get { return year; }
            set {
                if (CheckTime.CheckYear(value) == 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be more than 0.");
                year = value; }
        }

        public int Hour
        {
            get { return hour; }
            set {
                if(CheckTime.CheckHour(value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 23.");
                hour = value; }
        }

        public int Minute
        {
            get { return minute; }
            set {
                if (CheckTime.CheckMinute(value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 59.");
                minute = value; }
        }

        public int Second
        {
            set {
                if (CheckTime.CheckSecond(value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 59.");
                second = value; }
            get { return second; }
        }
        public Time()
        {

        }

        public Time(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public Time(int day, int month, int year, int hour, int minute, int second)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        ~Time()
        {

        }
        
        public void Input()
        {
            Console.WriteLine("Ngay:");
            this.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thang:");
            this.Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nam:");
            this.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gio:");
            this.Hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phut:");
            this.Minute = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Giay:");
            this.Second = Convert.ToInt32(Console.ReadLine());
            
        }

        public void Output()
        {
            Console.WriteLine("Day:" + this.day);
            Console.WriteLine("Thang:" + this.month);
            Console.WriteLine("Nam:" + this.year);
            Console.WriteLine("Gio:" + this.hour);
            Console.WriteLine("Phut:" + this.minute);
            Console.WriteLine("Giay:" + this.second);

        }

        public static implicit operator string(Time date)
        {
            string temp = "";
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;
            if (day < 10)
                temp += '0' + day;
            else
                temp += day;
            temp += "-";
            if (month < 10)
                temp += '0' + month;
            else
                temp += month;
            temp += "-";
            temp += year;
            return temp;
        }

        public static bool operator >(Time a, Time b)
        {
            if (a.Year > b.Year) return true;
            if (a.Year < b.Year) return false;
            if (a.Month > b.Month) return true;
            if (a.Month < b.Month) return false;
            if (a.Day > b.Day) return true;
            if (a.Day < b.Day) return false;
            if (a.Hour > b.Hour) return true;
            if (b.Hour < b.Hour) return false;
            if (a.Minute > b.Minute) return true;
            if (a.Minute < b.Minute) return false;
            if (a.Second > b.Second) return true;
            if (a.Second < b.Second) return false;
            return false;
        }

        public static bool operator <(Time a, Time b)
        {
            if (a.Year < b.Year) return true;
            if (a.Year > b.Year) return false;
            if (a.Month < b.Month) return true;
            if (a.Month > b.Month) return false;
            if (a.Day < b.Day) return true;
            if (a.Day > b.Day) return false;
            if (a.Hour < b.Hour) return true;
            if (b.Hour > b.Hour) return false;
            if (a.Minute < b.Minute) return true;
            if (a.Minute > b.Minute) return false;
            if (a.Second < b.Second) return true;
            if (a.Second > b.Second) return false;
            return false;
        }

        public string getTime()
        {
            int getday = day, getmonth = month, getyear = year;
            int gethour = hour, getminute = minute, getsecond = second;
            string dateTime = "";
            if (getday < 10)
                dateTime += "0" + getday;
            else
                dateTime += getday;
            dateTime += "/";
            if (getmonth < 10)
                dateTime += "0" + getmonth;
            else
                dateTime += getmonth;
            dateTime += "/";
            dateTime += getyear;
            dateTime += " ";
            if (gethour < 10)
                dateTime += "0" + gethour;
            else
                dateTime += gethour;
            dateTime += ":";
            if (getminute < 10)
                dateTime += "0" + getminute;
            else
                dateTime += getminute;
            dateTime += ":";
            if (getsecond < 10)
                dateTime += "0" + getsecond;
            else
                dateTime += getsecond;
            return dateTime;
        }

        public static bool operator <=(Time a, Time b)
        {
            return !(a > b);
        }

        public static bool operator >=(Time a, Time b)
        {
            return !(a < b);
        }

        public static bool operator ==(Time a, Time b)
        {
            if (a.Day == b.Day && a.Month == b.Month && a.Year == b.Year)
                return true;
            return false;
        }

        public static bool operator !=(Time a, Time b)
        {
            if (a.Day != b.Day && a.Month != b.Month && a.Year != b.Year)
                return true;
            return false;
        }
        public static Time CurrentDay()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime dateTimeOfDay = DateTime.Now;
            return new Time(
                dateTime.Day,
                dateTime.Month,
                dateTime.Year,
                dateTimeOfDay.Hour,
                dateTimeOfDay.Minute,
                dateTimeOfDay.Second);
        }
    }
}
