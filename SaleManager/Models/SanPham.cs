using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models
{
    public class SanPham
    {
        private string nID;
        private string nTensp;
        private int iSoluong;
        private ThoiGian tNgaynhap;
        private ThoiGian tNgayhethan;
        private int iGiatien;

        public string ID
        {
            get { return nID; }
            set { nID = value; }
        }

        public string Tensp
        {
            get { return nTensp; }
            set { nTensp = value; }
        }

        public int Soluong
        {
            get { return iSoluong; }
            set { iSoluong = value; }
        }

        public ThoiGian Ngaynhap
        {
            get { return tNgaynhap; }
            set { tNgaynhap = value; }
        }

        public ThoiGian Ngayhethan
        {
            get { return tNgayhethan; }
            set { tNgayhethan = value; }
        }

        public int GiaTien
        {
            get { return iGiatien; }
            set { iGiatien = value; }
        }

        public SanPham()
        {
            this.Ngaynhap = new ThoiGian();
            this.Ngayhethan = new ThoiGian();
        }

        public SanPham(string ID, string Tensp, int Soluong, ThoiGian Ngaynhap, ThoiGian Ngayhethan, int Giatien)
        {
            this.ID = ID;
            this.Tensp = Tensp;
            this.Soluong = Soluong;
            this.Ngaynhap = Ngaynhap;
            this.Ngayhethan = Ngayhethan;
            this.GiaTien = Giatien;
        }

        public void nhap()
        {
            Console.WriteLine("ID:");
            this.ID =Console.ReadLine();
            Console.WriteLine("Ten:");
            this.Tensp = Console.ReadLine();
            Console.WriteLine("So Luong:");
            this.Soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ngay Nhap Hang:");
            Console.Write("Ngay: ");
            this.Ngaynhap.Ngay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thang: ");
            this.Ngaynhap.Thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nam: ");
            this.Ngaynhap.Nam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gio: ");
            this.Ngaynhap.Gio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phut: ");
            this.Ngaynhap.Phut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Giay: ");
            this.Ngaynhap.Giay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ngay Het Han");
            Console.Write("Ngay: ");
            this.Ngayhethan.Ngay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thang: ");
            this.Ngayhethan.Thang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nam: ");
            this.Ngayhethan.Nam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gio: ");
            this.Ngayhethan.Gio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phut: ");
            this.Ngayhethan.Phut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Giay: ");
            this.Ngayhethan.Giay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gia Tien");
            this.GiaTien = Convert.ToInt32(Console.ReadLine());
        }


        public void xuat()
        {
                Console.WriteLine("|{0, -8}|{1, -25}|{2, -16}|{3, -20}|{4, -20}|{5,8}|",
                       "ID ", "Name", "NumberOfProduct", "DayStartedUsing", "DateExpires", "Price");

                Console.WriteLine("|{0, -8}|{1, -25}|{2, -16}|{3, -20}|{4, -20}|{5,8}|",
                    this.ID,
                    this.Tensp,
                    this.Soluong,
                    this.Ngaynhap.layThoiGian(),
                    this.Ngayhethan.layThoiGian(),
                    this.GiaTien
                    );
        }

        public bool IsEqual(SanPham sanpham)
        {
            if(sanpham.nID.Contains(this.nID)==true)
                return true;
            else
                return false;
        }
        public bool IsEqualProduct(SanPham sanpham)
        {
            if ((this.nID.Equals(sanpham.nID) || this.nID.SequenceEqual(sanpham.nID)) &&
                    (this.nTensp.Equals(sanpham.nTensp) || this.nTensp.SequenceEqual(sanpham.nTensp)))
                return true;
            return false;
        }



    }
}
