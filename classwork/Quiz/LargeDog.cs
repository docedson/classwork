using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class LargeDog
    {
        int howOld;

        public void ageList()
        {
            Console.WriteLine("Your dog is considered a 'large' dog. Now, please enter your dog's age by whole years and press 'Enter'.");
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
                Console.WriteLine("Your dog is 45 years old in human years.");                
            }
            else if (howOld == 7)
            {
                Console.WriteLine("Your dog is 50 years old in human years.");                
            }
            else if (howOld == 8)
            {
                Console.WriteLine("Your dog is 55 years old in human years.");                
            }
            else if (howOld == 9)
            {
                Console.WriteLine("Your dog is 61 years old in human years.");                
            }
            else if (howOld == 10)
            {
                Console.WriteLine("Your dog is 66 years old in human years.");                
            }
            else if (howOld == 11)
            {
                Console.WriteLine("Your dog is 72 years old in human years.");                
            }
            else if (howOld == 12)
            {
                Console.WriteLine("Your dog is 77 years old in human years.");                
            }
            else if (howOld == 13)
            {
                Console.WriteLine("Your dog is 82 years old in human years.");                
            }
            else if (howOld == 14)
            {
                Console.WriteLine("Your dog is 88 years old in human years.");                
            }
            else if (howOld == 15)
            {
                Console.WriteLine("Your dog is 93 years old in human years.");                
            }
            else if (howOld == 16)
            {
                Console.WriteLine("Your dog is 120 years old in human years.");                
            }
            else
            {
                Console.WriteLine("Your dog is older than 120 human years. They may be a god, and you should worship them for making it this long.");
            }
            Console.ReadLine();
        }
    }
}
