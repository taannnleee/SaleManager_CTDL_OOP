using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;
using SaleManager.Models.Base;

namespace SaleManager.DataStructure
{
    public class DanhSachSanPham : DanhSach<SanPham>, IDanhSachSanPham
    {
        public DanhSachSanPham(int iGioiHan) : base(iGioiHan)
        {

        }

        public override void AddItem(int index, SanPham item)
        {
            if (base.iSize >= iGioiHan) return;
            for (int i = base.iSize; i > index; i--)
            {
                base.list_[i] = base.list_[i - 1];
            }
            iSize++;
            base.list_[index] = item;
        }

        public override void AddLast(SanPham item)
        {
            if (iSize >= iGioiHan) return;
            list_[iSize++] = item;
        }

        public void AddFirst(SanPham item)
        {
            if (iSize >= iGioiHan) return;
            iSize++;
            for (int i = iSize; i > 1; i--)
            {
                list_[i] = list_[i - 1];
            }
            list_[1] = item;
        }

        public override void AddRange(DanhSach<SanPham> sourceList)
        {
            for (int i = 0; i < sourceList.Size; i++)
            {
                if (iSize >= GioiHan)
                    return;
                else
                    list_[iSize++] = sourceList.Get(i);
            }
        }

        public override SanPham Get(int index)
        {
            if (!IsValidIndex(index)) return null;
            else
                return list_[index];
        }

        public override void RemoveItem(int index)
        {
            for (int i = index; i < iSize; i++)
            {
                list_[i] = list_[i + 1];
            }
            iSize--;
        }

        public int RemoveItemByID(SanPham tempproduct)
        {
            int count = iSize;
            for (int i = 0; i < iSize; i++)
            {
                if (list_[i].ID == tempproduct.ID)
                {
                    RemoveItem(i);
                    count -= 1;
                    break;
                }
            }
            return count;
        }

        public override SanPham SearchItem(SanPham item)
        {
            for (int i = 0; i < iSize; i++)
            {
                if (item.IsEqual(list_[i]))
                    return list_[i];
            }
            return null;
        }

        public SanPham SearchItemByID(SanPham item)
        {
            SanPham temp = null;
            for (int i = 0; i < iSize; i++)
            {
                if (item.IsEqual(list_[i]))
                {
                    temp = list_[i];
                    break;
                }
            }
            return temp;
        }

        public DanhSachSanPham DeleteByProductNumber(SanPham tempproduct, int n)
        {
            int temp = 0;
            DanhSachSanPham templist = new DanhSachSanPham(100);
            for (int i = 0; i < iSize; i++)
            {
                if (tempproduct.IsEqual(list_[i]))
                {
                    list_[i].Soluong = list_[i].Soluong - n;
                    templist.AddLast(list_[i]);
                }
            }
            return templist;
        }

        public DanhSachSanPham SearchItemByName(string name)
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            SanPham product = new SanPham();
            for (int i = 0; i < iSize; i++)
            {
                string list = list_[i].Tensp;
                if (list.Contains(name))
                {
                    temp.AddLast(list_[i]);
                }
            }
            if (temp.iSize == 0) return null;
            return temp;
        }


        public SanPham QuantityOfAProduct(string name)
        {
            int tam = 0;
            SanPham product = new SanPham();
            for (int i = 0; i < iSize; i++)
            {
                string list = list_[i].Tensp;

                if (list==name)
                {
                    product = list_[i];
                    tam++;
                    break;
                }
            }
            if (tam == 0) return null;
            return product;
        }

