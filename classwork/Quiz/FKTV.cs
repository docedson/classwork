using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class FKTV : TVs
    {
        int size;
        int ports;
        decimal price;
        bool mountable = true;

        public FKTV(int size, int price) : base(size, price)
        {
            Console.WriteLine("The size is " + size, "inches. The number of ports is ", +ports, ". The price is $", +price, ". This TV is ", mountable, ". Your 4K TV will be operated by the authorized Smart App.");
        }



    }
}
