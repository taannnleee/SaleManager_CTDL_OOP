using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManager
{
    public static class Login
    {

        public delegate bool check(string a, int b);
        public static int Run()
        {
            Console.OutputEncoding = Encoding.Unicode;
            while(true)
            {

                // gan lambda
                check kt = (string a, int b) =>
                {
                    if (a == "tanle" && b == 123123)
                   
                    {
                        return true;
                    }
                    else
                        return true;
                };

                Console.WriteLine("Tài Khoản : ");
                string a = Console.ReadLine();
                Console.WriteLine("Mật Khẩu : ");
                int b = Convert.ToInt32(Console.ReadLine());
               
                bool kq = kt(a,b);
                if (kq == true)
                    return 1;


            }
        }

        

    }
}
