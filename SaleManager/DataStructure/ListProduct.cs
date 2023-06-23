using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;
using SaleManager.Models.Base;

namespace SaleManager.DataStructure
{
    public class ListProduct : Models.Base.BaseList<Product>, IListProduct
    {
        public ListProduct(int iGioiHan) : base(iGioiHan)
        {

        }

        public override void AddItem(int index, Product item)
        {
            if (base.iSize >= capacity) return;
            for (int i = base.iSize; i > index; i--)
            {
                base.list_[i] = base.list_[i - 1];
            }
            iSize++;
            base.list_[index] = item;
        }

        public override void AddLast(Product item)
        {
            if (iSize >= capacity) return;
            list_[iSize++] = item;
        }

        public void AddFirst(Product item)
        {
            if (iSize >= capacity) return;
            iSize++;
            for (int i = iSize; i > 1; i--)
            {
                list_[i] = list_[i - 1];
            }
            list_[1] = item;
        }

        public override void AddRange(Models.Base.BaseList<Product> sourceList)
        {
            for (int i = 0; i < sourceList.Size; i++)
            {
                if (iSize >= Capacity)
                    return;
                else
                    list_[iSize++] = sourceList.Get(i);
            }
        }

        public override Product Get(int index)
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

        public int RemoveItemByID(Product tempproduct)
        {
            int count = iSize;
            for (int i = 0; i < iSize; i++)
            {
                if (list_[i].Id == tempproduct.Id)
                {
                    RemoveItem(i);
                    count -= 1;
                    break;
                }
            }
            return count;
        }

        public override Product SearchItem(Product item)
        {
            for (int i = 0; i < iSize; i++)
            {
                if (item.IsEqual(list_[i]))
                    return list_[i];
            }
            return null;
        }

        public Product SearchItemByID(Product item)
        {
            Product temp = null;
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

        public ListProduct DeleteByProductNumber(Product tempproduct, int n)
        {
            int temp = 0;
            ListProduct templist = new ListProduct(100);
            for (int i = 0; i < iSize; i++)
            {
                if (tempproduct.IsEqual(list_[i]))
                {
                    list_[i].Quatity = list_[i].Quatity - n;
                    templist.AddLast(list_[i]);
                }
            }
            return templist;
        }

        public ListProduct SearchItemByName(string name)
        {
            ListProduct temp = new ListProduct(100);
            Product product = new Product();
            for (int i = 0; i < iSize; i++)
            {
                string list = list_[i].Name;
                if (list.Contains(name))
                {
                    temp.AddLast(list_[i]);
                }
            }
            if (temp.iSize == 0) return null;
            return temp;
        }


        public Product QuantityOfAProduct(string name)
        {
            int tam = 0;
            Product product = new Product();
            for (int i = 0; i < iSize; i++)
            {
                string list = list_[i].Name;

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

        public bool ItemAlreadyExists(Product item)
        {
            ListProduct temp = new ListProduct(100);
            for (int i = 0; i < iSize; i++)
            {
                if (item.IsEqual(list_[i]))
                {
                    list_[i].Quatity += item.Quatity;
                    return true;
                }
            }
            return false;
        }

        public ListProduct FindByDate(Time dayStart, Time dayEnd)
        {
            ListProduct temp = new ListProduct(100);
            for (int i = 0; i < iSize; i++)
            {
                if (list_[i].Expiresdate >= dayStart && list_[i].Expiresdate <= dayEnd)
                {
                    temp.AddLast(list_[i]);
                }
            }
            if (temp.Size == 0) return null;
            return temp;
        }

        public override int IndexOf(Product item)
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
                Product t = list_[i];
                int j = i - 1;
                while (j >= 0 && t.Quatity> list_[j].Quatity)
                {
                    list_[j + 1] = list_[j];
                    j--;
                }
                list_[j + 1] = t;
            }
        }

        public ListProduct FindExpiredProducts(Time today)
        {
            ListProduct temp = new ListProduct(100);
            for (int i = 0; i < iSize; i++)
                if (today > list_[i].Expiresdate)
                    temp.AddLast(list_[i]);
            return temp;
        }

        public int TotalGoods()
        {
            int sum = 0;
            for (int i = 0; i < iSize; i++)
            {
                sum += list_[i].Quatity;
            }
            return sum;
        }

        public ListProduct ProductQuantityMoreThan100()
        {
            ListProduct temp = new ListProduct(100);
            for (int i = 0; i < iSize; i++)
            {
                if (list_[i].Quatity > 100)
                {
                    temp.AddLast(list_[i]);
                }
            }
            return temp;
        }

        public ListProduct MaximumNumberOfProducts()
        {
            ListProduct temp = new ListProduct(100);
            Product max = list_[0];
            for (int i = 1; i < iSize; i++)
            {
                if (list_[i].Quatity > max.Quatity)
                {
                    max = list_[i];

                }
            }
            temp.AddLast(max);
            if (temp.Size == 0) return null;
            return temp;
        }

        public ListProduct MinimumNumberOfProducts()
        {
            ListProduct temp = new ListProduct(100);
            Product min = list_[0];
            for (int i = 1; i < iSize; i++)
            {
                if (list_[i].Quatity < min.Quatity)
                {
                    min = list_[i];

                }
            }
            temp.AddLast(min);
            if (temp.Size == 0) return null;
            return temp;
        }

        public int CheckNumberProduct(Product temp)
        {
            int sum = 0;
            for (int i = 0; i < iSize; i++)
            {
                if (temp.IsEqual(list_[i]))
                {
                    sum = list_[i].Quatity;
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
                Product product;
                for (int i = 0; i < iSize; i++)
                {
                    product = list_[i];
                    sw.WriteLine("{0};{1};{2};{3};{4};{5}",
                    product.Id, //0
                    product.Name, //1
                    product.Quatity,//2
                    product.Startedusingday.getTime(),//3
                    product.Expiresdate.getTime(), // 4
                    product.Price); //5
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

        public void AddLastNoDuplicate(Product product)
        {
            if (FindByID(product.Id) != null)
            {
                Console.WriteLine("Trung lap");
                return;
            }
            AddLast(product);
        }

        public Product FindByID(string id)
        {
            Product product = null;
            for (int i = 0; i < iSize; i++)
            {
                product = Get(i);
                if (id == product.Id)
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
                    list_[i].Id,
                    list_[i].Name,
                    list_[i].Quatity,
                    list_[i].Startedusingday.getTime(),
                    list_[i].Expiresdate.getTime(),
                    list_[i].Price);
            }
        }
    }
}
