using System;
namespace Lessons
{
    public class Lesson11
    {
        public const int MY_VALUE = 25;

        /*
            Method to demonstrate a constant which cannot change its value
        */

        public void SampleLesson11()
        {
            const string today = "Wednesday";
            //MY_VALUE = 35; //Cannot change the value
            //Can use it with other variables
            int total = MY_VALUE * 2;
            Console.WriteLine(total);

            // Can't change value of method level constant
            //today = "Friday";
        }

        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void UseParams2(params object[] items) //"object" here means you can use any type, its not defined
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void OptionalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old");
        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
        }

        public void OutSample(string name, out string firstName, out string middle, out string lastName)
        {

            int myIndex = name.IndexOf(' ');//because of LastIndexOf, you can put multiple words, but it will find the last space and print the
            firstName = name.Substring(0, myIndex);//next word on the next line. ie: "John Doe Mania" will print "John Doe" (break) "Mania"

            string otherName = name.Substring(myIndex + 1);
            int myOther = otherName.LastIndexOf(" ");

            middle = otherName.Substring(0, myOther);
            lastName = otherName.Substring(myOther + 1);
        }

    }
}