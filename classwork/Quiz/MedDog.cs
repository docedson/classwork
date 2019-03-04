using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class MedDog
    {
        int howOld;

        public void ageList()
        {
            Console.WriteLine("Your dog is considered a 'medium' dog. Now, please enter your dog's age by whole years and press 'Enter'.");
            howOld = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Your dog is 42 years old in human years.");
            }
            else if (howOld == 7)
            {
                Console.WriteLine("Your dog is 47 years old in human years.");
            }
            else if (howOld == 8)
            {
                Console.WriteLine("Your dog is 51 years old in human years.");
            }
            else if (howOld == 9)
            {
                Console.WriteLine("Your dog is 56 years old in human years.");
            }
            else if (howOld == 10)
            {
                Console.WriteLine("Your dog is 60 years old in human years.");
            }
            else if (howOld == 11)
            {
                Console.WriteLine("Your dog is 65 years old in human years.");
            }
            else if (howOld == 12)
            {
                Console.WriteLine("Your dog is 69 years old in human years.");
            }
            else if (howOld == 13)
            {
                Console.WriteLine("Your dog is 74 years old in human years.");
            }
            else if (howOld == 14)
            {
                Console.WriteLine("Your dog is 78 years old in human years.");
            }
            else if (howOld == 15)
            {
                Console.WriteLine("Your dog is 83 years old in human years.");
            }
            else if (howOld == 16)
            {
                Console.WriteLine("Your dog is 87 years old in human years.");
            }
            else
            {
                Console.WriteLine("Your dog is over 87 human years old. Maybe it's time for you to let your doggy go to the farm and run free.");
            }
            Console.ReadLine();
        }
    }
}
