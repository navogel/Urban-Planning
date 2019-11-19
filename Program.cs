using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 23.5,
                Depth = 230.9,
                Stories = 1
            };
             Building SixSeven = new Building("6 7th Ave")
            {
                Width = 32,
                Depth = 2.3,
                Stories = 500
            };
             Building EightNine = new Building("8 9th Avenue")
            {
                Width = 23.5,
                Depth = 34,
                Stories = 5
            };
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("steve stevely");
            FiveOneTwoEigth.GetInfo();
            SixSeven.Construct();
            SixSeven.Purchase("Bill Mcgee");
            SixSeven.GetInfo();
            EightNine.Construct();
            EightNine.Purchase("Willie Am");
            EightNine.GetInfo();
            
            
        }
    }
}