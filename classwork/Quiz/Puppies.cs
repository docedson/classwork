using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Puppies : LabResults
    {
        public double dogYear1, dogYear2, dogYear3;
        
        switch (dogAge)
            {
                case 1:
                    Console.WriteLine("From the information you have provided, your dog is 15 human years old.");
                    break;

                case 2:
                    Console.WriteLine("From the information you have provided, your dog is 24 human years old.");
                    break;

                case 3:
                    Console.WriteLine("From the information you have provided, your dog is 28 human years old.");
                    break;

                case 4:
                    Console.WriteLine("From the information you have provided, your dog is 32 human years old.");
                    break;

                case 5:
                    Console.WriteLine("From the information you have provided, your dog is 36 human years old.");
                    break;

            }
    }
}
