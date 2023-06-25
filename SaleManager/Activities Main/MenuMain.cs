using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Information;
using SaleManager.Utilities;
namespace SaleManager.Main
{
    public static class MenuMain
    {
        delegate int MyDelegate();
        public static int Run()
        {
            int chon = -1000;
            while (true)
            {
                Console.Clear();
                Group.Information(50);
                Console.WriteLine("╔=========================================╗");
                Console.WriteLine("║      Chuong trinh quan ly cua hang      ║");
                Console.WriteLine("║    Chon che do ma ban muon quan ly      ║");
                Console.WriteLine("║ [1]  Kho Hang                           ║");
                Console.WriteLine("║ [2]  Nhan Vien                          ║");
                Console.WriteLine("║ [3]  Bill                               ║");
                Console.WriteLine("║ [4]  Thoat chuong trinh                 ║");
                Console.WriteLine("╚=========================================╝");
                try
                {
                    chon = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (chon)
                {
                    case 1: return Constant.MESSAGE_INTO_THE_STOCK;
                    case 2: return Constant.MESSAGE_INTO_THE_STAFF;
                    case 3: return Constant.MESSAGE_INTO_THE_BILL;
                    case 4: return Constant.OUT_APP;
                    default:
                        Console.WriteLine("Sai cu phap");
                        break;
                }

            }
        }
    }
}
