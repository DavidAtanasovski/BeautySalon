using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    public abstract class Membership
    {
        public string type { get; set; }

        public abstract double Discount();
        public abstract MemebrshipType Type();
    }
}
