using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Models.Base
{
    public class GiamDoc : Nguoi
    {
        //files
        private int iLuong;
        private double iCoPhan;
        //properties
        public int Luong
        {
            get { return iLuong; }
            set { iLuong = value; }
        }
        public double CoPhan
        {
            get { return iCoPhan; }
            set { iCoPhan = value; }
        }
        // Constucter
        public GiamDoc(string id, string Ten, string GioiTinh,
            Time NgaySinh, string DiaChi, string SoDienThoai,
            int Luong, double CoPhan) : base(id, Ten, GioiTinh, NgaySinh, DiaChi, SoDienThoai)
        {
            this.Luong = Luong;
            this.CoPhan = CoPhan;
        }

        public GiamDoc(string id, string Ten, string GioiTinh,
            Time NgaySinh, string DiaChi, string SoDienThoai
            ) : base(id, Ten, GioiTinh, NgaySinh, DiaChi, SoDienThoai)
        {
            
        }

        public GiamDoc()
        {
        }

        // Destruction
        ~GiamDoc() { }

        // Method
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Co Phan: ");
            CoPhan = Convert.ToDouble(Console.ReadLine());
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Luong: " + iLuong);
            Console.WriteLine("CoPhan: " + iCoPhan+"%");
        }

        public override bool IsEquals(Nguoi nguoi)
        {
            if (ID == nguoi.ID)
                return true;
            return false;
        }
    }
}
