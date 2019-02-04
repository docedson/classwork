using System;
namespace Quiz

{
    public class LabResults
    {
        //Finding the current
        public void Current()
        {
            Console.WriteLine("What is the voltage? ", myVolt);
            decimal myVolt = decimal.Parse(Console.ReadLine());
            Console.WriteLine("What is the resistance? ", myResist);
            decimal myResist = decimal.Parse(Console.ReadLine());

            decimal myCurrent = (myVolt/myResist);
            Console.WriteLine("Your current is {0}");            
        }

        public double calcCurrent(double myVolt, double myResist)
        {
            return myVolt / myResist;
        }

        //Finding the voltage
        public void Voltage()
        {
            double myCurrent, myResist;

            Console.WriteLine("What is the currant? ");
            myCurrent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the resistance? ");
            myResist = Convert.ToDouble(Console.ReadLine());

            double Voltage = LabResults.calcVoltage(myCurrent, myResist);
            Console.WriteLine(Voltage);
            Console.ReadLine();
        }

        public static double calcVoltage(double myCurrent, double myResist)
        {
            return myCurrent / myResist;
        }

        //Finding the resistance
        public void Resist()
        {
            double myVolt, myCurrent;

            Console.WriteLine("What is the voltage? ");
            myVolt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the current? ");
            myCurrent = Convert.ToDouble(Console.ReadLine());

            double Resist = LabResults.calcResist(myVolt, myCurrent);
            Console.WriteLine(Resist);
            Console.ReadLine();
        }

        public static double calcResist(double myVolt, double myCurrent)
        {
            return myVolt / myCurrent;
        }



       

    }
}