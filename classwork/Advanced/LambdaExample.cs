using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class LambdaExample
    {
        delegate int del(int i);

        public int MyLambdaOne(int value)
        {
            //(input-parameters) => expression-or-statement-block
            del myDelegate = x => x * x;
            return myDelegate(value);
        }
    }
}
