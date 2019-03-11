using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class LargeDog
    {
        int howOld;
        int peopleOld;

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
                peopleOld = ((howOld - 1) * 4) + 15;
                Console.WriteLine("Your dog is " + peopleOld + " years old in human years.");
            }

            else if (howOld >= 2 && howOld <= 5)
            {
                peopleOld = ((howOld - 1) * 4) + 20;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 6)
            {
                peopleOld = ((howOld - 1) * 4) + 25;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 7)
            {
                peopleOld = ((howOld - 1) * 4) + 26;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }


            else if (howOld == 8)
            {
                peopleOld = ((howOld - 1) * 4) + 27;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 9)
            {
                peopleOld = ((howOld - 1) * 4) + 29;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 10)
            {
                peopleOld = ((howOld - 1) * 4) + 30;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 11)
            {
                peopleOld = ((howOld - 1) * 4) + 32;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 12)
            {
                peopleOld = ((howOld - 1) * 4) + 33;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 13)
            {
                peopleOld = ((howOld - 1) * 4) + 34;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 14)
            {
                peopleOld = ((howOld - 1) * 4) + 36;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 15)
            {
                peopleOld = ((howOld - 1) * 4) + 37;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else if (howOld == 16)
            {
                peopleOld = ((howOld - 1) * 4) + 60;
                Console.WriteLine("Your dog is " +peopleOld +" years old in human years.");
            }

            else
            {
                Console.WriteLine("Your dog is more than 120 human years old. You should consider them godlike, and perhaps fear them.");
            }
        }
    }
}
