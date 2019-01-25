using System;
namespace Lessons
{
    public class IndexerExample
    {
        private int[] _numbers = new int[5] { 100, 200, 300, 400, 500 };
        public int Length
        {
            get { return _numbers.Length; }
        }

        public int this[int index] //indexers use the "this" statement
        {
            get { return _numbers[index]; }
            set { _numbers[index] = value; }
        }
    }
}