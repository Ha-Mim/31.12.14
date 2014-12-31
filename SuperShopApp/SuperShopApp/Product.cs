using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopApp
{
    class Product
    {
        public string ProductId { set; get; }
        public int Quantity { set; get; }

        public Product(string productId, int quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }
}
