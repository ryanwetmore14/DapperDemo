using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, double price, int CategoryID, bool onSale, int stockLevel);
    }
}
