using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models.Base;

namespace SaleManager.Models
{
    public class BanHang : Nguoi
    {
        //files
        private int iLuong;
        private LinkedList<string> lDonHang;
       
        //properties
        public LinkedList<string> DonHang
        {
            get => lDonHang;
            set => lDonHang = value;
        }
        public int Luong
        {
            get => iLuong;
            set => iLuong = value;
        }
        // Constucter
        public BanHang() : base()
        {
            this.DonHang = new LinkedList<string>();
        }
       
        public BanHang(string id, string Ten, string GioiTinh,
            ThoiGian NgaySinh, string DiaChi, string SoDienThoai,
            int Luong, LinkedList<string> DonHang) : base(id, Ten, GioiTinh, NgaySinh, DiaChi, SoDienThoai)
        {
            this.Luong = Luong;
            this.DonHang = DonHang;
        }

        public BanHang(string id, string Ten, string GioiTinh,
            ThoiGian NgaySinh, string DiaChi, string SoDienThoai,
            int Luong) : base(id, Ten, GioiTinh, NgaySinh, DiaChi, SoDienThoai)
        {
            this.Luong = Luong;
        }
        public BanHang(int Luong, LinkedList<string> DonHang)
        {
            this.Luong = Luong;
            this.DonHang = DonHang;
        }

        // Destruction
        ~BanHang() { }

        // Method
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Luong: ");
            this.Luong = Convert.ToInt32(Console.ReadLine());
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Luong: " + this.iLuong);
        }

        public override bool IsEquals(Nguoi nguoi)
        {
            if (this.ID == nguoi.ID)
                return true;
            return false;
        }
        
    }
}
