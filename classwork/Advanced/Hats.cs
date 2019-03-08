using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class Hats
    {
        public delegate void TryHat(string type);
        public string HatType { get; }
        public int HatSize { get; }

        public Hats()
        {
            TryHat myHat = TryOnHat;
            TryALargerHat("fadora", 7, myHat);
        }

        public Hats(int size)
        {
            this.HatSize = size;
        }

        public Hats(string type, int size)
        {
            this.HatSize = size;
            this.HatType = type;
        }

        //Method for a delegate
        public void TryOnHat(string message)
        {
            Console.WriteLine(message);
        }

        public void TryALargerHat(string type, int oldSize, TryHat another)
        {
            another("I tried on a " + type + " hat at size " + (oldSize + 1).ToString());
        }

        public void FindLuckyHat(string message)
        {
            Console.WriteLine("Lucky hat is {0}", message);
        }

        public void FindUglyHat(string message)
        {
            Console.WriteLine("Ugly hat is {0}", message);
        }

    }
}
