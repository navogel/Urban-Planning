using System;

namespace Planner
{
    public class Building
    {
        //fields
        private string _designer = "Nate Vogel";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        //constructor

        public Building(string address)
        {
            _address = address;
        }

        //properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return (Width * Depth * (3 * Stories));
            }
        }

        //public methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public void GetInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine($" Designed by: {_designer}");
            Console.WriteLine($" Created on {_dateConstructed}");
            Console.WriteLine($"owned by: {_owner}");
            Console.WriteLine($"{Volume} cubic maters of space");
        }

    }
}