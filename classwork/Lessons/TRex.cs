using System;
namespace Lessons
{
    public class TRex : Dinosaur, IPrehistoric
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }

        public override void Move()
        {
            Console.WriteLine("TRex runs");
        }

        public override void SkinType()
        {
            Console.WriteLine("Feathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Razor sharp");
        }
    }
}