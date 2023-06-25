using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;
using SaleManager.Information;
using SaleManager.Data;
using SaleManager.DataStructure;
using SaleManager.Utilities;
using SaleManager.Models.Base;

namespace SaleManager.Main.Option
{
    public static class MenuProduct
    {
        public static int Run()
        {
            ListProduct productList = ProductData.productList;
            ListProduct tempList = new ListProduct(100);
            Product tempProduct;
            Time today;
            string tempName;
            int index;
            int sum;
            int choose = 100;
            while (true)
            {
                Console.Clear();
                Group.Information(70);
                Console.Write("=========================MENU==========================\n");
                Console.Write("| 1. In san pham trong kho                            |\n");
                Console.Write("| 2. Them san pham vao kho                            |\n");
                Console.Write("| 3. Chen san pham vao vi tri chon truoc              |\n");
                Console.Write("| 4. Tim kiem san pham theo ID                        |\n");
                Console.Write("| 5. Tim kiem san pham theo ten                       |\n");
                Console.Write("| 6. Sap xep san pham theo so luong san pham trong kho|\n");
                Console.Write("| 7. In san pham het han                              |\n");
                Console.Write("| 8. Tong so luong san pham trong kho                 |\n");
                Console.Write("| 9. Tim so luong cua mot san pham                    |\n");
                Console.Write("|10. Danh sach san pham co so luong nhieu hon 100     |\n");
                Console.Write("|11. San pham co so luong nhieu nhat                  |\n");
                Console.Write("|12. San pham co so luong it nhat                     |\n");
                Console.Write("|13. Xuat so luong san pham theo ten                  |\n");
                Console.Write("|14. Xuat phieu                                       |\n");
                Console.Write("|15. Doi ten san pham                                 |\n");  // indexers
                Console.Write("|16. Truy xuat san pham co so luong nhieu hon 150     |\n");
                Console.Write("|17. Truy xuat san pham theo gia tien cua san pham    |\n");  // LINQ
                Console.Write("|18. Tro ve                                           |\n");
                Console.Write("|any key. Quit app                                    |\n");
                Console.Write("=========================MENU==========================\n");
                Console.Write("Choose: ");
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("---------------------------------------------------Result-----------------------------------------");
                        productList.Print();
                        break;
                    case 2:
                        tempProduct = new Product();
                        tempProduct.nhap();
                        if (productList.ItemAlreadyExists(tempProduct) == true)
                        {
                            productList.Print();
                        }
                        else
                        {
                            productList.AddLast(tempProduct);
                            Console.WriteLine("---------------------------------------------------Result-----------------------------------------");
                            productList.Print();
                        }
                        break;
                    case 3:
                        tempProduct = new Product();
                        Console.WriteLine("Location Add Products");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Product Information");
                        tempProduct.nhap();
                        if (productList.ItemAlreadyExists(tempProduct) == true)
                        {
                            productList.Print();
                        }
                        else
                        {
                            productList.AddItem(index, tempProduct);
                            Console.WriteLine("---------------------------------------------------Result-----------------------------------------");
                            productList.Print();
                        }
                        break;
                    case 4:
                        tempProduct = new Product();
                        Console.WriteLine("Enter product ID");
                        tempProduct.Id = Console.ReadLine();
                        tempProduct = productList.SearchItemByID(tempProduct);
                        Console.WriteLine("---------------------------------------------Result---------------------------------");
                        if (tempProduct == null)
                            Console.WriteLine("Khong tim thay san san pham");
                        else
                        {
                            tempProduct.xuat();
                        }
                        break;
                    case 5:
                        tempProduct = new Product();
                        Console.WriteLine("Enter product name ");
                        tempProduct.Name = Console.ReadLine();
                        string name = tempProduct.Name;
                        tempList = productList.SearchItemByName(name);
                        Console.WriteLine("---------------------------------------------------Result-----------------------------------------");
                        if (tempList == null)
                            Console.WriteLine("Khong tim thay san pham");
                        else
                        {
                            tempList.Print();
                        }
                        break;
                    case 6:
                        productList.SortByNumberOfProduct();
                        productList.Print();
                        break;
                    case 7:
                        today = new Time();
                        Time today2 = Time.CurrentDay();
                        tempList = productList.FindExpiredProducts(today2);
                        if (tempList.IsEmpty())
                            Console.WriteLine("Khong co san pham nao het han");
                    else
                        {
                            tempList.Print();
                        }
                        break;
                    case 8:
                        sum = productList.TotalGoods();
                        Console.WriteLine(sum);
                        break;
                    case 9:
                        tempProduct = new Product();
                        Console.WriteLine("Enter product ID : ");
                        tempProduct.Id = Console.ReadLine();
                        int tam = productList.CheckNumberProduct(tempProduct);
                        Console.WriteLine(tam);
                        break;
                    case 10:
                        tempList = new ListProduct(100); ;
                        tempList = productList.ProductQuantityMoreThan100();
                        if (tempList == null)
                            Console.WriteLine("khong tim thay san pham");
                        else
                        {
                            tempList.Print();
                        }
                        break;
                    case 11:
                        tempList = new ListProduct(100); ;
                        tempList = productList.MaximumNumberOfProducts();
                        if (tempList == null)
                            Console.WriteLine("khong tim thay san pham");
                        else
                        {
                            tempList.Print();
                        }
                        break;
                    case 12:
                        tempList = new ListProduct(100); ;
                        tempList = productList.MinimumNumberOfProducts();
                        if (tempList == null)
                            Console.WriteLine("Khong tim thay san pham");
                        else
                        {
                            tempList.Print();
                        }
                        break;
                    case 13:
                        tempProduct = new Product();
                        Console.WriteLine("Nhap ten san pham ");
                        tempProduct.Name = Console.ReadLine();
                        string name1 = tempProduct.Name;
                        tempProduct = productList.QuantityOfAProduct(name1);
                        Console.WriteLine("---------------------------------------------------Result-----------------------------------------");
                        if (tempProduct == null)
                            Console.WriteLine("Khong tim thay san pham");
                        else
                        {
                            Console.WriteLine(tempProduct.Quatity);
                        }
                        break;
                    case 14:
                        Console.WriteLine("Nhap ten file: ");
                        tempName = Console.ReadLine();
                        if (!productList.WriteFile(tempName))
                            Console.WriteLine("Khong tim thay");
                        else
                        {
                            Console.WriteLine("Thanh cong");
                            productList.Print();
                        }
                        break;
                    case 15:
                        Console.WriteLine("Nhap vi tri can thay the");
                        int vt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ten can thay the");
                        string ten = Console.ReadLine();
                        productList[vt].Name = ten;
                        break;
                    case 16:
                        ListProduct kqTruyVan = new ListProduct(100);
                        var products = new List<Product>();

                        for (int i = 0; i < productList.Size; i++)
                        {
                            products.Add(productList.Get(i));
                        }
                        var temp = from p in products where p.Quatity >=150 select p;
                        
                        Console.WriteLine();

                        foreach(var product in temp)
                        {
                            kqTruyVan.AddLast(product);
    
                        }
                        kqTruyVan.Print();                      
                        break;
                    case 17:
                        Console.WriteLine("Nhap vao gia tien: ");
                        int giatien = Convert.ToInt32(Console.ReadLine());
                        ListProduct kqTruyVan2 = new ListProduct(100);
                        var products2 = new List<Product>();

                        for (int i = 0; i < productList.Size; i++)
                        {
                            products2.Add(productList.Get(i));
                        }
                        var temp2 = from p in products2 where p.Price <= giatien select p;
                        foreach (var product in temp2)
                        {
                            kqTruyVan2.AddLast(product);

                        }
                        kqTruyVan2.Print();

                        break;

                    case 18:
                        return Constant.BACK_TO_PROGRAM;
                    default:
                        return 100;
                }
                Group.DungManHinh();
            }
        }

    }
}
