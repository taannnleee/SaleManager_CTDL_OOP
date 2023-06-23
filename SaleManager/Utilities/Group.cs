using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager.Information
{
    static class Group
    {
        public static void Information(int space)
        {
            string line = new string((char)9552, 38);
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            string str = new string(' ', space);
            Console.WriteLine(str + "╔" + line +                           "╗");
            Console.WriteLine(str + "║                                      ║");
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
