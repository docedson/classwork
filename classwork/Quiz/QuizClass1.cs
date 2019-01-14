using System;
namespace Quiz
{
    public class QuizClass1
    {
        public string GradeList(string grades)
        {
            //Console.WriteLine("What grade did you receive?:");
            //grades = (Console.ReadLine().ToUpper());

            switch (grades)
            {
                case "E":
                    return "Excellent";
                case "V":
                    return "Very Good";
                case "G":
                    return "Good";
                case "A":
                    return "Average";
                case "F":
                    return "Fail";
                default:
                    return "A valid grade was not chosen.";
            }

        }

        public void QuizNums()
        {
            for (int i = 0; i < 50; i++)
                if (i % 3 == 0)
                {
                    Console.WriteLine("number = {0}", i);
                }
        }
    }
}