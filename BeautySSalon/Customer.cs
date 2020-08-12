using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    public class Customer
    {
        public string Name { get; private set; }
        public Membership Membership { get; set;}

        public bool HasMemenership 
        {
            get 
            { 
                return Membership != null; 
            }
        }

        public Customer(string name) 
        {
            Name = name;
        }
    }
}
