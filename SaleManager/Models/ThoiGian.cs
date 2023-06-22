using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Utilities;

namespace SaleManager.Models
{
    public class ThoiGian
    {
        private int iNgay;
        private int iThang;
        private int iNam;
        private int iGio;
        private int iPhut;
        private int iGiay;

        public int Ngay
        {
            get { return iNgay; }
            set {
                if (CheckTime.CheckNgay(Nam, Thang, value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be true");
                iNgay = value; }
        }


        public int Thang
        {
            get { return iThang; }
            set {
                if (CheckTime.CheckThang(value) == 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 1 and 12.");
                iThang = value; }
        }

        public int Nam
        {
            get { return iNam; }
            set {
                if (CheckTime.CheckNam(value) == 0)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be more than 0.");
                iNam = value; }
        }

        public int Gio
        {
            get { return iGio; }
            set {
                if(CheckTime.CheckGio(value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 23.");
                iGio = value; }
        }

        public int Phut
        {
            get { return iPhut; }
            set {
                if (CheckTime.CheckPhut(value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 59.");
                iPhut = value; }
        }

        public int Giay
        {
            set {
                if (CheckTime.CheckGiay(value) == 0) throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 59.");
                iGiay = value; }
            get { return iGiay; }
        }
        public ThoiGian()
        {

        }

        public ThoiGian(int Ngay, int Thang, int Nam)
        {
            this.Ngay = Ngay;
            this.Thang = Thang;
            this.Nam = Nam;
        }

        public ThoiGian(int Ngay, int Thang, int Nam, int Gio, int Phut, int Giay)
        {
            this.Ngay = Ngay;
            this.Thang = Thang;
            this.Nam = Nam;
            this.Gio = Gio;
            this.Phut = Phut;
            this.Giay = Giay;
        }

        ~ThoiGian()
        {

        }
        
        public void nhap()
        {
            Console.WriteLine("Ngay:");
            this.Ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thang:");
            this.Thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nam:");
            this.Nam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gio:");
            this.Gio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phut:");
            this.Phut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Giay:");
            this.Giay = Convert.ToInt32(Console.ReadLine());
            
        }

        public void xuat()
        {
            Console.WriteLine("Day:" + this.iNgay);
            Console.WriteLine("Thang:" + this.iThang);
            Console.WriteLine("Nam:" + this.iNam);
            Console.WriteLine("Gio:" + this.iGio);
            Console.WriteLine("Phut:" + this.iPhut);
            Console.WriteLine("Giay:" + this.iGiay);

        }

        public static implicit operator string(ThoiGian date)
        {
            string temp = "";
            int ngay = date.Ngay;
            int thang = date.Thang;
            int nam = date.Nam;
            if (ngay < 10)
                temp += '0' + ngay;
            else
                temp += ngay;
            temp += "-";
            if (thang < 10)
                temp += '0' + thang;
            else
                temp += thang;
            temp += "-";
            temp += nam;
            return temp;
        }

        public static bool operator >(ThoiGian a, ThoiGian b)
        {
            if (a.Nam > b.Nam) return true;
            if (a.Nam < b.Nam) return false;
            if (a.Thang > b.Thang) return true;
            if (a.Thang < b.Thang) return false;
            if (a.Ngay > b.Ngay) return true;
            if (a.Ngay < b.Ngay) return false;
            if (a.Gio > b.Gio) return true;
            if (b.Gio < b.Gio) return false;
            if (a.Phut > b.Phut) return true;
            if (a.Phut < b.Phut) return false;
            if (a.Giay > b.Giay) return true;
            if (a.Giay < b.Giay) return false;
            return false;
        }

        public static bool operator <(ThoiGian a, ThoiGian b)
        {
            if (a.Nam < b.Nam) return true;
            if (a.Nam > b.Nam) return false;
            if (a.Thang < b.Thang) return true;
            if (a.Thang > b.Thang) return false;
            if (a.Ngay < b.Ngay) return true;
            if (a.Ngay > b.Ngay) return false;
            if (a.Gio < b.Gio) return true;
            if (b.Gio > b.Gio) return false;
            if (a.Phut < b.Phut) return true;
            if (a.Phut > b.Phut) return false;
            if (a.Giay < b.Giay) return true;
            if (a.Giay > b.Giay) return false;
            return false;
        }

        public string layThoiGian()
        {
            int ngay = iNgay, thang = iThang, nam = iNam;
            int gio = iGio, phut = iPhut, giay = iGiay;
            string dateTime = "";
            if (ngay < 10)
                dateTime += "0" + ngay;
            else
                dateTime += ngay;
            dateTime += "/";
            if (thang < 10)
                dateTime += "0" + thang;
            else
                dateTime += thang;
            dateTime += "/";
            dateTime += nam;
            dateTime += " ";
            if (gio < 10)
                dateTime += "0" + gio;
            else
                dateTime += gio;
            dateTime += ":";
            if (phut < 10)
                dateTime += "0" + phut;
            else
                dateTime += phut;
            dateTime += ":";
            if (giay < 10)
                dateTime += "0" + giay;
            else
                dateTime += giay;
            return dateTime;
        }

        public static bool operator <=(ThoiGian a, ThoiGian b)
        {
            return !(a > b);
        }

        public static bool operator >=(ThoiGian a, ThoiGian b)
        {
            return !(a < b);
        }

        public static bool operator ==(ThoiGian a, ThoiGian b)
        {
            if (a.Ngay == b.Ngay && a.Thang == b.Thang && a.Nam == b.Nam)
                return true;
            return false;
        }

        public static bool operator !=(ThoiGian a, ThoiGian b)
        {
            if (a.Ngay != b.Ngay && a.Thang != b.Thang && a.Nam != b.Nam)
                return true;
            return false;
        }
        public static ThoiGian NgayHienTai()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            DateTime dateTimeOfDay = DateTime.Now;
            return new ThoiGian(
                dateTime.Day,
                dateTime.Month,
                dateTime.Year,
                dateTimeOfDay.Hour,
                dateTimeOfDay.Minute,
                dateTimeOfDay.Second);
        }
    }
}
