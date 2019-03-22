using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public delegate void ExampleCallback(int linecount);

    public class ThreadWithState
    {
        private string _boilerplate;
        private int _value;
        private ExampleCallback _callback;
        public ThreadWithState(string text, int number, ExampleCallback callbackDelegate)
        {
            this._boilerplate = text;
            this._value = number;
            this._callback = callbackDelegate;
        }

        public void ThreadProc()
        {
            Console.WriteLine(_boilerplate, _value);
            if (_callback != null) { _callback(1); }
        }
    }
}
