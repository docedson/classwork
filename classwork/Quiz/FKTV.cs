using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class FKTV : TVsData
    {
        public int ports = 5;
        public FKTV(string size, string price) : base(size, price)
        {
            Console.WriteLine("The size of your 4K TV is " +size +", and the price of this model is $" +price);            
        }

        public override void SmartApp()
        {
            Console.WriteLine("As being the newest tech, you get to use the authorized Smart App to operate your TV!");
        }

        public override void TurnOn()
        {
            Console.WriteLine("There is no physical remote provided for this TV model.");
        }

    }
}
