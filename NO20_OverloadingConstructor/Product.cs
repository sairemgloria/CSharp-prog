using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO20_OverloadingConstructor
{
    internal class Product
    {
        // Attributes
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDesc { get; set; }
        public int productStock { get; set; }
        public float productPrice { get; set; }

        // constructor NO:1
        public Product(int productID, string productName, string productDesc, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDesc = productDesc;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }

        // constructor NO:2
        public Product(int productID, string productName, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productStock = productStock;
            this.productPrice = productPrice;
        }
    }
}
