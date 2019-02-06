using System;
namespace Quiz

{
    public class LengthConversion
    {
        public enum Measurements {Millimeter, Centimeter, Inches, Meter, Yard}

        public void ConversionFeet(double Feet, Measurements LengthMath)
        {
            double Millimeter = Math.Floor(Feet * 304.8);
            double Centimeter = Math.Floor(Feet * 30.48);
            double Inches = Math.Floor(Feet * 12);
            double Meter = Math.Floor(Feet * 0.3048);
            double Yard = Math.Floor(Feet * 0.33333333333);



            /*switch (LengthMath)
            {
                case Measurements.Millimeter:
                double Solution = Math.Floor(Feet * 304.8);
                Console.WriteLine(Solution + " " + Measurements.Millimeter);
                break;

                case Measurements.Centimeter:
                double Solution2 = Math.Floor(Feet * 30.48);
                Console.WriteLine(Solution2 + " " + Measurements.Centimeter);
                break;

                case Measurements.Inches:
                double Solution3 = Math.Floor(Feet * 12);
                Console.WriteLine(Solution3 + " " + Measurements.Inches);
                break;

                case Measurements.Meter:
                double Solution4 = Math.Floor(Feet * 0.3048);
                Console.WriteLine(Solution4 + " " + Measurements.Meter);
                break;

                case Measurements.Yard:
                double Solution5 = Math.Floor(Feet * 0.33333333333);
                Console.WriteLine(Solution5 + " " + Measurements.Yard);
                break;
                



            }*/
        }




    }

}