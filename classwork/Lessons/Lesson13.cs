using System;
namespace Lessons
{
    public class Lesson13
    {
        string _firstName, _lastName;

        public Lesson13(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            Console.WriteLine("Constructor called");
        }

        public void Deconstruct(out string _firstName, out string _lastName)
        {
            _firstName = this._firstName;
            _lastName = this._lastName;
            Console.WriteLine("Deconstruct called");
        }
    }
}