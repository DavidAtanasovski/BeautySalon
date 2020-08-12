using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    public class Item
    {
        public double price { get; set; }

        public ProductType product { get; set; }

        public Item(double price, ProductType productType)
        {
            product = productType;
            this.price = price;
        }
    }
}
