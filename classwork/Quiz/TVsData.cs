using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class TVsData
    {
        public string Size { get; set; } = "100 inch";
        public string Price { get; set; }
        public int Ports { get; set; } = 4;
        public bool IsMountable { get; set; }        

        public abstract void TurnOn();
        public abstract void SmartApp();

        public TVsData(string price, string size) : this(price, size, true, 4)
        {
        }

        public TVsData(string price, string size, bool isMountable, int ports)
        {
            this.Size = size;
            this.Price = price;
            this.Ports = ports;
            this.IsMountable = isMountable;            
        }

        public void Mounty(bool isMountable)
        {
            if (isMountable)
            {
                Console.WriteLine("Obviously, this model is mountable.");
            }

            else
            {
                Console.WriteLine("Unfortunately, this model is not mountable.");
            }
        }
    }
}
