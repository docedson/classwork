using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class HDTV : TVs
    {
        int size;
        int ports;
        decimal price;
        bool mountable = false;

        public HDTV(int size, int price) : base(size, price)
        {
            Console.WriteLine("The size is " + size, "inches. The number of ports is ", +ports, ". The price is $", +price, ". This TV is ", mountable, ". Your HDTV will be operated by the included phsycial remote.");
        }



    }
}
