using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class HDTV : TVsData
    {
        public int ports = 3;
        public HDTV(string size, string price) : base(size, price)
        {
            Console.WriteLine("The size of your HDTV is " + size + ", and the price of this model is $" +price +".");
        }

        public override void SmartApp()
        {
            Console.WriteLine("The Smart App option is not available for this model. Perhaps you should consider upgrading to the 4K TV!");
        }

        public override void TurnOn()
        {
            Console.WriteLine("For this TV, you must use the provided remote for operations.");
        }
    }
}
