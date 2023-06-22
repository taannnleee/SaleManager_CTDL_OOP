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
        public static bool IsLeapYear(int nam)
        {
            if ((nam % 4 == 0) || ((nam % 100 == 0) && (nam % 400 == 0)))
                return true;
            return false;
        }

        public static int CheckNgay(int Nam, int Thang, int Ngay)
        {
            if (Ngay <= 0) return 0;
            else
            {
                if ((Thang == 2) && (Ngay > 29) && (IsLeapYear(Nam))) return 0;
                else
                {
                    if (Thang == 4 || Thang == 6 || Thang == 9 || Thang == 12 && Ngay > 30) return 0;
                    else if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 8 || Thang == 10 || Thang == 12 & Ngay > 31) return 0;

                }
            }
            return 1;
        }
        
        public static int CheckThang(int Thang)
        {
            if(Thang < 1 || Thang > 12)
                return 0;
            return 1;
        }
        public static int CheckNam( int Nam)
        {
            if (Nam < 0)
                return 0;
            return 1;
        }
        public static int CheckGio(int Gio)
        {
            if(Gio < 0 || Gio > 24)
                return 0;
            return 1;
        }
        public static int CheckPhut(int Phut)
        {
            if (Phut < 0 || Phut > 59)
                return 0;
            return 1;
        }
        public static int CheckGiay(int Giay)
        {
            if (Giay < 0 || Giay > 59)
                return 0;
            return 1;
        }
    }
}
