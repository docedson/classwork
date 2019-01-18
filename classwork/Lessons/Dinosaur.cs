using System;
namespace Lessons
{
    public abstract class Dinosaur : IPrehistoric
    {
        public abstract void EatFood();

        public virtual void Move()
        {
            Console.WriteLine("The dinosaur moves");
        }

        public abstract void SkinType();

        public abstract void Teeth();

    }
}