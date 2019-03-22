using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ThreadDataExample
    {
        public void SimpleMethod(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hello Threading:");
            }
        }

        public void DifferentMethd(object data)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Threading again {0}.", data);
            }
        }
    }
}
