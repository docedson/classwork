/*using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVs
    {
        public string Size { get; set; } = "50 Inch";
        public string Price { get; set; }
        public int Ports { get; set; } = 6;
        public bool Mountable { get; set; }

        public abstract void TurnOn();
        public abstract void SmartApp();




        public TVs(string size, string price) : this(price, size, true, 6)
        {


        }

        public TVs(string size, string price, bool mountable, int ports)
        {
            this.Price = price;
            this.Size = size;
            this.IsMountable = mountable;
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
}*/
