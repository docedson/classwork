using System;
namespace Lessons
{
    public class FinalizerExample
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public FinalizerExample(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        ~FinalizerExample()
        {
            System.Diagnostics.Trace.WriteLine("Finalizer called");
        }
    }
}