        public bool ItemAlreadyExists(SanPham item)
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            for (int i = 0; i < iSize; i++)
            {
                if (item.IsEqual(list_[i]))
                {
                    list_[i].Soluong += item.Soluong;
                    return true;
                }
            }
            return false;
        }

        public DanhSachSanPham FindByDate(ThoiGian dayStart, ThoiGian dayEnd)
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            for (int i = 0; i < iSize; i++)
            {
                if (list_[i].Ngayhethan >= dayStart && list_[i].Ngayhethan <= dayEnd)
                {
                    temp.AddLast(list_[i]);
                }
            }
            if (temp.Size == 0) return null;
            return temp;
        }

        public override int IndexOf(SanPham item)
        {
            for (int i = 0; i < iSize; i++)
                if (item.IsEqual(list_[i]))
                    return i;
            return -1;
        }

        public void SortByNumberOfProduct()
        {
            for (int i = 1; i < iSize; i++)
            {
                SanPham t = list_[i];
                int j = i - 1;
                while (j >= 0 && t.Soluong > list_[j].Soluong)
                {
                    list_[j + 1] = list_[j];
                    j--;
                }
                list_[j + 1] = t;
            }
        }

        public DanhSachSanPham FindExpiredProducts(ThoiGian today)
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            for (int i = 0; i < iSize; i++)
                if (today > list_[i].Ngayhethan)
                    temp.AddLast(list_[i]);
            return temp;
        }

        public int TotalGoods()
        {
            int sum = 0;
            for (int i = 0; i < iSize; i++)
            {
                sum += list_[i].Soluong;
            }
            return sum;
        }

        public DanhSachSanPham ProductQuantityMoreThan100()
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            for (int i = 0; i < iSize; i++)
            {
                if (list_[i].Soluong > 100)
                {
                    temp.AddLast(list_[i]);
                }
            }
            return temp;
        }

        public DanhSachSanPham MaximumNumberOfProducts()
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            SanPham max = list_[0];
            for (int i = 1; i < iSize; i++)
            {
                if (list_[i].Soluong > max.Soluong)
                {
                    max = list_[i];

                }
            }
            temp.AddLast(max);
            if (temp.Size == 0) return null;
            return temp;
        }

        public DanhSachSanPham MinimumNumberOfProducts()
        {
            DanhSachSanPham temp = new DanhSachSanPham(100);
            SanPham min = list_[0];
            for (int i = 1; i < iSize; i++)
            {
                if (list_[i].Soluong < min.Soluong)
                {
                    min = list_[i];

                }
            }
            temp.AddLast(min);
            if (temp.Size == 0) return null;
            return temp;
        }

        public int CheckNumberProduct(SanPham temp)
        {
            int sum = 0;
            for (int i = 0; i < iSize; i++)
            {
                if (temp.IsEqual(list_[i]))
                {
                    sum = list_[i].Soluong;
                    break;
                }
            }
            return sum;
        }

        public bool WriteFile(string fileName)
        {
            string path = Directory.GetCurrentDirectory();
            path += "/../../../Data/" + fileName;
            try
            {
                StreamWriter sw = new StreamWriter(path);
                SanPham product;
                for (int i = 0; i < iSize; i++)
                {
                    product = list_[i];
                    sw.WriteLine("{0};{1};{2};{3};{4};{5}",
                    product.ID, //0
                    product.Tensp, //1
                    product.Soluong,//2
                    product.Ngaynhap.layThoiGian(),//3
                    product.Ngayhethan.layThoiGian(), // 4
                    product.GiaTien); //5
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public void AddLastNoDuplicate(SanPham product)
        {
            if (FindByID(product.ID) != null)
            {
                Console.WriteLine("Trung lap");
                return;
            }
            AddLast(product);
        }

        public SanPham FindByID(string id)
        {
            SanPham product = null;
            for (int i = 0; i < iSize; i++)
            {
                product = Get(i);
                if (id == product.ID)
                    return product;
            }
            return null;
        }

        public override void Print()
        {
            Console.WriteLine("|{0, -8}|{1, -25}|{2, -16}|{3, -20}|{4, -20}|{5,8}|",
                   "ID ", "Name", "NumberOfProduct", "DayStartedUsing", "DateExpires", "Price");
            for (int i = 0; i < iSize; i++)
            {
                Console.WriteLine("|{0, -8}|{1, -25}|{2, -16}|{3, -20}|{4, -20}|{5,8}|",
                    list_[i].ID,
                    list_[i].Tensp,
                    list_[i].Soluong,
                    list_[i].Ngaynhap.layThoiGian(),
                    list_[i].Ngayhethan.layThoiGian(),
                    list_[i].GiaTien);
            }
        }
    }
}
