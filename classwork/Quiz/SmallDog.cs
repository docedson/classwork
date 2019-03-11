using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class SmallDog
    {
        int howOld;
        int peopleOld;
        
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
                peopleOld = ((howOld - 1) * 4) + 15;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }
            else if (howOld >= 2 && howOld <= 16)
            {
                peopleOld = ((howOld - 1) * 4) + 20;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }
            else
            {
                Console.WriteLine("Your dog is over 80 human years old. It's time to let them eat all the chocolate they want!");
            }            
        }
    }
}
