using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVs
    {
        int size;
        int price;
        int ports;
        bool mountable;

        public TVs(int size, int price)
        {
            this.size = size;
            this.price = price;
        }

        public TVs(int size, int price, int ports, bool mountable)
        {
            this.size = size;
            this.price = price;
            this.ports = ports;
            this.mountable = mountable;
        }

        public int GetSize()
        {
            return size;
        }

        public void SetSize(int size)
        { 
            this.size = size;
        }
            


    }





}