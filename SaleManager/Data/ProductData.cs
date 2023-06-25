using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;
using SaleManager.DataStructure;

namespace SaleManager.Data
{
    public static class ProductData
    {
        public static ListProduct productList = Init();

        private static ListProduct Init()
        {
            ListProduct list_ = new ListProduct(100);
            list_.AddLast(new Product("SP01", "Ti Vi", 15, new Time(1, 1, 2012, 20, 20, 30), new Time(9, 9, 2050, 15, 30, 0), 25000000));
            list_.AddLast(new Product("SP02", "May In", 120, new Time(2, 2, 2012, 20, 20, 30), new Time(8, 8, 2020, 11, 45, 30), 27000000));
            list_.AddLast(new Product("SP03", "May Giac", 130, new Time(3, 3, 2012, 11, 12, 30), new Time(7, 7, 2052, 1, 45, 30), 28000000));
            list_.AddLast(new Product("SP04", "May Vi Tinh", 140, new Time(1, 1, 2013, 1, 1, 30), new Time(6, 6, 2053, 12, 30, 30), 30000000));
            list_.AddLast(new Product("SP05", "Tu Lanh", 150, new Time(4, 4, 2014, 7, 30, 30), new Time(5, 5, 2053, 12, 25, 45), 21000000));
            list_.AddLast(new Product("SP06", "May Quat", 160, new Time(5, 5, 2015, 9, 15, 30), new Time(4, 4, 2053, 7, 30, 30), 17000000));
            list_.AddLast(new Product("SP07", "May Lanh", 170, new Time(6, 6, 2016, 2, 2, 30), new Time(3, 4, 2059, 5, 45, 45), 29000000));
            return list_;

        }
    }
}
