using System;
namespace Lessons
{
    //filename Pear
    public partial class Pear
    {
        public Pear(string message)
        {
            Console.WriteLine(message);
        }

        partial void Peel();
    }
}