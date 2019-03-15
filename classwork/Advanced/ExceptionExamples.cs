using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExamples
    {
        string _exampleNull = null;        

        public void MyExcemtpion()
        {
            try
            {
                _exampleNull = ("No longer null");
                Console.WriteLine(_exampleNull);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null exemption thrown" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block was called.");
            }
        }

        public void MyArrayException()
        {
            string[] names = { "Dave", "Matt", "Jody"};
            string[] values = { "243333", "42444444", "38543" };
            try
            {
                byte b = byte.Parse(values[1]); //Parse is for numbers, so this won't run with names in the string
                Console.WriteLine(b);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least one argument");
            }
            catch (FormatException e)
            {
                Console.WriteLine("That's not a number!");
            }
            catch (OverflowException eo)
            {
                Console.WriteLine("You've given me more than a byte!");//it will stop here, as the numbers are bigger than a byte (255 max)
            }
        }
    }
}
