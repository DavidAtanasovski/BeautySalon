using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    class Visit
    {
        public Customer Customer { get; set; }
        public  Discount Discount { get; set; }

        public List<Item> Items { get; set; }
        
        public Visit()
        {
            Items = new List<Item>();
        }

        public double Total()
        {
            var sum = 0.0;
            foreach (var item in Items)
            {
                if(item.product == ProductType.Product)
                {
                    sum += item.price * (1 - Discount.Discoun);
                }

                if (item.product == ProductType.Service)
                {
                    sum += item.price * (Customer.HasMemenership ? (1 - Customer.Membership.Discount()) : 1);
                }
            }
            return sum;
        }
    }
}
