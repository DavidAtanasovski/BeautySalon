using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    public class Premium : Membership
    {
        public override double Discount()
        {
            return 20.00 / 100.00;
        }

        public override MemebrshipType Type()
        {
            return MemebrshipType.Premium;
        }
    }
}
