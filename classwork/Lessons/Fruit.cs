using System;
namespace Lessons
{
    public class Fruit
    {
        public void EatFruit()
        {
            Console.WriteLine("I eat fruit");
        }
        // Private is only accessible from within the class
        private void ThrowFruit()
        {
            Console.WriteLine("Throw fruit");
        }

    }
}