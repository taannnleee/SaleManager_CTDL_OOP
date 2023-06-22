using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;

namespace SaleManager.DataStructure
{
    interface IDanhSachSanPham 
    {
        public SanPham FindByID(string id);
        public void AddLastNoDuplicate(SanPham product);
        public bool WriteFile(string fileName);
        public int CheckNumberProduct(SanPham temp);
        public DanhSachSanPham MinimumNumberOfProducts();
        public DanhSachSanPham MaximumNumberOfProducts();
        public DanhSachSanPham ProductQuantityMoreThan100();
        public DanhSachSanPham FindExpiredProducts(ThoiGian today);
        public void SortByNumberOfProduct();
        public DanhSachSanPham FindByDate(ThoiGian dayStart, ThoiGian dayEnd);

    }
}
