using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class HDTV : TVs
    {
        public HDTV(int size, int price, int ports, bool mountable) : base(size, price)
        {
            Console.WriteLine("The size of this HDTV is " + size +" and the price of this HDTV is " + price);
        }

        /*public override void power()
        {
            Console.WriteLine("You will use the authorized Smart App to operate this TV.");
        }*/

    }
}
