using System;
namespace Lessons
{
    //filename Pear
    public partial class Pear
    {
        public Pear(string message)
        {
            Console.WriteLine(message);
            Peel();
            Color();
        }

        partial void Peel();
        partial void Color();
    }
}