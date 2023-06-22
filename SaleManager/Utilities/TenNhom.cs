using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Information
{
    static class TenNhom
    {
        public static void ThongTin(int space)
        {
            string line = new string((char)9552, 38);
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            string str = new string(' ', space);
            Console.WriteLine(str + "╔" + line +                           "╗");
            Console.WriteLine(str + "║                 Nhom 16              ║");
            Console.WriteLine(str + "╠" + line +                           "╣");
            Console.WriteLine(str + "║Le Tan                        21110296║");
            Console.WriteLine(str + "╚" + line + "╝");
            Console.SetCursorPosition(left,top);
        }

        public static void DungManHinh()
        {
            Console.WriteLine("Enter To Continue...");
            Console.ReadKey();
        }
    }
}
