using System;
using System.Text;
using classwork;

namespace Lessons
{
    public class StringTypes
    {
        private string _testString = "Test String";
        private string _secondString = "Second String";

        public void SampleString()
        {
            Console.WriteLine(_testString);
        }

        public void AddString()
        {
            // _testString + " " +_secondString = This would add a space in the above "Test String" and "Second String" when ran
            Console.WriteLine(_testString + _secondString);
        }

        public string StringBuilderExample(string value1, string value2, string value3)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value1) //This and the next 2 lines can be on 1 line, just separated for class
            .Append(" ").Append(value2)
            .Append(" ").Append(value3);

            return builder.ToString();
        }

        public void CharTypeExample()
        {
            char ab = 'A';
            char de = 'B';
            char copyrightSymbol = '\u00A9'; // Unicode
            char hi = (char)88; // Explicit Case from int.

            Console.WriteLine(hi);
            Console.WriteLine(ab == de);
        }

        public void EscapeExample()
        {
            Console.WriteLine("My name is Roger O\'Dell");
            Console.WriteLine("This is an \aAlert");
            Console.WriteLine("Some sort of new line \nthat I cannot figure out.");
            Console.WriteLine("A sort of tab \tis around here somewhere");
        }

        public void PlaceholderExample()
        {
            Console.WriteLine("This string is {0}", "cool");
            Console.WriteLine("We can use ints like {0} and {1}", 15, 10);
            Console.WriteLine("I like {1} more than {0} but not as much as {2}", "sad", "happy", "funny");
        }

        public void ArraySample()
        {
            string[] cars = new string[3];
            cars[0] = "camaro";
            cars[1] = "mustang";
            cars[2] = "chevelle";

            //or this version
            string[] names = {"Tom", "Roger", "Matt"};
            Console.WriteLine(cars[1]);
            Console.WriteLine(names[0]);

        }

        public void MyHouseArray()
        {
            House house1 = new House();
            house1.PaintDoor = "Green";
            House house2 = new House();
            house2.PaintDoor = "Blue";

            House[] houseList = {house1,house2};

            Console.WriteLine(houseList[0].PaintDoor);                        
        }

        public void MultiArraySample()
        {
            int[,] myIntArray = new int[2, 2];
            myIntArray[0, 0] = 5;
            myIntArray[0, 1] = 10;
            myIntArray[1, 0] = 2;
            myIntArray[1, 1] = 4;
            
            Console.WriteLine(myIntArray[1, 0]);
        }

    }


}