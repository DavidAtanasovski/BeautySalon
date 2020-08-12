using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    public class Silver : Membership
    {
        public override double Discount()
        {
            return 10 / 100.00;
        }

        public override MemebrshipType Type()
        {
            return MemebrshipType.Silver;
        }
    }

}
