using System;
namespace classwork
{
    public class House
    {
        // The following are fields
        string _foundation;
        //string _roof;
        string _window;
        //string _door;

        // Standard long way of a Property
        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }

        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }

        // Shorthand property + field; Auto Property
        public string Roof { get; set; }

        public string PaintDoor { get; set; }

        public House() { }

        public House(string foundation, string window)//This will run the ": this" statement below first
        : this(foundation, window, "Shingles", "Green")
        { }
        //anything in the above brackets would run third in this area
        public House(string foundation, string window, string roof, string doorPaint) //This will run second after the above ": this"
        {
            this._foundation = foundation;
            this._window = window;
            this.Roof = roof;
            this.PaintDoor = doorPaint;
        }

        // The following are Methods
        public void OpenDoor()
        {
            Console.WriteLine("The door opens");
        }

        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
            {
                Console.WriteLine("Open front Door.");
            }
            else
            {
                Console.WriteLine("Open Bedroom door.");
            }
        }

        public void CloseDoor()
        {
            Console.WriteLine("The door closes");
        }
    }
}