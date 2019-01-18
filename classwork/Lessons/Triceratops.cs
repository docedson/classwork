using System;
namespace Lessons
{
    public class Triceratops : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("Triceratops eats");
        }

        public override void SkinType()
        {
            Console.WriteLine("Leathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Flat");
        }
    }
}