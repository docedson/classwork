using System;

namespace Quiz

{
    public class LabResults

    
    {
        /* public void Problem1()
        {



        }

        public void Problem2()
        {




        }

        public void Problem3()
        {
            double Feet;

            Console.WriteLine("How many feet would you like to convert? Please enter a number and press 'Enter'");
            Feet = double.Parse(Console.ReadLine());
            Console.ReadLine();

            LengthConversion myLengths = new LengthConversion();
            myLengths.ConversionFeet(Feet, LengthConversion.Measurements.Millimeters);
            myLengths.ConversionFeet(Feet, LengthConversion.Measurements.Centimeters);
            myLengths.ConversionFeet(Feet, LengthConversion.Measurements.Inches);
            myLengths.ConversionFeet(Feet, LengthConversion.Measurements.Meters);
            myLengths.ConversionFeet(Feet, LengthConversion.Measurements.Yards);


        }*/

        public void Problem4()
        {
            //Leap years can be divided by 4 or 400 - EXCEPT if they can be divided by 100, then they're not            
            
            Console.WriteLine("Please enter a 4 digit year to verify if it will be a Leap Year, and press 'Enter': ");
            int year = int.Parse(Console.ReadLine());

            if (year <= 999 || year >= 9999)
            Console.WriteLine("Your input is not a 4 digit year!");            

            if ((year % 4 == 0) && (year % 400 == 0) || (year % 100 !=0))
            Console.WriteLine("Your chosen year is a Leap Year!");
            
            else
                {
                    Console.WriteLine("Your chosen year is not a Leap Year.");
                }

                Console.Read();            

        }

        /*public void Problem5()
        {








        }*/




    }       
}