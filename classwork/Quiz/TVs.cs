using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVs
    {
        public double size { get; set; }
        public double price { get; set; }
        public int ports { get; set; }
        public bool mountable { get; set; }
        public abstract void power();


        public TVs(string size, string price, bool mountable, int ports)
        {
            this.Price = price;
            this.Size = size;
            this.Mountable = mountable;
            this.Ports = ports;
        }

        public void Mountability(bool mountable)
        {
            if (mountable)
            {
                Console.WriteLine("The TV is mountable.");
            }
            else
            {
                Console.WriteLine("The TV is not mountable.");
            }
        }
    }
}
