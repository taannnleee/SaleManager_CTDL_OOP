using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class Product
    {
        private string id;
        private string name;
        private int quatity;
        private Time startedusingday;
        private Time expiresdate;
        private int price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Quatity { get => quatity; set => quatity = value; }
        public Time Startedusingday { get => startedusingday; set => startedusingday = value; }
        public Time Expiresdate { get => expiresdate; set => expiresdate = value; }
        public int Price { get => price; set => price = value; }

        public Product()
        {
            this.Startedusingday = new Time();
            this.Expiresdate = new Time();
        }

        public Product(string id, string name, int quatity, Time startedusingday, Time expiresday, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Quatity = quatity;
            this.Startedusingday = startedusingday;
            this.Expiresdate = expiresday;
            this.Price = price;
        }

        public void nhap()
        {
            Console.WriteLine("ID:");
            this.Id =Console.ReadLine();
            Console.WriteLine("Ten:");
            this.Name = Console.ReadLine();
            Console.WriteLine("So Luong:");
            this.Quatity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ngay Nhap Hang:");
            Console.Write("Ngay: ");
            this.Startedusingday.Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thang: ");
            this.Startedusingday.Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nam: ");
            this.Startedusingday.Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gio: ");
            this.Startedusingday.Hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phut: ");
            this.Startedusingday.Minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Giay: ");
            this.Startedusingday.Second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ngay Het Han");
            Console.Write("Ngay: ");
            this.Expiresdate.Day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thang: ");
            this.Expiresdate.Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nam: ");
            this.Expiresdate.Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gio: ");
            this.Expiresdate.Hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phut: ");
            this.Expiresdate.Minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Giay: ");
            this.Expiresdate.Second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gia Tien");
            this.Price = Convert.ToInt32(Console.ReadLine());
        }


        public void xuat()
        {
                Console.WriteLine("|{0, -8}|{1, -25}|{2, -16}|{3, -20}|{4, -20}|{5,8}|",
                       "ID ", "Name", "NumberOfProduct", "DayStartedUsing", "DateExpires", "Price");

                Console.WriteLine("|{0, -8}|{1, -25}|{2, -16}|{3, -20}|{4, -20}|{5,8}|",
                    this.Id,
                    this.Name,
                    this.Quatity,
                    this.Startedusingday.getTime(),
                    this.Expiresdate.getTime(),
                    this.Price
                    );
        }

        public bool IsEqual(Product sanpham)
        {
            if(sanpham.Id.Contains(this.Id)==true)
                return true;
            else
                return false;
        }
        public bool IsEqualProduct(Product sanpham)
        {
            if ((this.Id.Equals(sanpham.Id) || this.Id.SequenceEqual(sanpham.Id)) &&
                    (this.Name.Equals(sanpham.Name) || this.Name.SequenceEqual(sanpham.Name)))
                return true;
            return false;
        }



    }
}
