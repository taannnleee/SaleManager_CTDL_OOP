
﻿using SaleManager.Main.Option;
﻿using SaleManager.Activities_Main.Option;
using SaleManager.Main.Option;
using SaleManager.Models;
using SaleManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SaleManager.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon = Login.Run();
            while (true)
            {
                switch (chon)
                {
                    case Constant.BACK_TO_PROGRAM:
                        chon = MenuMain.Run();
                        break;
                    case Constant.MESSAGE_INTO_THE_STOCK:
                        chon = MenuProduct.Run();
                        break;
                    case Constant.MESSAGE_INTO_THE_STAFF:
                        //chon = QuanLyNhanVien.Run();
                        chon = MenuEmployee.Run();
                        break;
                    case Constant.MESSAGE_INTO_THE_BILL:
                        //chon = QuanLyBill.Run();
                        break;
                    default:
                        Console.WriteLine("Quit app");
                        return;
                }

            }
        }
    }
}