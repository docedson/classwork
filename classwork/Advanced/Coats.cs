using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    /*
     Delegate - A type that represents references to method
     Return - string
     Parameter - string
         */
    public delegate string MyCoat(string message);

    public class Coats
    {
        /*
         Event - Enable a class or object to notify other classes
         or objects when something of interest occurs.
         MyCoat - Delegate Object
             */
        public event MyCoat MyEventCoat;

        /* string property with a private setter used by the class*/
        public string MyResult { get; private set; }

        // Default Constructor
        public Coats()
        {
            /* Subcriber of the delegate to the event */
            this.MyEventCoat += new MyCoat(this.MyFavoriteCoat);

            /* Subscriber result passed to the property */
            MyResult = MyEventCoat("Trench");
        }

        /* Method with a string return type and string parameter*/
        public string MyFavoriteCoat(string message)
        {
            return "My favorite coat is " + message;
        }
    }
}