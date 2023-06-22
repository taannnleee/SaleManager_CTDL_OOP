using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaleManager.Models.Base
{
    public abstract class Nguoi
    {
        //files
        protected string nID;
        protected string nTen;
        protected string nGioiTinh;
        protected ThoiGian tNgaySinh;
        protected string nDiaChi;
        protected string nSoDienThoai;
        // Constructor
        public Nguoi()
        {
            this.NgaySinh = new ThoiGian();
        }
        public Nguoi(string ID, string Ten, string GioiTinh
            , ThoiGian NgaySinh, string DiaChi, string SoDienThoai)
        {
            this.ID = ID;
            this.Ten = Ten;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.NgaySinh = NgaySinh;
            this.SoDienThoai = SoDienThoai;
        }
        // Destructor
        ~Nguoi()
        {     
        }

        //Properties
        public string ID
        {
            get { return nID; }
            set { nID = value; }
        }
        public string Ten
        {
            get { return nTen; }
            set { nTen = value; }
        }
        public string GioiTinh
        {
            get { return nGioiTinh; }
            set { nGioiTinh = value; }
        }
        public string DiaChi
        {
            get { return nDiaChi; }
            set { nDiaChi = value; }
        }
        public ThoiGian NgaySinh
        {
            get { return tNgaySinh; }
            set { tNgaySinh = value; }
        }
        public string SoDienThoai
        {
            get { return nSoDienThoai; }
            set { nSoDienThoai = value; }
        }
        // Methods
        public virtual void Input()
        {
            Console.Write("ID: ");
            nID = Console.ReadLine();
            Console.Write("Ten: ");
            nTen = Console.ReadLine();
            Console.Write("Gioi Tinh: ");
            nGioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            Console.Write("{");
            tNgaySinh.nhap();
            Console.Write("}");
            Console.Write("Dia chi: ");
            nDiaChi = Console.ReadLine();
            Console.Write("So dien thoai: ");
            nSoDienThoai = Console.ReadLine();
        }
        public virtual void Print()
        {
            Console.WriteLine("ID: " + this.nID);
            Console.WriteLine("Ten: " + this.nTen);
            Console.WriteLine("GioiTinh: " + this.nGioiTinh);
            Console.WriteLine("Ngay sinh: " + this.tNgaySinh);
            Console.WriteLine("So dien thoai: " + this.nSoDienThoai);
        }
        public abstract bool IsEquals(Nguoi nguoi);
        
    }
}
