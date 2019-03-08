using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class SmallDog
    {
        int howOld;
        
        public void ageList()
        {
            Console.WriteLine("Your dog is considered a 'small' dog. Now, please enter your dog's age by whole years and press 'Enter'.");
            howOld = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        public void dogYears()
        {
            if (howOld == 1)
            {
                Console.WriteLine("Your dog is 15 years old in human years.");
            }
            else if (howOld == 2)
            {
                Console.WriteLine("Your dog is 24 years old in human years.");
            }
            else if (howOld == 3)
            {
                Console.WriteLine("Your dog is 28 years old in human years.");
            }
            else if (howOld == 4)
            {
                Console.WriteLine("Your dog is 32 years old in human years.");
            }
            else if (howOld == 5)
            {
                Console.WriteLine("Your dog is 36 years old in human years.");
            }
            else if (howOld == 6)
            {
                Console.WriteLine("Your dog is 40 years old in human years.");
            }
            else if (howOld == 7)
            {
                Console.WriteLine("Your dog is 44 years old in human years.");
            }
            else if (howOld == 8)
            {
                Console.WriteLine("Your dog is 48 years old in human years.");
            }
            else if (howOld == 9)
            {
                Console.WriteLine("Your dog is 52 years old in human years.");
            }
            else if (howOld == 10)
            {
                Console.WriteLine("Your dog is 56 years old in human years.");
            }
            else if (howOld == 11)
            {
                Console.WriteLine("Your dog is 60 years old in human years.");
            }
            else if (howOld == 12)
            {
                Console.WriteLine("Your dog is 64 years old in human years.");
            }
            else if (howOld == 13)
            {
                Console.WriteLine("Your dog is 68 years old in human years.");
            }
            else if (howOld == 14)
            {
                Console.WriteLine("Your dog is 72 years old in human years.");
            }
            else if (howOld == 15)
            {
                Console.WriteLine("Your dog is 76 years old in human years.");
            }
            else if (howOld == 16)
            {
                Console.WriteLine("Your dog is 80 years old in human years.");
            }
            else
            {
                Console.WriteLine("Your dog is over 80 human years old. It's time to let them eat all the chocolate they want!");
            }
            Console.ReadLine();
        }
    }
}
