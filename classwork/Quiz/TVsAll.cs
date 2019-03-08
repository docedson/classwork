using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVsAll
    {
        int size;
        int ports;
        decimal price;
        bool isMountable;

        public TVsAll(int size, int ports, decimal price, bool isMountable)
        {
            this.size = size;
            this.ports = ports;
            this.price = price;
            this.isMountable = isMountable;
        }

    }

}