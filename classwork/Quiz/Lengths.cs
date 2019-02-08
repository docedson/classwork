using System;
namespace Quiz

{
    public class LengthConversion
    {
        public enum Measurements {Millimeters, Centimeters, Inches, Meters, Yards}

        public void ConversionFeet(double Feet, Measurements feetConvert)
        {
            switch(feetConvert)
            {
                case Measurements.Millimeters:
                double total = Math.Floor(Feet * 304.8) / 100;
                Console.WriteLine(total + " " + Measurements.Millimeters);
                break;

                case Measurements.Centimeters:
                double total1 = Math.Floor(Feet * 30.48) / 100;
                Console.WriteLine(total1 + " " + Measurements.Centimeters);
                break;

                case Measurements.Inches:
                double total2 = Math.Floor(Feet * 12) / 100;
                Console.WriteLine(total2 + " " + Measurements.Inches);
                break;

                case Measurements.Meters:
                double total3 = Math.Floor(Feet * 0.3048) / 100;
                Console.WriteLine(total3 + " " + Measurements.Meters);
                break;

                case Measurements.Yards:
                double total4 = Math.Floor(Feet * 0.33333333333) / 100;
                Console.WriteLine(total4 + " " + Measurements.Yards);
                break;

            }
        }

    }

}