using System;
namespace Quiz

{
    public class LengthConversion
    {
        public enum Measurements {Millimeters, Centimeters, Inches, Meters, Yards}

        public void ConversionFeet(double feet, Measurements feetChange)

        {
            switch(feetChange)
            {
                case Measurements.Millimeters:
                double total = Math.Floor(feet * 304.8) / 100;
                Console.WriteLine(" " +total + " " + Measurements.Millimeters);
                break;                    

                case Measurements.Centimeters:
                double total1 = Math.Floor(feet * 30.48) / 100;
                Console.WriteLine(" " +total1 + " " + Measurements.Centimeters);
                break;

                case Measurements.Inches:
                double total2 = Math.Floor(feet * 12) / 100;
                Console.WriteLine(" " +total2 + " " + Measurements.Inches);
                break;

                case Measurements.Meters:
                double total3 = Math.Floor(feet * 0.3048) / 100;
                Console.WriteLine(" " +total3 + " " + Measurements.Meters);
                break;

                case Measurements.Yards:
                double total4 = Math.Floor(feet * 0.33333333333) / 100;
                Console.WriteLine(" and " + total4 + " " + Measurements.Yards);
                break;

            }
        }

    }

}