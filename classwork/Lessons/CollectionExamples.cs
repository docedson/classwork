using System.Collections;
using System.Collections.Generic;
using System;
namespace Lessons
{
    public class CollectionExamples
    {
        public void MyListExample()
        {
            List<Dinosaur> myDino = new List<Dinosaur>();
            myDino.Add(new TRex());
            myDino.Add(new TRex() { Travel = "Stomp" });
            myDino.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dino in myDino)
            {
                Console.WriteLine("These dinos travel by {0}", dino.Travel);
                Console.WriteLine(dino);
            }
        }


        public void MyArrayListExample()
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add("world");
            myArrayList.Add(42);
            myArrayList.Add(84);

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Remove(42);
            myArrayList.RemoveAt(0); //"RemoveAt" uses the place, which is 0 here, which is "Hello"

            Console.WriteLine("Count = {0}", myArrayList.Count);

            myArrayList.Add("Other");
            myArrayList.Add("Stuff");

            foreach (Object item in myArrayList)
            {
                Console.WriteLine("Type = {0}", item);
            }
        }
    }
}