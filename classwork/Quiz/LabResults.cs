using System;

namespace Quiz

{
    public class LabResults

    
    {
        public void Problem1()
        {
            Console.WriteLine("What would you like to determine today? Please enter 'V' for voltage, 'I' for current, or 'R' for resistance. Then press 'Enter'");
            string electAnswer = (Console.ReadLine().ToUpper());
            
            if(electAnswer == "V")
            {
                Console.WriteLine("Please enter your resistance and press 'Enter': ");
                double R;
                while(!double.TryParse(Console.ReadLine(), out R));
                Console.WriteLine("Please enter your current and press 'Enter':");
                double I;
                while(!double.TryParse(Console.ReadLine(), out I));
                double V = R * I;
                Console.WriteLine("Your voltage is:  " + V.ToString("0.00"));                
            }

            else if(electAnswer == "I")
            {
                Console.WriteLine("Please enter your voltage and press 'Enter': ");
                double V;
                while(!double.TryParse(Console.ReadLine(), out V));
                Console.WriteLine("Please enter your resistance and press 'Enter':  ");
                double R;
                while(!double.TryParse(Console.ReadLine(), out R));
                double I = V/R;
                Console.WriteLine("Your current is: " + I.ToString("0.00"));
            }

            else if(electAnswer == "R")
            {
                Console.WriteLine("Please enter your voltage and press 'Enter': ");
                double V;
                while(!double.TryParse(Console.ReadLine(), out V));
                double I;
                Console.WriteLine("Please enter your current and press 'Enter': ");
                while(!double.TryParse(Console.ReadLine(), out I));
                double R = V/I;
                Console.WriteLine("Your resistance is: " + R.ToString("0.00"));                
            }

            else
            {
                Console.WriteLine("You did not enter a valid option. Please start over.");
            }


        }

        /*public void Problem2()
        {
            int port = 5;
            HDTV myHD = new HDTV("$700.00", "65 In");
            myHD.TurnOn();
            myHD.Mountability(true);
            Console.WriteLine("There are " + myHD.ports + " ports availabe on this device.");

            FKTV myFK = new FKTV("1250.00", "75 In");
            myFK.Mountability(true);
            myFK.TurnOn();
            myFK.SmartApp();
            Console.WriteLine("There are " + myFK.ports + " ports availabe on this TV.");




        }

        public void Problem3()
        {
            double feet;

            Console.WriteLine("How many feet would you like to convert? Please enter a number and press 'Enter'");
            feet = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine(" " +feet + " feet is:");
            
            LengthConversion myLengths = new LengthConversion();
            myLengths.ConversionFeet(feet, LengthConversion.Measurements.Millimeters);
            myLengths.ConversionFeet(feet, LengthConversion.Measurements.Centimeters);
            myLengths.ConversionFeet(feet, LengthConversion.Measurements.Inches);
            myLengths.ConversionFeet(feet, LengthConversion.Measurements.Meters);
            myLengths.ConversionFeet(feet, LengthConversion.Measurements.Yards);


        }*/

        public void Problem4()
        {
            //Leap years can be divided by 4 or 400 - EXCEPT if they can be divided by 100, then they're not            
            
            Console.WriteLine("Please enter a 4 digit year to verify if it will be a Leap Year, and press 'Enter': ");
            int myYear = Convert.ToInt32(Console.ReadLine());

            if (myYear < 1000 || myYear > 9999)
            {
                Console.WriteLine("Your input is not a 4 digit year. Please press 'Enter' and start over.");
                return;
            }

            else
            {
                if ((myYear % 4 == 0) || (myYear % 100 == 0) || (myYear % 400 == 0))
                        Console.WriteLine("Your chosen year is a Leap Year! Please press 'Enter' to continue.");

                else
                {
                    Console.WriteLine("Your chosen year is not a Leap Year. Please press 'Enter' to continue.");
                }

            }
            Console.Read();            

        }

        /*public void Problem5()
        {








        }*/




    }       
}