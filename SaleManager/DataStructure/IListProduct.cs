using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaleManager.Models;

namespace SaleManager.DataStructure
{
    interface IListProduct 
    {
        public Product FindByID(string id);
        public void AddLastNoDuplicate(Product product);
        public bool WriteFile(string fileName);
        public int CheckNumberProduct(Product temp);
        public ListProduct MinimumNumberOfProducts();
        public ListProduct MaximumNumberOfProducts();
        public ListProduct ProductQuantityMoreThan100();
        public ListProduct FindExpiredProducts(Time today);
        public void SortByNumberOfProduct();
        public ListProduct FindByDate(Time dayStart, Time dayEnd);

    }
}
