using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    internal class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public List<Product> ProductList { set; get; }

        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
            ProductList = new List<Product>();
        }

        public string Additem(Product aProduct)
        {
            if (DuplicateProduct(aProduct))
            {
                return "Duplicate product quantity increase";
            }
            else
            {
                ProductList.Add(aProduct);
                return "New Product Added";
            }
              
         }

        public bool DuplicateProduct(Product aProduct)
        {
            foreach (Product product1 in ProductList)
            {
                if (product1.ProductId == aProduct.ProductId)
                {
                    product1.Quantity += aProduct.Quantity;
                    return true;
                }
            }
            return false;
        }

        public Product[] GetProducts()
        {
            return ProductList.ToArray();
        }
    }
}
