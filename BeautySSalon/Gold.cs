using System;
using System.Collections.Generic;
using System.Text;

namespace BeautySSalon
{
    public class Gold : Membership
    {
        public override double Discount()
        {
            return 15 / 100.00;
        }

        public override MemebrshipType Type()
        {
            return MemebrshipType.Gold;
        }
    }
}
