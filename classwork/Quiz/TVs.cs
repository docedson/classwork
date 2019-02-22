using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVs
    {
        int size;
        int ports;
        decimal price;
        bool mountable;

        public TVs(int size, int ports, decimal price, bool mountable)
        {
            this.size = size;
            this.ports = ports;
            this.price = price;
            this.mountable = mountable;
        }

        public TVs(int size, int ports) :this(size, ports, 599.99m, true)
        {

        }





    }
          
}