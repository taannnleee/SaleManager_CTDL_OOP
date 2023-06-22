using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;
using SaleManager.DataStructure;

namespace SaleManager.Data
{
    public static class SanPhamTrongKho
    {
        public static DanhSachSanPham productList = Init();

        private static DanhSachSanPham Init()
        {
            DanhSachSanPham list_ = new DanhSachSanPham(100);
            list_.AddLast(new SanPham("SP01", "Ti Vi", 15, new ThoiGian(1, 1, 2012, 20, 20, 30), new ThoiGian(9, 9, 2050, 15, 30, 0), 25000000));
            list_.AddLast(new SanPham("SP02", "May In", 120, new ThoiGian(2, 2, 2012, 20, 20, 30), new ThoiGian(8, 8, 2020, 11, 45, 30), 27000000));
            list_.AddLast(new SanPham("SP03", "May Giac", 130, new ThoiGian(3, 3, 2012, 11, 12, 30), new ThoiGian(7, 7, 2052, 1, 45, 30), 28000000));
            list_.AddLast(new SanPham("SP04", "May Vi Tinh", 140, new ThoiGian(1, 1, 2013, 1, 1, 30), new ThoiGian(6, 6, 2053, 12, 30, 30), 30000000));
            list_.AddLast(new SanPham("SP05", "Tu Lanh", 150, new ThoiGian(4, 4, 2014, 7, 30, 30), new ThoiGian(5, 5, 2053, 12, 25, 45), 21000000));
            list_.AddLast(new SanPham("SP06", "May Quat", 160, new ThoiGian(5, 5, 2015, 9, 15, 30), new ThoiGian(4, 4, 2053, 7, 30, 30), 17000000));
            list_.AddLast(new SanPham("SP07", "May Lanh", 170, new ThoiGian(6, 6, 2016, 2, 2, 30), new ThoiGian(3, 4, 2059, 5, 45, 45), 29000000));
            return list_;

        }
    }
}
