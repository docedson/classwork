using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class MedDog
    {
        int howOld;
        int peopleOld;

        public void ageList()
        {
            Console.WriteLine("Your dog is considered a 'medium' dog. Now, please enter your dog's age by whole years and press 'Enter'.");
            howOld = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
        }

        public void dogYears()
        {
            if (howOld == 1)
            {
                peopleOld = ((howOld - 1) * 4) + 15;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld >= 2 && howOld <= 5)
            {                
                peopleOld = ((howOld - 1) * 4) + 20;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 6)
            {                
                peopleOld = ((howOld - 1) * 4) + 22;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");                
            }

            else if (howOld == 7 || howOld == 8)
            {                
                peopleOld = ((howOld - 1) * 4) + 23;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }

            else if (howOld == 9 || howOld == 10)
            {
                peopleOld = ((howOld - 1) * 4) + 24;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }

            else if (howOld == 11 || howOld == 12)
            {
                peopleOld = ((howOld - 1) * 4) + 25;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }

            else if (howOld == 13 || howOld == 14)
            {                
                peopleOld = ((howOld - 1) * 4) + 26;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }

            else if (howOld == 15 || howOld == 16)
            {
                peopleOld = ((howOld - 1) * 4) + 27;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }
            else
            {
                Console.WriteLine("Your dog is over 87 human years old. It's time for you to take your doggy on the trip of his lifetime.");
            }
        }
    }
}
