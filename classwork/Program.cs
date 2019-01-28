using System;
using Lessons;
using Quiz;

//This namespace represents the file folder that the class is in.
namespace classwork
{
    // Class is a blueprint of an object.
    class Program
    {
        /*static is only one, void is a return type, Main is the method name, string[] is an array and a parameter */
        static void Main(string[] args)
        {
            //Console is a class, WriteLine is a method with a parameter
            //Console.WriteLine("Hello World!");
            //MyHouseResults();
            //MyNumericExamples();
            //OtherNumericExamples();
            //MyStringExamples();
            //StatementSamples();
            //HouseSample();
            //StructureSample();
            //QuizGrades();
            //FruitSample();
            //ParamSample();
            //ModifierExamples();
            //Lesson12();
            //AbstractDemo();
            //DeconstructSample();
            //FinalizerSample();
            //IndexerSample();
            //PartialSample();
            //AnotherHouseExample();
            //GenericSample();
            CollectionSample();
        }

        static void CollectionSample()
        {
            CollectionExamples ce = new CollectionExamples();
            ce.MyArrayListExample();
            ce.MyListExample();
        }

        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);
            Console.WriteLine(myList);

            GenericList<string> mySecondList = new GenericList<string>();
            mySecondList.Add("Happy");

            GenericList<TRex> myTRexList = new GenericList<TRex>();
            myTRexList.Add(new TRex());
        }

        static void AnotherHouseExample()
        {
            House myHouse = new House()
            {
                Roof = "Shingles",
                Window = "Doulbe Pane",
                PaintDoor = "Red",
                Foundation = "Concrete"
            };

            Console.WriteLine("My window choice is {0}", myHouse.Window);
        }

        static void PartialSample()
        {
            Pear pear = new Pear("yellow");
        }

        static void IndexerSample()
        {
            IndexerExample indexExample = new IndexerExample();
            indexExample[2] = 250;

            for (int i = 0; i < indexExample.Length; i++)
            {
                Console.WriteLine("Value {0} = {1}", i, indexExample[i]);
            }
        }

        static void FinalizerSample()
        {
            FinalizerExample finalExample = new FinalizerExample("John", "Doe");
        }

        static void DeconstructSample()
        {
            string first = "Tom", last = "Jones";

            Lesson13 lesson13 = new Lesson13("John", "Doe");
            Console.WriteLine("First name = {0}, and last name = {1}", first, last);

            lesson13.Deconstruct(out first, out last);
            Console.WriteLine("First name = {0}, and last name = {1}", first, last);

        }

        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Move();
            trex.SkinType();

            triceratops.EatFood();
            triceratops.Move();
            triceratops.Teeth();
        }

        static void Lesson12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp);
            Console.WriteLine(temp2);
        }


        static void ModifierExamples()
        {
            int test = 14;
            Lesson11 myLesson = new Lesson11();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);
            string first, middle, last;
            myLesson.OutSample("John Riley Doe", out first, out middle, out last);

            Console.WriteLine(first);
            Console.WriteLine(middle);
            Console.WriteLine(last);
        }

        static void ParamSample()
        {
            Lesson11 lesson = new Lesson11();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams();

            int[] intArray = { 2, 3, 4, 5, 6 };
            lesson.UseParams(intArray);

            lesson.UseParams2(1, "happy", false, 34.5F);

            lesson.OptionalParam("Roger");
            lesson.OptionalParam("Matthew", 19);
        }

        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Apple();
            myFruit.EatFruit();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
        }

        static void QuizGrades()
        {
            QuizClass1 se = new QuizClass1();
            Console.WriteLine(se.GradeList("A"));

            se.QuizNums();
        }

        static void StructureSample()
        {
            BookSample bookSample = new BookSample(4.99m, "Zombie Fallout", "Mark Tufo");

            Console.WriteLine("The book '" + bookSample.title + "' by " + bookSample.author + " is $" + bookSample.price);
        }

        static void HouseSample()
        {
            House myHouse = new House("Concrete", "triple pane");
            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);
            myHouse.OpenDoor(true);
        }

        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            //se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(10);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.SampleForEach();
            //string myString = se.JumpStatementExample("Sunday");
            //Console.WriteLine(myString);
            //BottlesSong();
            //se.SampleDays(DaysOfWeek.Wed);            
        }

        static void BottlesSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);
        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C Sharp", "Class");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceholderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();
        }

        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();

            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();
            myTypes.CheckOperators();
            myTypes.IncrementDecrement();
            myTypes.SpecialValues();
            myTypes.ComparisonOperators();

        }

        static void OtherNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.OtherOperators();
        }

        static void MyHouseResults()
        {
            // Created and object instance of House called myHouse
            House myHouse = new House();
            // This sets the value of Red to the object
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor(); // the door closes
                                 // This gets the value of Red from the object
            Console.WriteLine(myHouse.PaintDoor); // red
                                                  // This is a second object instance of House.
            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor); // green
            Console.WriteLine(myHouse.PaintDoor); // red
        }
    }
}
