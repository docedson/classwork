using System;
using ExtraStruct5;


namespace Quiz
{
    public class LabResults
    
    {
        public string ports { get; private set; }

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

        public void Problem2()
        {
            Console.WriteLine("Which TV are you considering? Please enter '1' for the HDTV, and '2' for the 4K TV. Then press 'Enter'");
            int myTV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            if (myTV == 1)
            {
                Console.WriteLine("You have chosen the HDTV model. With this model, the specs are: ");
                Console.WriteLine("----------------------------------------------------------------");
                HDTV myHD = new HDTV("80 inches", "900.00");
                myHD.Mounty(false);
                myHD.TurnOn();
                myHD.SmartApp();
                Console.WriteLine("However, this model does have " + myHD.ports + " ports available for your needs.");
            }

            else if (myTV == 2)
            {
                Console.WriteLine("You have chosen the 4K TV model. With this model, the specs are: ");
                Console.WriteLine("----------------------------------------------------------------");
                FKTV myFK = new FKTV("100 inches", "3000.00");
                myFK.Mounty(true);
                myFK.TurnOn();
                myFK.SmartApp();
                Console.WriteLine("Finally, this model has " + myFK.ports + " ports available for your needs.");
            }

            else
            {
                Console.WriteLine("You did not enter a valid option. Please start over.");
            }
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
        }

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

        public void Problem5()
        {
            moreTV HD;
            moreTV FK;

            //moreTV myMore = new moreTV();
            HD.price = "$2000.00";
            HD.size = "75 inches";
            HD.ports = 2;
            HD.isMountable = false;            

            Console.WriteLine("The price of this HD TV is {0}.", HD.price);
            Console.WriteLine("It is {0} wide.", HD.size);
            Console.WriteLine("You will get {0} available ports.", HD.ports);
            Console.WriteLine("Also, it is {0} that this TV is mountable.", HD.isMountable);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(" ");

            FK.price = "$4500.00";
            FK.size = "95 inces";
            FK.ports = 5;
            FK.isMountable = true;

            Console.WriteLine("The price of this 4K TV is {0}.", FK.price);
            Console.WriteLine("It is {0} wide.", FK.size);
            Console.WriteLine("You will get {0} available ports.", FK.ports);
            Console.WriteLine("Also, it is {0} that this TV is mountable.", FK.isMountable);
        }

        public void Problem6()
        {
            double dogWeight;

            SmallDog mySmall = new SmallDog();
            MedDog myMed = new MedDog();
            LargeDog myLarge = new LargeDog();

            Console.WriteLine("To figure out your dog's age compared to a human's age, please enter your dog's weight and press 'Enter'.");
            dogWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("");
                
            {
                if (dogWeight <= 20)
                {
                    mySmall.ageList();
                    mySmall.dogYears();
                }
                else if (dogWeight >= 21 && dogWeight <= 49)
                {
                    myMed.ageList();
                    myMed.dogYears();
                }
                else if (dogWeight >= 50)
                {
                    myLarge.ageList();
                    myLarge.dogYears();
                }

            }
        }
    }
}
